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
    public partial class NaoDocentesFuncoes : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0, lastId = 0;

        // Constructor
        public NaoDocentesFuncoes(SqlConnection cn, Form f)
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
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " funções";
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDFuncao f = (NDFuncao)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = "Função";
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
            NDFuncao f = (NDFuncao)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNome.Text = f.nome;
            // Set title and description
            panelFormTitulo.Text = "Editar função";
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
            panelFormTitulo.Text = "Adicionar uma nova função";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar função";
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
            NDFuncao f = (NDFuncao)listObjects.SelectedObjects[0];
            int itemIndex = listObjects.SelectedIndex;
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar esta a função '"+f.nome+"'?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Create command 
            String commandText = "pr_NDFuncaoDELETE";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters["@Codigo"].Value = f.codigo;
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
                    "O tuplo foi eliminado com sucess da base de dados!",
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
                    errorMessage = "Esta função não pode ser eliminada enquanto estiver atribuído a um funcionário!";
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
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 15)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente o nome (max 15 caracteres)",
                   "Erro na submissão!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return false;
            }
            return true;
        }

        private void submitForm(NDFuncao funcao)
        {
            /* 
             If submition for edit t!=null 
             If new submition t==null 
             */
            bool edit = (funcao != null);
            // Get form data 
            String nome = panelFormFieldNome.Text;
            // Create command 
            String commandText = "INSERT INTO GestaoEscola.ND_Funcao VALUES (@ID, @Nome)";
            if (edit)
                commandText = "UPDATE GestaoEscola.ND_Funcao SET nome = @Nome WHERE codigo = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ID", SqlDbType.Int);
            if (edit)
                command.Parameters["@ID"].Value = lastId;
            else
                command.Parameters["@ID"].Value = lastId + 1;
            command.Parameters.Add("@Nome", SqlDbType.VarChar, 15);
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
                    funcao = new NDFuncao();
                    funcao.codigo = lastId;
                    funcao.nome = nome;
                    listObjects.AddObject(funcao);
                }
                else
                {
                    // Get object on interface list and change attributes 
                    funcao.nome = nome;
                }
                // SHow feedback to user 
                String successMessage = "A função foi adicionada com sucesso!";
                if (edit)
                    successMessage = "A função foi editada com sucesso";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_Funcao", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<NDFuncao> tuplos = new List<NDFuncao>();
            while (reader.Read())
            {
                NDFuncao t = new NDFuncao();
                t.codigo = Int32.Parse(reader["codigo"].ToString());
                t.nome = reader["nome"].ToString();
                if (t.codigo > lastId)
                    lastId = t.codigo;
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
            // Execute operation 
            if (formValid())
            {
                // Edit 
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((NDFuncao)listObjects.SelectedObjects[0]);
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
