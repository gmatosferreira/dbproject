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
        private int current = 0, counter = 0;
        public Turmas(SqlConnection cn, Form prev)
        {
            this.cn = cn;
            this.previous = prev;
            InitializeComponent();
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
            panelFormFieldNomeDT.Text = t.nomeDT;
            panelFormFieldNivel.Text = t.nivel.ToString();
            panelFormFieldAno.Text = t.anoLetivo.ToString();

            // Disable fields not changable
            panelFormFieldNome.Enabled = false;
            panelFormFieldNivel.Enabled = false;
            panelFormFieldAno.Enabled = false;

            // Set title and description
            panelFormTitulo.Text = "Editar turma " + nome;
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
            panelFormFieldNomeDT.Text = "";
            panelFormFieldNivel.Text = "";
            panelFormFieldAno.Text = "";

            // Enable fields that are not editable
            panelFormFieldNome.Enabled = true;
            panelFormFieldNivel.Enabled = true;
            panelFormFieldAno.Enabled = true;

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
            SqlCommand cmd = new SqlCommand("SELECT nome, nivel, anoLetivo, diretorDeTurma FROM GestaoEscola.Turma", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Turma> turmas = new List<Turma>();
            while (reader.Read())
            {
                Turma t = new Turma();
                t.nivel = Int32.Parse(reader["nivel"].ToString());
                t.nome = reader["nome"].ToString();
                t.nomeDT = reader["diretorDeTurma"].ToString();
                t.anoLetivo = Int32.Parse(reader["anoLetivo"].ToString());
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
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When new row selected, show it's Object data
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
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
    }
    // TODO: AJUDA, VER NOME DT E ANO LETIVO... etc
}
