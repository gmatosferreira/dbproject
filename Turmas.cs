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
            //String.Format("{0:2000}", t.anoLetivo.ToString());
            // TODOOO                                             !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1111
            //dataInicio.Value = 
            //dataFim.Value = 


            // Disable fields not changable
            panelFormFieldNome.Enabled = false;
            panelFormFieldNivel.Enabled = false;
            dataInicio.Enabled = false;
            dataFim.Enabled = false;

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
            dataFim.Refresh();
            comboBoxDT.SelectedIndex = 0;


            // Enable fields that are not editable
            panelFormFieldNome.Enabled = true;
            panelFormFieldNivel.Enabled = true;
            dataInicio.Enabled = true;
            dataFim.Enabled = true;

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
            SqlCommand cmd = new SqlCommand("SELECT Turma.nome, nivel, anoLetivo, diretorDeTurma, Pessoa.nome AS nomeDT FROM GestaoEscola.Turma JOIN GestaoEscola.Pessoa ON diretorDeTurma = NMec", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Turma> turmas = new List<Turma>();
            while (reader.Read())
            {
                Turma t = new Turma();
                t.nivel = Int32.Parse(reader["nivel"].ToString());
                t.nome = reader["nome"].ToString();
                t.nomeDT = reader["nomeDT"].ToString();
                t.nMecDT = int.Parse(reader["diretorDeTurma"].ToString());
                t.anoLetivo = int.Parse(String.Format("{0:2000}", reader["anoLetivo"]));
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
            if (listObjects.SelectedIndex >= 0)
            {
                submitForm((Turma)listObjects.SelectedObjects[0]);
            }
            // Add new  
            else {
                submitForm(null);
            }
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
            DateTime fim = dataFim.Value;

            int nMecDT = int.Parse(diretorInfo.Split('-')[0]);
            String nomeDT = diretorInfo.Split('-')[1];
            if (edit) //editar
                cmdTxt = "UPDATE GestaoEscola.Turma SET diretorDeTurma=@nMecDT WHERE nivel=@nivel AND nome=@nomeT AND anoLetivo=@ano";
            else
                cmdTxt = "INSERT INTO GestaoEscola.Turma VALUES (@nivel, @nomeT,@nMecDT, @ano);";

            SqlCommand command = new SqlCommand(cmdTxt, cn);
            int rowsAffected = 0;
            try
            {
                command.Parameters.AddWithValue("@nivel", nivel);
                command.Parameters.AddWithValue("@nomeT", nomeT);
                //command.Parameters.AddWithValue("@ano", anoLet);

                if (comboBoxDT.SelectedIndex >= 0)
                {
                    command.Parameters.AddWithValue("@nMecDT", nMecDT);
                }
                rowsAffected = command.ExecuteNonQuery();
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
            if (rowsAffected >= 1)
            {
                // If add operation 
                if (!edit)
                {
                    // Add tuple to interface list 
                    Turma t = new Turma();
                    t.nivel = nivel;
                    //t.anoLetivo = int.Parse(String.Format("{0:2000}", anoLet.ToString()));
                    t.nMecDT = nMecDT;
                    t.nomeDT = nomeDT;
                    t.nome = nomeT;
                    listObjects.AddObject(t);
                }
                else
                {
                    // Get object on interface list and change attributes 
                    turma.nomeDT = nomeDT;
                    turma.nMecDT = nMecDT;
                }
                // SHow feedback to user 
                String successMessage = "A turma foi adicionada com sucesso!";
                if (edit)
                    successMessage = "A turna foi editada com sucesso";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                updateStats();
                inicializarComboBox();
                comboBoxDT.Refresh();
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
            // Hide panels 
            panelForm.Visible = false;
            panelObject.Visible = false;
        }

        private void estudantes_Click(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0) {
                Turma t2 = (Turma)listObjects.SelectedObjects[0];
                EstudantesTurma listaEstudantes = new EstudantesTurma(this,t2.nivel, t2.nome,t2.anoLetivo);
            }
            //abrir o form dos estudantes            
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
                        case "Ano Letivo":
                            toFilter = t.anoLetivo.ToString();
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
        }
    }
}
