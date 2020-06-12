using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Turmas : Form
    {
        private SqlConnection cn;
        private Form previous;
        private bool edit = false;
        private int current = 0, counter = 0; 
        List<String> docentesNaoDT;

        public Turmas(SqlConnection cn, Form prev)
        {
            this.cn = cn;
            this.previous = prev;
            InitializeComponent();
            this.docentesNaoDT = new List<String>();

            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                // When the same is returned by every object, all of them are put together in one group
                return "Nome da Turma";
            };
            this.nomeDT.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome Diretor de Turma";
            };

            this.nivel.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nivel";
            };

            this.anoLetivo.GroupKeyGetter = delegate (object rowObject)
            {
                return "Ano Letivo";
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
            Turma t = (Turma)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = t.nome;
            panelObjectSubTitulo.Text = t.nomeDT;
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
        }

        private void editDT(object sender, EventArgs e)
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Turma t = (Turma)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNome.Text = t.nome;
            panelFormFieldNivel.Text = t.nivel.ToString();
            dataInicio.Value = t.dataInicio;
            dataFimForm.Value = t.dataF;


            // Disable fields not changable
            panelFormFieldNome.Enabled = false;
            panelFormFieldNivel.Enabled = false;
            dataInicio.Enabled = false;
            dataFimForm.Enabled = false;

            // Set title and description
            panelFormTitulo.Text = "Editar turma " + t.nome;
            panelFormDescricao.Text = "Altere os dados e submita o formulário";
            panelFormButton.Text = "Submeter";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void Turmas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previous.Show();
        }

        private void addObject(object sender, EventArgs e)
        {
            // Clear all fields
            panelFormFieldNome.Text = "";
            panelFormFieldNivel.Text = "";
            dataInicio.Refresh();
            dataFimForm.Refresh();
            comboBoxDT.SelectedIndex = 0;

            // Enable fields that are not editable
            panelFormFieldNome.Enabled = true;
            panelFormFieldNivel.Enabled = true;
            dataInicio.Enabled = true;
            dataFimForm.Enabled = true;

            // Set title and description
            panelFormTitulo.Text = "Adicionar uma nova turma";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar turma";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void panelObjectHide_Click(object sender, EventArgs e)
        {
            // Hide data panel (both edit and data)
            panelObject.Visible = false;
            panelForm.Visible = false;
        }

        private void panelFormHide_Click(object sender, EventArgs e)
        {
            // Hide pannel
            panelForm.Visible = false;
        }

        private void Turmas_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Turma.nome, anoLetivo, nivel,dataInicio,dataFim, diretorDeTurma, Pessoa.nome AS nomeDT FROM GestaoEscola.Turma JOIN GestaoEscola.Pessoa ON diretorDeTurma = NMec LEFT JOIN  GestaoEscola.AnoLetivo ON anoLetivo=codigo", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Turma> turmas = new List<Turma>();
            while (reader.Read())
            {
                Turma t = new Turma();
                t.nivel = int.Parse(reader["nivel"].ToString());
                t.nome = reader["nome"].ToString();
                t.nomeDT = reader["nomeDT"].ToString();
                t.nMecDT = int.Parse(reader["diretorDeTurma"].ToString());
                t.anoID = Int32.Parse(reader["anoLetivo"].ToString());

                //data Inicio
                t.dataInicio = DateTime.Parse(reader["dataInicio"].ToString());

                //data Fim
                t.dataF = DateTime.Parse(reader["dataFim"].ToString());

                turmas.Add(t);
                counter++;
            }

            // ObjectListView
            // Add Objects to list view
            listObjects.SetObjects(turmas);

            // Update stats
            updateStats();

            // Close reader
            reader.Close();

            inicializarComboBox();
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When new row selected, show it's Object data
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }
        private void panelFormButton_Click(object sender, EventArgs e) {
            if (formValid())
            {
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((Turma)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitForm(null);
                }
            }
        }

        private Boolean formValid()
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb = new StringBuilder();
            if (!RegexExpressions.isInteger(panelFormFieldNivel.Text))
            {
                error = true;
                sb.Append(" Nivel");
            }
           
            // Check others
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 5)
            {
                error = true;
                sb.Append(" Nome de turma (max 5 caracteres)");
            }
            // Give user feedback
            if (dataInicio.Value > dataFimForm.Value) {
                error = true;
                sb.Append(" A data de inicio de ano letivo deve ser inferior à data de fim");
            }
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


        private void submitForm(Turma turma)
        {
            bool edit = (turma != null);
            String cmdTxt = "";
            String diretorInfo = comboBoxDT.SelectedItem.ToString();
            // dados
            int nivel = int.Parse(panelFormFieldNivel.Text);
            String nomeT = panelFormFieldNome.Text;
            DateTime inicio = dataInicio.Value;
            DateTime fim = dataFimForm.Value;
            int nMecDT = int.Parse(diretorInfo.Split('-')[0]);
            String nomeDT = diretorInfo.Split('-')[1];

            // Create command 
            String commandText = "GestaoEscola.TurmaSP";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;

            // Add vars 
            command.Parameters.Add("@nivel", SqlDbType.Int);
            command.Parameters["@nivel"].Value = nivel;
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters["@nome"].Value = nomeT;
            command.Parameters.Add("@nmecDT", SqlDbType.Int);
            command.Parameters["@nmecDT"].Value = nMecDT;
            command.Parameters.Add("@dataInicio", SqlDbType.Date);
            command.Parameters["@dataInicio"].Value = inicio;
            command.Parameters.Add("@dataFim", SqlDbType.Date);
            command.Parameters["@dataFim"].Value = fim;
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
            if (rowsAffected == 3 && returnValue == 1) {
                // If add operation, construct object (was null)
                if (!edit)
                    turma = new Turma();
                turma.dataF = fim;
                turma.dataInicio = inicio;
                turma.nome = nomeT;
                turma.nMecDT = nMecDT;
                turma.nomeDT = nomeDT;
                turma.nivel = nivel;

                if (!edit)
                    listObjects.AddObject(turma);
                // SHow feedback to user 
                String successMessage = "A turma foi adicionada com sucesso!";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update objects displayed on interface 
                listObjects.BuildList(true);
                // Update stats
                inicializarComboBox();
                updateStats();
                // Hide panels 
                panelForm.Visible = false;
                panelObject.Visible = false;
            }

            // If query is successful for edit
            if (rowsAffected == 2 && returnValue == 1)
            {
                String successMessage = "A turma foi editada com sucesso";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update objects displayed on interface 
                listObjects.BuildList(true);
                // Update stats
                inicializarComboBox();
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

        private void estudantes_Click(object sender, EventArgs e)
        {
            if (listObjects.Items.Count == 0 | current < 0)
                return;
                Turma t2 = (Turma)listObjects.SelectedObjects[0];
                EstudantesTurma listaEstudantes = new EstudantesTurma(cn,this,t2.nivel, t2.nome,t2.anoID);
                listaEstudantes.ShowDialog();
        }

        private void pesquisar(object sender, EventArgs e)
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
                    Turma t = (Turma)x;
                    String toFilter = "";
                    switch (atr)
                    {
                        case "Nome de Turma":
                            toFilter = t.nome;
                            break;
                        case "Nome Diretor de Turma":
                            toFilter = t.nomeDT;
                            break;
                        case "Nivel":
                            toFilter = t.nivel.ToString();
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

        private void inicializarComboBox()
        {
            comboBoxDT.Items.Clear();
            SqlCommand cmd = new SqlCommand("GestaoEscola.DiretoresTurmaSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int c = 0;
            SqlDataReader r = cmd.ExecuteReader();            
            while (r.Read())
            {
                // lista de docentes nao diretores de turma e nmec
                String s = r["NMec"].ToString() + "-" + r["nome"].ToString();
                comboBoxDT.Items.Insert(c, s);
                c++;
            }
            r.Close();
        }
    }
}
