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
    public partial class Funcionarios : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0;

        // Constructor
        public Funcionarios(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            InitializeComponent();
            // ObjectListView Column groups
            this.nmec.GroupKeyGetter = delegate (object rowObject) {
                return "Número mecanográfico";
            };
            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome";
            };
            this.salario.GroupKeyGetter = delegate (object rowObject) {
                Funcionario func = (Funcionario)rowObject;
                return func.salario.ToString().Split(',')[0];
            };
            this.tel.GroupKeyGetter = delegate (object rowObject) {
                Funcionario func = (Funcionario)rowObject;
                if (func.telemovel.ToString().Length > 2)
                    return func.telemovel.ToString().Substring(0, 2);
                return "Outros";
            };
            this.email.GroupKeyGetter = delegate (object rowObject) {
                Funcionario func = (Funcionario)rowObject;
                return func.email.Split('@')[1];
            };
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true;
            this.listObjects.SelectedIndex = 0;
        }

        //  Methods
        private void updateStats()
        {
            janelaSubtitulo.Text = "A mostrar " + counter.ToString() + " registos";
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Funcionario f = (Funcionario)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = f.nome;
            panelObjectSubtitulo.Text = f.nmec.ToString();
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;

        }

        private void editObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Funcionario f = (Funcionario)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNMec.Text = f.nmec.ToString();
            panelFormFieldNome.Text = f.nome;
            panelFormFieldContacto.Text = f.telemovel.ToString();
            panelFormFieldEmail.Text = f.email;
            panelFormFieldSalario.Text = f.salario.ToString();
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
            // Enable fields that are not editable
            panelFormFieldNMec.Enabled = true;
            // Set title and description
            panelFormTitulo.Text = "Adicionar um novo funcionário";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar funcionário";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Funcionario f = (Funcionario)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Esta operação é irreversível!", "Tem a certeza que quer eliminar o funcionário " + f.nmec.ToString() +"?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            MessageBox.Show("Funcionalidade em implementação..."); 
            //TODO
            // Hide panels
            panelForm.Visible = false;
            panelObject.Visible = false;
        }

        // Event handlers
        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous.Show();
        }


        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // Executar query SQL
            SqlCommand cmd = new SqlCommand("SELECT PNMec, nome, salario, telemovel, CONCAT(email,'@',dominio) AS emailComposed FROM( (GestaoEscola.Funcionario JOIN GestaoEscola.Pessoa ON Funcionario.PNMec=Pessoa.NMec) JOIN GestaoEscola.EmailDominio ON Pessoa.emailDominio=EmailDominio.id)", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Funcionario> funcionarios = new List<Funcionario>();
            while (reader.Read())
            {
                Funcionario f = new Funcionario();
                f.nmec = Int32.Parse(reader["PNMec"].ToString());
                f.nome = reader["nome"].ToString();
                f.salario = Double.Parse(reader["salario"].ToString());
                f.telemovel = Int32.Parse(reader["telemovel"].ToString());
                f.email = reader["emailComposed"].ToString();
                funcionarios.Add(f);
                counter++;
            }


            // ObjectListView
            listObjects.SetObjects(funcionarios);

            // Update stats
            updateStats();

            // Close reader
            reader.Close();
        }

        private void panelObjectEsconder_Click(object sender, EventArgs e)
        {
            panelObject.Visible = false;
            panelForm.Visible = false;
        }

        private void panelObjectEditar_Click(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                editObject();
            }
        }

        private void buttonAdicionarObject_Click(object sender, EventArgs e)
        {
            addObject();
        }

        private void panelFormHide_Click(object sender, EventArgs e)
        {
            panelForm.Visible = false;
        }

        private void panelObjectEliminar_Click(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                deleteObject();
            }
        }

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em implementação...");
            //TODO
        }

        private void funcionariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }
    }
}
