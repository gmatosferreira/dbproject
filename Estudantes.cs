using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using BrightIdeasSoftware;

namespace Funcionarios
{
    public partial class Estudantes : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0;

        public Estudantes(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            InitializeComponent();
            this.nmec.GroupKeyGetter = delegate (object rowObject)
            {
                // When the same is returned by every object, all of them are put together in one group
                return "Número mecanográfico";
            };
            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome";
            };

            this.nomeEE.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome Enc Educ";
            };

            this.telemovelEE.GroupKeyGetter = delegate (object rowObject)
            {
                // Group phones by the first two digits (phone company indicator)
                Estudante e = (Estudante)rowObject;
                if (e.telemovelEE.ToString().Length > 2)
                    return e.telemovelEE.ToString().Substring(0, 2);
                return "Outros";
            };
            this.email_EE.GroupKeyGetter = delegate (object rowObject)
            {
                // Group emails by domain (text after @ symbol)
                Estudante e = (Estudante)rowObject;
                return e.emailEE.Split('@')[1];
            };
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaAtributo.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listObjects.UseFiltering = true;
        }
        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " registos";
        }
        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Estudante e = (Estudante)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = e.nome;
            panelObjectSubtitulo.Text = e.nmec.ToString();
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
        }

        private void editObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Estudante e = (Estudante)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNMec.Text = e.nmec.ToString();
            panelFormFieldNome.Text = e.nome;
            panelFormFieldNomeEE.Text = e.nomeEE;
            panelFormFieldContacto.Text = e.telemovel.ToString();
            panelFormFieldContactoEE.Text = e.telemovelEE.ToString();
            panelFormFieldEmail.Text = e.email;
            panelFormFieldEmailEE.Text = e.emailEE;

            // Disable fields not changable
            panelFormFieldNMec.Enabled = false;
            // Set title and description
            panelFormTitulo.Text = "Editar estudante " + e.nmec.ToString();
            panelFormDescricao.Text = "Altere os dados e submita o formulário";
            panelFormButton.Text = "Submeter";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void addObject()
        {
            // Clear all fields
            panelFormFieldNMec.Text = "";
            panelFormFieldNome.Text = "";
            panelFormFieldNomeEE.Text = ""; 
            panelFormFieldContacto.Text = "";
            panelFormFieldContactoEE.Text = "";
            panelFormFieldEmail.Text = "";
            panelFormFieldEmailEE.Text = "";

            // Enable fields that are not editable
            panelFormFieldNMec.Enabled = true;
            // Set title and description
            panelFormTitulo.Text = "Adicionar um novo estudante";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar estudante";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Estudante e = (Estudante)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Esta operação é irreversível!", "Tem a certeza que quer eliminar o estudante " + e.nmec.ToString() + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Delete tuple on db 
            String commandText = "DELETE FROM GestaoEscola.Estudante WHERE NMec = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = e.nmec;

            // Execute query 
            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro, tente novamente!\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If successful query 
            if (rowsAffected == 3)
            {
                // Remove object from interface list 
                listObjects.RemoveObject(e);
                // Show user feedback 
                MessageBox.Show(
                    "O tuplo foi eliminado com sucesso da base de dados!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update stats
                updateStats();
                // Hide panels 
                panelForm.Visible = false;
                panelObject.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Ocorreu um erro, tente novamente!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            // Hide panels
            panelForm.Visible = false;
            panelObject.Visible = false;
        }

        private void pesquisar()
        {
            // Get attribute and value fields text
            String atr = pesquisaAtributo.Text;
            String val = pesquisaTexto.Text;
            if (atr == "" || val == "")
            {
                // If one of them is empty, don't filter
                this.listObjects.ModelFilter = null;
            }
            else
            {
                // Define filtering
                this.listObjects.ModelFilter = new ModelFilter(delegate (object x) {
                    Estudante est = (Estudante)x;
                    String toFilter = "";
                    switch (atr)
                    {
                        case "Número mecanográfico":
                            toFilter = est.nmec.ToString();
                            break;
                        case "Nome Enc Educ":
                            toFilter = est.nomeEE.ToString();
                            break;
                        case "Nome":
                            toFilter = est.nome;
                            break;
                        case "Contacto Enc Educ":
                            toFilter = est.telemovelEE.ToString();
                            break;
                        case "Email Enc Educ":
                            toFilter = est.emailEE;
                            break;
                    }
                    if (toFilter.Contains(val))
                        return true;
                    return false;
                });
            }
            updateStats();
            // Hide data panel (both edit and data)
            panelObject.Visible = false;
            panelForm.Visible = false;
        }

        // Event handlers
        private void Estudantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When form closed, show the previous one (main interface form)
            this.previous.Show();
        }

        private void Estudantes_Load(object sender, EventArgs e)
        {
            // Execute SQL query
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Estudantes WHERE nomeEE IS NOT NULL", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Estudante> estudantes = new List<Estudante>();
            while (reader.Read())
            {
                Estudante est = new Estudante();
                est.nmec = Int32.Parse(reader["NMec"].ToString());
                est.nome = reader["nome"].ToString();
                est.nomeEE = reader["NomeEE"].ToString();
                est.telemovelEE = Int32.Parse(reader["contactoEE"].ToString());
                est.telemovel = Int32.Parse(reader["telemovel"].ToString());
                est.email = reader["emailComposed"].ToString(); 
                est.emailEE = reader["EEemailComposed"].ToString();
                estudantes.Add(est);
                counter++;
            }

            // ObjectListView
            // Add Objects to list view
            listObjects.SetObjects(estudantes);

            // Update stats
            updateStats();

            // Close reader
            reader.Close();
        }

        private void panelObjectEsconder_Click(object sender, EventArgs e)
        {
            // Hide data panel (both edit and data)
            panelObject.Visible = false;
            panelForm.Visible = false;
        }

        private void panelObjectEditar_Click(object sender, EventArgs e)
        {
            // Edit object btn
            if (listObjects.SelectedIndex >= 0)
            {
                editObject();
            }
        }

        private void buttonAdicionarObject_Click(object sender, EventArgs e)
        {
            // Add object btn
            addObject();
        }

        private void panelFormHide_Click(object sender, EventArgs e)
        {
            // Hide pannel
            panelForm.Visible = false;
        }

        private void panelObjectEliminar_Click(object sender, EventArgs e)
        {
            // Delete Object btn
            if (listObjects.SelectedIndex >= 0)
            {
                deleteObject();
            }
        }

        private Boolean formValid()
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb = new StringBuilder();
            if (!RegexExpressions.isInteger(panelFormFieldNMec.Text))
            {
                error = true;
                sb.Append(" NMec");
            }
            if (!RegexExpressions.isPhoneNumber(panelFormFieldContacto.Text))
            {
                error = true;
                sb.Append(" Telemovel");
            }
            if (!RegexExpressions.isPhoneNumber(panelFormFieldContactoEE.Text))
            {
                error = true;
                sb.Append(" Telemovel EE");
            }
            if (!RegexExpressions.isEmail(panelFormFieldEmail.Text))
            {
                error = true;
                sb.Append(" Email");
            }
            if (!RegexExpressions.isEmail(panelFormFieldEmailEE.Text))
            {
                error = true;
                sb.Append(" Email EE");
            }
            // Check others
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 65)
            {
                error = true;
                sb.Append(" Nome (max 65 caracteres)");
            }

            if (panelFormFieldNomeEE.Text == "" || panelFormFieldNomeEE.Text.Length > 65)
            {
                error = true;
                sb.Append(" Nome EE (max 65 caracteres)");
            }

            // Give user feedback
            if (error)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente os seguintes campos:" + sb.ToString(),
                   "Atenção!",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Exclamation
               );
            }
            return !error;
        }

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            if (formValid())
            {
                // Edit 
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((Estudante)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitForm(null);
                }
            }
        }

        private void submitForm(Estudante e)
        {
            bool edit = (e != null);

            // Get form data 
            int nmec = Int32.Parse(panelFormFieldNMec.Text);
            String nome = panelFormFieldNome.Text;
            String nomeEE = panelFormFieldNomeEE.Text;
            int tel = Int32.Parse(panelFormFieldContacto.Text);
            int telEE = Int32.Parse(panelFormFieldContactoEE.Text);
            String emailPrefixo = panelFormFieldEmail.Text.Split('@')[0];
            String emailDominio = panelFormFieldEmail.Text.Split('@')[1];
            String emailPrefixoEE = panelFormFieldEmailEE.Text.Split('@')[0];
            String emailDominioEE = panelFormFieldEmailEE.Text.Split('@')[1];

            // Create command 
            String commandText = "GestaoEscola.EstudanteSP";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;

            // Add vars 
            command.Parameters.Add("@NMec", SqlDbType.Int);
            command.Parameters["@NMec"].Value = nmec;
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters["@Nome"].Value = nome;
            command.Parameters.Add("@Telemovel", SqlDbType.Int);
            command.Parameters["@Telemovel"].Value = tel;
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters["@Email"].Value = emailPrefixo;
            command.Parameters.Add("@EmailDominio", SqlDbType.VarChar);
            command.Parameters["@EmailDominio"].Value = emailDominio;
            command.Parameters.Add("@NomeEE", SqlDbType.VarChar);
            command.Parameters["@NomeEE"].Value = nomeEE;
            command.Parameters.Add("@TelemovelEE", SqlDbType.Int);
            command.Parameters["@TelemovelEE"].Value = telEE;
            command.Parameters.Add("@EmailEE", SqlDbType.VarChar);
            command.Parameters["@EmailEE"].Value = emailPrefixoEE;
            command.Parameters.Add("@EmailDominioEE", SqlDbType.VarChar);
            command.Parameters["@EmailDominioEE"].Value = emailDominioEE;
            command.Parameters.Add("@Edit", SqlDbType.Bit);
            command.Parameters["@Edit"].Value = 0;

            if (edit)
                command.Parameters["@Edit"].Value = 1;
            // Return value stuff
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            // Execute query 
            int rowsAffected = 0;
            int returnValue;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                returnValue = (int)returnParameter.Value;
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If query is successful 
            if (rowsAffected == 2 && returnValue == 1)
            {
                // If add operation, construct object (was null)
                if (!edit)
                    e = new Estudante();
                e.nmec = nmec;
                e.nome = nome;
                e.email = emailPrefixo + "@" + emailDominio;
                e.telemovel = tel;
                e.nomeEE = nomeEE;
                e.emailEE = emailPrefixoEE + "@" + emailDominioEE;
                e.telemovelEE = telEE;
                if (!edit)
                    listObjects.AddObject(e);
                // SHow feedback to user 
                String successMessage = "O estudante foi adicionado com sucesso!";
                if (edit)
                    successMessage = "O estudante foi editado com sucesso";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update objects displayed on interface 
                listObjects.BuildList(true);
                // Update stats
                updateStats();
                // Hide panels 
                panelForm.Visible = false;
                panelObject.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pesquisaTexto_TextChanged(object sender, EventArgs e)
        {
            // When textbox value changes, compute new search
            pesquisar();
        }

        private void pesquisaAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When attr combobox value changes, compute new search
            pesquisar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudante est = (Estudante)listObjects.SelectedObjects[0];
            Mensagens m = new Mensagens(this, cn, est);
            m.Show();
        }

        private void estudantesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When new row selected, show it's Object data
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }
    }
}
