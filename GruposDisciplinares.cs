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
        private int current = 0, counter = 0;

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
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            GrupoDisciplinar f = (GrupoDisciplinar)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar o grupo '"+f.nome+"'?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            MessageBox.Show("Funcionalidade em implementação..."); 
            //TODO
            // Hide panels
            panelForm.Visible = false;
            panelObject.Visible = false;
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
            MessageBox.Show("Funcionalidade em implementação...");
            //TODO (Distinguish new and edit operation)
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
