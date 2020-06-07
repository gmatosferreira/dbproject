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
    public partial class NaoDocenteTurnos : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private NaoDocente nd;
        private int current = 0, counter = 0;
        private List<Bloco> blocos;
        private List<NDFuncao> funcoes;

        // Constructor
        public NaoDocenteTurnos(SqlConnection cn, NaoDocente nd, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.nd = nd;
            this.blocos = new List<Bloco>();
            this.funcoes = new List<NDFuncao>();
            InitializeComponent();
            // ObjectListView Column groups
            // http://objectlistview.sourceforge.net/python/groupListView.html
            /*this.turno.GroupKeyGetter = delegate (object rowObject) {
                // Group emails by domain (text after @ symbol)
                NDTrabalhaBloco func = (NDTrabalhaBloco)rowObject;
                return "Das " + func.turno.horaInicio.ToString(@"hh", null) + " às " + func.turno.horaFim.ToString(@"hh", null);
            };*/
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void loadBlocos()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Bloco", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bloco t = new Bloco();
                t.coordenadas = reader["coordenadas"].ToString();
                t.nome = reader["nome"].ToString();
                panelFormFieldBloco.Items.Add(t.nome);
                blocos.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private Bloco getBloco(String coord)
        {
            foreach (Bloco b in blocos)
            {
                if (coord.Equals(b.coordenadas, StringComparison.InvariantCultureIgnoreCase))
                    return b;
            }
            return null;
        }

        private void loadFuncoes()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_Funcao", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NDFuncao t = new NDFuncao();
                t.codigo= Int32.Parse(reader["codigo"].ToString());
                t.nome = reader["nome"].ToString();
                panelFormFieldFuncao.Items.Add(t.nome);
                funcoes.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private NDFuncao getFuncao(int codigo)
        {
            foreach (NDFuncao f in funcoes)
            {
                if (codigo==f.codigo)
                    return f;
            }
            return null;
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " registos do funcionário "+nd.nmec.ToString() + "\r\nATENÇÃO! Todas as funções devem ser atribuídas dentro do turno do funcionário, das "+nd.turno.str;
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDTrabalhaBloco f = (NDTrabalhaBloco)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = f.turno.str;
            panelObjectSubtitulo.Text = f.bloco.nome + ", como " + f.funcao.nome;
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;

        }

        private void editObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDTrabalhaBloco f = (NDTrabalhaBloco)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldBloco.Text = f.bloco.nome;
            panelFormFieldFuncao.Text = f.funcao.nome;
            panelFormFieldHoraInicio.Text = f.turno.horaInicio.ToString();
            panelFormFieldHoraFim.Text = f.turno.horaFim.ToString();
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
            panelFormFieldBloco.SelectedIndex = 0;
            panelFormFieldFuncao.SelectedIndex = 0;
            panelFormFieldHoraInicio.Text = "00:00:00";
            panelFormFieldHoraFim.Text = "00:00:00";
            // Set title and description
            panelFormTitulo.Text = "Adicionar uma nova função";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar função";
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDFuncao f = (NDFuncao)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Esta operação é irreversível!", "Tem a certeza que quer eliminar esta função?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
            // Get turnos
            loadBlocos();
            loadFuncoes();

            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_trabalha_Bloco WHERE NMec="+nd.nmec.ToString(), cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<NDTrabalhaBloco> tuplos = new List<NDTrabalhaBloco>();
            while (reader.Read())
            {
                NDTrabalhaBloco d = new NDTrabalhaBloco();
                d.nd = nd;
                d.funcao = getFuncao(Int32.Parse(reader["codFuncao"].ToString()));
                d.bloco = getBloco(reader["Bcoordenadas"].ToString());
                Turno t = new Turno();
                t.horaInicio = TimeSpan.Parse(reader["horaInicio"].ToString());
                t.horaFim = TimeSpan.Parse(reader["horaFim"].ToString());
                d.turno = t;
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
            // Validate if function ship is inside Nao Docente main ship
            Turno novoTurno = new Turno();
            novoTurno.horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text);
            novoTurno.horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            if (!Turno.isInside(novoTurno, nd.turno))
                MessageBox.Show(
                    "O horário da função deve estar dentro do turno do funcionário!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            //TODO (Distinguish new and edit operation)
            MessageBox.Show("Funcionalidade em implementação...");
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
