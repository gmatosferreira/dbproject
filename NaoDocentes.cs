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
using System.Diagnostics;

namespace Funcionarios
{
    public partial class NaoDocentes : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0;
        private List<Turno> turnos;

        // Constructor
        public NaoDocentes(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.turnos = new List<Turno>();
            InitializeComponent();
            // ObjectListView Column groups
            // http://objectlistview.sourceforge.net/python/groupListView.html
            this.nmec.GroupKeyGetter = delegate (object rowObject) {
                // When the same is returned by every object, all of them are put together in one group
                return "Número mecanográfico";
            };
            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome";
            };
            this.salario.GroupKeyGetter = delegate (object rowObject) {
                // Group salaries by the integer value of it
                NaoDocente func = (NaoDocente)rowObject;
                return func.salario.ToString().Split(',')[0];
            };
            this.tel.GroupKeyGetter = delegate (object rowObject) {
                // Group phones by the first two digits (phone company indicator)
                NaoDocente func = (NaoDocente)rowObject;
                if (func.telemovel.ToString().Length > 2)
                    return func.telemovel.ToString().Substring(0, 2);
                return "Outros";
            };
            this.email.GroupKeyGetter = delegate (object rowObject) {
                // Group emails by domain (text after @ symbol)
                NaoDocente func = (NaoDocente)rowObject;
                return func.email.Split('@')[1];
            };
            this.turno.GroupKeyGetter = delegate (object rowObject) {
                // Group emails by domain (text after @ symbol)
                NaoDocente func = (NaoDocente)rowObject;
                return "Das " + func.turno.horaInicio.ToString(@"hh", null) + " às " + func.turno.horaFim.ToString(@"hh", null);
            };
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaAtributo.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void loadTurnos()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Turno", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Turno t = new Turno();
                t.codigo = Int32.Parse(reader["codigo"].ToString());
                t.horaInicio = TimeSpan.Parse(reader["horaInicio"].ToString());
                t.horaFim= TimeSpan.Parse(reader["horaFim"].ToString());
                panelFormFieldTurno.Items.Add(t.str);
                turnos.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private Turno getTurno(int codigo)
        {
            foreach (Turno t in turnos)
            {
                if (codigo == t.codigo)
                    return t;
            }
            return null;
        }

        private Turno getTurno(String nome)
        {
            foreach (Turno t in turnos)
            {
                if (nome.Equals(t.str, StringComparison.InvariantCultureIgnoreCase))
                    return t;
            }
            return null;
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
            NaoDocente f = (NaoDocente)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = f.nome;
            panelObjectSubtitulo.Text = f.nmec.ToString();
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
            panelForm.Visible = false;

        }

        private void editObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NaoDocente f = (NaoDocente)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNMec.Text = f.nmec.ToString();
            panelFormFieldNome.Text = f.nome;
            panelFormFieldContacto.Text = f.telemovel.ToString();
            panelFormFieldEmail.Text = f.email;
            panelFormFieldSalario.Text = f.salario.ToString();
            panelFormFieldTurno.Text = f.turno.str;
            // Disable fields not changable
            panelFormFieldNMec.Enabled = false;
            // Set title and description
            panelFormTitulo.Text = "Editar funcionário " + f.nmec.ToString();
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
            panelFormFieldContacto.Text = "";
            panelFormFieldEmail.Text = "";
            panelFormFieldSalario.Text = "";
            panelFormFieldTurno.SelectedIndex = 0;
            // Enable fields that are not editable
            panelFormFieldNMec.Enabled = true;
            // Set title and description
            panelFormTitulo.Text = "Adicionar um novo funcionário";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar funcionário";
            // Deselect pre selected row
            listObjects.DeselectAll();
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
            panelObject.Visible = false;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NaoDocente f = (NaoDocente)listObjects.SelectedObjects[0];
            int itemIndex = listObjects.SelectedIndex;
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar o funcionário " + f.nmec.ToString() +"?", "Operação delicada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Delete tuple on db 
            String commandText = "DELETE FROM GestaoEscola.NaoDocente WHERE NMec = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = f.nmec;

            // Execute query 
            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                String errorMessage = "Ocorreu um erro, tente novamente!";
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    if (ex.Errors[i].Message.IndexOf("O funcionário não pode ser eliminado enquanto for supervisor", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
                        break;
                    }

                }
                MessageBox.Show(
                    errorMessage + "\r\n\r\n" + ex.ToString(),
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
                listObjects.Items.RemoveAt(itemIndex);
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
        }

