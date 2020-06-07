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
using BrightIdeasSoftware;

namespace Funcionarios
{
    public partial class Docentes : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0;
        private List<GrupoDisciplinar> gruposDisciplinares;


        // Constructor
        public Docentes(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.gruposDisciplinares = new List<GrupoDisciplinar>();
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
                Funcionario func = (Funcionario)rowObject;
                return func.salario.ToString().Split(',')[0];
            };
            this.tel.GroupKeyGetter = delegate (object rowObject) {
                // Group phones by the first two digits (phone company indicator)
                Funcionario func = (Funcionario)rowObject;
                if (func.telemovel.ToString().Length > 2)
                    return func.telemovel.ToString().Substring(0, 2);
                return "Outros";
            };
            this.email.GroupKeyGetter = delegate (object rowObject) {
                // Group emails by domain (text after @ symbol)
                Funcionario func = (Funcionario)rowObject;
                return func.email.Split('@')[1];
            };
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaAtributo.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void loadGruposDisciplinares()
        {
            // Execute SQL query
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.GrupoDisciplinar;", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GrupoDisciplinar g = new GrupoDisciplinar();
                g.num = Int32.Parse(reader["num"].ToString());
                g.nome = reader["nome"].ToString();
                panelFormFieldGrupoDisciplinar.Items.Add(g.nome);

                gruposDisciplinares.Add(g);
            }
            reader.Close();

        }

        private GrupoDisciplinar getGrupoDisciplinar(int num)
        {
            foreach (GrupoDisciplinar gd in gruposDisciplinares)
            {
                if (num == gd.num)
                    return gd;
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
            Docente f = (Docente)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldNMec.Text = f.nmec.ToString();
            panelFormFieldNome.Text = f.nome;
            panelFormFieldContacto.Text = f.telemovel.ToString();
            panelFormFieldEmail.Text = f.email;
            panelFormFieldSalario.Text = f.salario.ToString();
            panelFormFieldGrupoDisciplinar.Text = f.grupoDisciplinar.nome;
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
            panelFormFieldGrupoDisciplinar.SelectedIndex = 0;
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
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar o funcionário " + f.nmec.ToString() +"?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            MessageBox.Show("Funcionalidade em implementação..."); 
            //TODO
            // Hide panels
            panelForm.Visible = false;
            panelObject.Visible = false;
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
                    Docente func = (Docente)x;
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
                        case "Email":
                            toFilter = func.email;
                            break;
                        case "Grupo disciplinar":
                            toFilter = func.grupoDisciplinar.nome;
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

        // Event handlers
        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When form closed, show the previous one (main interface form)
            previous.Show();
        }


        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // Load grupos disciplinares
            loadGruposDisciplinares();

            // Execute SQL query
            //SqlCommand cmd = new SqlCommand("SELECT Pessoa.NMec, Pessoa.nome, Pessoa.telemovel, Funcionario.Salario, GrupoDisciplinar.nome AS grupoDisciplinarNome, GrupoDisciplinar.num AS grupoDisciplinarNum, CONCAT(email, '@', dominio) AS emailComposed FROM((( (GestaoEscola.Docente JOIN GestaoEscola.Funcionario ON Docente.NMec = Funcionario.PNMec) JOIN GestaoEscola.Pessoa ON Docente.NMec = Pessoa.NMec) JOIN GestaoEscola.EmailDominio ON Pessoa.emailDominio = EmailDominio.id) JOIN GestaoEscola.GrupoDisciplinar ON Docente.grupoDisciplinar = GrupoDisciplinar.num)", cn);
            SqlCommand cmd = new SqlCommand("SELECT Pessoa.NMec, Pessoa.nome, Pessoa.telemovel, Funcionario.Salario, Docente.grupoDisciplinar, CONCAT(email, '@', dominio) AS emailComposed FROM(( (GestaoEscola.Docente JOIN GestaoEscola.Funcionario ON Docente.NMec = Funcionario.PNMec) JOIN GestaoEscola.Pessoa ON Docente.NMec = Pessoa.NMec) JOIN GestaoEscola.EmailDominio ON Pessoa.emailDominio = EmailDominio.id) ", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Funcionario> docentes = new List<Funcionario>();
            while (reader.Read())
            {
                Docente f = new Docente();
                f.nmec = Int32.Parse(reader["NMec"].ToString());
                f.nome = reader["nome"].ToString();
                f.salario = Double.Parse(reader["salario"].ToString());
                f.telemovel = Int32.Parse(reader["telemovel"].ToString());
                f.email = reader["emailComposed"].ToString();
                f.grupoDisciplinar = getGrupoDisciplinar(Int32.Parse(reader["grupoDisciplinar"].ToString()));

                docentes.Add(f);
                counter++;
            }


            // ObjectListView
            // Add Objects to list view
            listObjects.SetObjects(docentes);

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

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em implementação...");
            //TODO (Distinguish new and edit operation)
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
