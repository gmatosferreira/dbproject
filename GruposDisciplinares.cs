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
    public partial class GruposDisciplinares : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0, lastId = 0;

        // Constructor
        public GruposDisciplinares(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            InitializeComponent();
            // ObjectListView Column groups
            // http://objectlistview.sourceforge.net/python/groupListView.html
            this.nome.GroupKeyGetter = delegate (object rowObject) {
                return "Nome";
            };
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " grupos";
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            GrupoDisciplinar f = (GrupoDisciplinar)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = "Grupo";
            panelObjectSubtitulo.Text = f.nome;
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
            GrupoDisciplinar f = (GrupoDisciplinar)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNome.Text = f.nome;
            // Set title and description
            panelFormTitulo.Text = "Editar grupo disciplinar";
            panelFormDescricao.Text = "Altere os dados e submita o formulário";
            panelFormButton.Text = "Submeter";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void addObject()
        {
            // Clear all fields
            panelFormFieldNome.Text = "";
            // Set title and description
            panelFormTitulo.Text = "Adicionar um novo grupo disciplinar";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar grupo";
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
            GrupoDisciplinar f = (GrupoDisciplinar)listObjects.SelectedObjects[0];
            int itemIndex = listObjects.SelectedIndex;
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar o grupo '"+f.nome+"'?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Create command 
            String commandText = "pr_GruposDisciplinaresDELETE";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters["@Codigo"].Value = f.num;
            command.Parameters.Add("@Feedback", SqlDbType.VarChar, 4000).Direction = ParameterDirection.Output;
            // Return value stuff
            command.Parameters.Add("@ReturnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            // Execute query 
            int rowsAffected = 0;
            int returnValue;
            String returnMessage = "";
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                returnValue = (int)command.Parameters["@ReturnVal"].Value;
                returnMessage = (String)command.Parameters["@Feedback"].Value;
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show(
                    "Ocorreu um erro, tente novamente!\r\n\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If successful query 
            if (rowsAffected == 1 && returnValue == 1)
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
                String errorMessage = "Ocorreu um erro, tente novamente!";
                if (returnMessage.Contains("conflicted with the REFERENCE constraint \"FK"))
                    errorMessage = "Este grupo disciplinar não pode ser eliminado enquanto estiver atribuído a um docente!";
                MessageBox.Show(
                    errorMessage + "\r\n\r\n" + returnMessage,
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Boolean formValid()
        {
            // Validate nome and give user feedback
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 20)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente o nome (max 20 caracteres)",
                   "Erro na submissão!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return false;
            }
            return true;
        }

        private void submitForm(GrupoDisciplinar gd)
        {
            /* 
             If submition for edit t!=null 
             If new submition t==null 
             */
            bool edit = (gd != null);
            // Get form data 
            String nome = panelFormFieldNome.Text.Trim();
            // Create command 
            String commandText = "INSERT INTO GestaoEscola.GrupoDisciplinar VALUES (@ID, @Nome)";
            if (edit)
                commandText = "UPDATE GestaoEscola.GrupoDisciplinar SET nome = @Nome WHERE num = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ID", SqlDbType.Int);
            if (edit)
                command.Parameters["@ID"].Value = gd.num;
            else
                command.Parameters["@ID"].Value = lastId + 1;
            command.Parameters.Add("@Nome", SqlDbType.VarChar, 20);
            command.Parameters["@Nome"].Value = nome;
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
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!\r\n\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If query is successful 
            if (rowsAffected == 1)
            {
                // If add operation 
                if (!edit)
                {
                    // Update lastId  
                    lastId++;
                    // Add tuple to interface list 
                    gd = new GrupoDisciplinar();
                    gd.num= lastId;
                    gd.nome = nome;
                    listObjects.AddObject(gd);
                }
                else
                {
                    // Get object on interface list and change attributes 
                    gd.nome = nome;
                }
                // SHow feedback to user 
                String successMessage = "O grupo disciplinar foi adicionado com sucesso!";
                if (edit)
                    successMessage = "O grupo disciplinar foi editado com sucesso";
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

        // Event handlers
        private void FormClosed_Handler(object sender, FormClosedEventArgs e)
        {
            // When form closed, show the previous one (main interface form)
            previous.Show();
        }


        private void FormLoad_Handler(object sender, EventArgs e)
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.GrupoDisciplinar", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<GrupoDisciplinar> tuplos = new List<GrupoDisciplinar>();
            while (reader.Read())
            {
                GrupoDisciplinar t = new GrupoDisciplinar();
                t.num = Int32.Parse(reader["num"].ToString());
                t.nome = reader["nome"].ToString();
                if (lastId < t.num)
                    lastId = t.num;
                tuplos.Add(t);
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
            // Add object button
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

        private void addDiscButton_Click(object sender, EventArgs e)
        {
            if(listObjects.SelectedIndex >= 0)
                panelDisc.Visible = true;
        }

        private void criarDisciplina_Click(object sender, EventArgs e)
        {
            if (disciplinaNome.Text.Length <= 30) {
                String commandText = "INSERT INTO GestaoEscola.Disciplina VALUES(1, @nome, @grupo)";
                SqlCommand command = new SqlCommand(commandText, cn);
                // Add vars 
                command.Parameters.Add("@nome", SqlDbType.VarChar);
                command.Parameters["@nome"].Value = disciplinaNome.Text;
                command.Parameters.Add("@grupo", SqlDbType.Int);
                GrupoDisciplinar g = (GrupoDisciplinar)listObjects.SelectedObject;
                command.Parameters["@grupo"].Value = g.num;

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
                if (rowsAffected == 2)
                {
                    MessageBox.Show("Disciplina adicionada ao grupo disciplinar com sucesso!");
                }
                else
                {
                    MessageBox.Show(
                  "Essa disciplina já existe!",
                  "Erro na submissão!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Ocorreu um erro, o tamanho máximo do nome da disciplina é de 30 caracteres!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            panelDisc.Visible = false;
        }

        private void hideDisciplina_Click(object sender, EventArgs e)
        {
            panelDisc.Visible = false;
        }

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            // Execute operation 
            if (formValid())
            {
                // Edit 
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((GrupoDisciplinar)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitForm(null);
                }
            }
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