        private void pesquisar()
        {
            // Get attribute and value fields text
            String atr = pesquisaAtributo.Text;
            String val = pesquisaTexto.Text;
            if (atr=="" || val=="")
            {
                // If one of them is empty, don't filter
                this.listObjects.ModelFilter = null;
            } else
            {
                // Define filtering
                this.listObjects.ModelFilter = new ModelFilter(delegate (object x) {
                    NaoDocente func = (NaoDocente)x;
                    String toFilter = "";
                    switch(atr)
                    {
                        case "Número mecanográfico":
                            toFilter = func.nmec.ToString();
                            break;
                        case "Salário":
                            toFilter = func.salario.ToString();
                            break;
                        case "Nome":
                            toFilter = func.nome;
                            break;
                        case "Contacto":
                            toFilter = func.telemovel.ToString();
                            break;
                        case "Turno":
                            toFilter = func.turno.str;
                            break;
                    }
                    if (toFilter.ToLower().Contains(val.ToLower()))
                        return true;
                    return false;
                });
            }
            updateStats();
            // Hide data panel (both edit and data)
            panelObject.Visible = false;
            panelForm.Visible = false;
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
            if (!RegexExpressions.isDouble(panelFormFieldSalario.Text))
            {
                error = true;
                sb.Append(" Salário");
            }
            if (!RegexExpressions.isPhoneNumber(panelFormFieldContacto.Text))
            {
                error = true;
                sb.Append(" Telemovel");
            }
            if (!RegexExpressions.isEmail(panelFormFieldEmail.Text))
            {
                error = true;
                sb.Append(" Email");
            }
            // Check others
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 65)
            {
                error = true;
                sb.Append(" Nome (max 65 caracteres)");
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

        private void submitForm(NaoDocente ndocente)
        {
            bool edit = (ndocente != null);

            // Get form data 
            int nmec = Int32.Parse(panelFormFieldNMec.Text);
            String nome = panelFormFieldNome.Text;
            Double salario = Double.Parse(panelFormFieldSalario.Text);
            int telemovel = Int32.Parse(panelFormFieldContacto.Text);
            String emailPrefixo = panelFormFieldEmail.Text.Split('@')[0];
            String emailDominio = panelFormFieldEmail.Text.Split('@')[1];
            Turno turno = getTurno(panelFormFieldTurno.Text);

            // Create command 
            String commandText = "pr_NaoDocentes";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@NMec", SqlDbType.Int);
            command.Parameters["@NMec"].Value = nmec;
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters["@Nome"].Value = nome;
            command.Parameters.Add("@Telemovel", SqlDbType.Int);
            command.Parameters["@Telemovel"].Value = telemovel;
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters["@Email"].Value = emailPrefixo;
            command.Parameters.Add("@EmailDominio", SqlDbType.VarChar);
            command.Parameters["@EmailDominio"].Value = emailDominio;
            command.Parameters.Add("@Salario", SqlDbType.Money);
            command.Parameters["@Salario"].Value = salario;
            command.Parameters.Add("@Turno", SqlDbType.Int);
            command.Parameters["@Turno"].Value = turno.codigo;
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
                String errorMessage = "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!";
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    if (ex.Errors[i].Message.IndexOf("Já existe uma pessoa com o email", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
                        break;
                    }
                    if (ex.Errors[i].Message.IndexOf("Já existe uma pessoa com o número de telemóvel fornecido", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
                        break;
                    }

                }
                MessageBox.Show(
                    errorMessage + "\r\n\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If query is successful 
            if (returnValue == 1)
            {
                // If add operation, construct object (was null)
                if (!edit)
                    ndocente = new NaoDocente();
                ndocente.nmec = nmec;
                ndocente.nome = nome;
                ndocente.email = emailPrefixo + "@" + emailDominio;
                ndocente.telemovel = telemovel;
                ndocente.salario = salario;
                ndocente.turno = turno;
                if (!edit)
                    listObjects.AddObject(ndocente);
                // SHow feedback to user 
                String successMessage = "O não docente foi adicionado com sucesso!";
                if (edit)
                    successMessage = "O não docente foi editado com sucesso";
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
                String messageError = "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!";
                if (returnValue == -2)
                    messageError = "Já existe uma pessoa na base de dados com esse número mecanográfico!";
                else if (returnValue == -3 || returnValue == -4)
                    messageError = "Ocorreu um erro interno na base de dados! Tente novamente.";
                MessageBox.Show(
                    messageError,
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Event handlers
        private void FormClosed_Handler(object sender, FormClosedEventArgs e)
        {
            // When form closed, show the previous one (main interface form)
            previous.Show();
        }


        private void FormLoad_Handler(object sender, EventArgs e)
        {
            // Get turnos
            loadTurnos();

            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_NaoDocentes", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<NaoDocente> tuplos = new List<NaoDocente>();
            while (reader.Read())
            {
                NaoDocente d = new NaoDocente();
                d.nmec = Int32.Parse(reader["NMec"].ToString());
                d.nome = reader["nome"].ToString();
                d.salario = Double.Parse(reader["salario"].ToString());
                d.telemovel = Int32.Parse(reader["telemovel"].ToString());
                d.email = reader["emailComposed"].ToString();
                d.turno = getTurno(Int32.Parse(reader["turno"].ToString()));
                tuplos.Add(d);
                counter++;
            }

            // Close reader
            reader.Close();

            // ObjectListView
            // Add Objects to list view
            listObjects.SetObjects(tuplos);

            // Update stats
            updateStats();
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

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            if (formValid())
            {
                // Edit 
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((NaoDocente)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitForm(null);
                }
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

        private void panelObjectGerirFuncoes_Click(object sender, EventArgs e)
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NaoDocente nd = (NaoDocente)listObjects.SelectedObjects[0];
            //this.Hide();
            NaoDocenteTurnos f = new NaoDocenteTurnos(cn, nd, this);
            f.ShowDialog();
        }

        private void panelObjectVerHorario_Click(object sender, EventArgs e)
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NaoDocente nd = (NaoDocente)listObjects.SelectedObjects[0];
            //this.Hide();
            NaoDocenteHorario f = new NaoDocenteHorario(cn, nd, this);
            f.ShowDialog();
        }

        private void funcionariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When new row selected, show it's Object data
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }
    }
}
