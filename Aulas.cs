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
    public partial class Aulas : Form
    {
        private SqlConnection cn;
        private int current = 0, counter = 0;
        private Form prev;
        private Docente d;
        private List<Turma> turmas;
        private List<Aula> aulas;

        public Aulas(SqlConnection cn, Form prev, Docente d)
        {
            InitializeComponent();
            this.prev = prev;
            this.d = d;
            this.turmas = new List<Turma>();
            this.aulas = new List<Aula>();
            this.cn = cn;

            this.sala.GroupKeyGetter = delegate (object rowObject) {
                // When the same is returned by every object, all of them are put together in one group
                return "Sala";
            };
            this.horario.GroupKeyGetter = delegate (object rowObject)
            {
                return "Horario";
            };

            this.turma.GroupKeyGetter = delegate (object rowObject)
            {
                return "Turma";
            };

            this.disciplina.GroupKeyGetter = delegate (object rowObject)
            {
                return "Disciplina";
            };

            this.diaSemana.GroupKeyGetter = delegate (object rowObject)
            {
                return "Dia da Semana";
            };
            
            this.anoLetivo.GroupKeyGetter = delegate (object rowObject)
            {
                return "Ano Letivo";
            };

            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaAtributo.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }



        private void Aulas_Load(object sender, EventArgs e)
        {
            inicializarComboBoxDisc();
            inicializarComboBoxSala();
            inicializarComboBoxTurma();

            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Aulas LEFT JOIN  GestaoEscola.AnoLetivo ON anoLetivo=codigo WHERE docente=@docente", cn);
            cmd.Parameters.Add("@docente", SqlDbType.Int);
            cmd.Parameters["@docente"].Value = d.nmec;
            SqlDataReader r = cmd.ExecuteReader();
            // Create list of Objects given the query results
            while (r.Read())
            {
                Aula a = new Aula();
                a.docente = d.nmec;
                a.disciplina = r["disciplina"].ToString();
                comboDisciplina.Items.Insert(comboDisciplina.Items.Count, a.disciplina);
                a.diaSemana = Int32.Parse(r["diaSemana"].ToString());
                a.hInicio = TimeSpan.Parse(r["horaInicio"].ToString());
                a.hFim = TimeSpan.Parse(r["horaFim"].ToString());
                a.sala = Int32.Parse(r["sala"].ToString());

                Turma t = new Turma();
                t.nome = r["nomeTurma"].ToString();
                t.nivel = Int32.Parse(r["nivelTurma"].ToString());
                t.nMecDT = Int32.Parse(r["diretorDeTurma"].ToString());
                t.nomeDT = r["nomeDT"].ToString();
                t.anoID = Int32.Parse(r["anoLetivo"].ToString());
                t.dataInicio = DateTime.Parse(r["dataInicio"].ToString());
                t.dataF = DateTime.Parse(r["dataFim"].ToString()); turmas.Add(t);
                a.turma = t;
                aulas.Add(a);
                counter++;
            }

            // Close reader
            r.Close();

            // ObjectListView
            // Add Objects to list view
            listObjects.SetObjects(aulas);

            // Update stats
            updateStats();

        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Aula a = (Aula)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = a.disciplina;
            panelObjectSubtitulo.Text = a.horario;
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
        }

        private void addObject()
        { 
            // Clear all fields
            panelFormFieldHoraInicio.Text = "00:00:00";
            panelFormFieldHoraFim.Text = "00:00:00";
            comboDisciplina.SelectedIndex = 0;
            comboDiaSemana.SelectedIndex = 0;
            comboSala.SelectedIndex = 0;
            comboTurma.SelectedIndex = 0;

            // Enable fields that are not editable
            comboSala.Enabled = true;
            panelFormFieldHoraInicio.Enabled = true;
            panelFormFieldHoraFim.Enabled = true;

            // Set title and description
            panelFormTitulo.Text = "Adicionar uma nova aula";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar aula";
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
            Aula f = (Aula)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que pretende remover a aula da disciplina" + f.disciplina.ToString() + " deste docente?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            SqlCommand command = new SqlCommand(" DELETE FROM GestaoEscola.Aula WHERE sala = @sala AND horaInicio = @hIn AND horaFim = @hFim", cn);

            command.Parameters.Add("@sala", SqlDbType.Int);
            command.Parameters["@sala"].Value = f.sala;
            command.Parameters.Add("@hIn", SqlDbType.Time);
            command.Parameters["@hIn"].Value = f.hInicio;
            command.Parameters.Add("@hFim", SqlDbType.Time);
            command.Parameters["@hFim"].Value = f.hFim;

            // Execute query 
            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
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
            if (rowsAffected == 1)
            {
                // Remove object from interface list 
                listObjects.RemoveObject(f);
                // Show user feedback 
                MessageBox.Show(
                    "O tuplo foi eliminado com sucesso da base de dados!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                listObjects.BuildList(true);
                // Update stats
                updateStats();
                // Hide panels 
                panelForm.Visible = false;
                panelObject.Visible = false;
            }
            else
            {
                String errorMessage = "Ocorreu um erro, tente novamente!";
                MessageBox.Show(errorMessage,
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void editObject()
        {
            // Get Object 
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Aula a = (Aula)listObjects.SelectedObjects[0];
            // Set textboxes value 
            panelFormFieldHoraInicio.Text = a.hInicio.ToString();
            panelFormFieldHoraFim.Text = a.hFim.ToString();
            comboDiaSemana.SelectedItem = a.diaS;
            comboDisciplina.SelectedItem = a.disciplina;
            comboSala.Text = a.sala.ToString();
            comboTurma.SelectedItem = a.turma.nome;

            // Disable fields that are not editable
            comboSala.Enabled = false;
            panelFormFieldHoraInicio.Enabled = false;
            panelFormFieldHoraFim.Enabled = false;

            // Set title and description 
            panelFormTitulo.Text = "Editar aula";
            panelFormDescricao.Text = "Altere os dados e submita o formulário";
            panelFormButton.Text = "Submeter";
            // Make panel visible 
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " aulas do docente "+ d.nome;
        }

        private void pesquisar()
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
                    Aula aula = (Aula)x;
                    String toFilter = "";
                    switch (atr)
                    {
                        case "Disciplina":
                            toFilter = aula.disciplina;
                            break;
                        case "Turma":
                            toFilter = aula.turma.nome;
                            break;
                        case "Ano Letivo":
                            toFilter = aula.turma.strAnoLetivo;
                            break;
                        case "Dia da Semana":
                            toFilter = aula.diaS;
                            break;
                        case "Sala":
                            toFilter = aula.sala.ToString();
                            break;
                        case "Horario":
                            toFilter = aula.horario;
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
            // Validate if function shift is inside Nao Docente main shift 
            TimeSpan horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            if (horaInicio.CompareTo(horaFim) == 0)
            {
                MessageBox.Show(
                    "As horas de início de fim não podem ser iguais!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (horaInicio.CompareTo(horaFim) > 0)
            {
                MessageBox.Show(
                    "A hora de início não pode ser superior à de fim!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            return true;
        }

        private void buttonAdicionarObject_Click_1(object sender, EventArgs e)
        {
            panelForm.Visible = true;
            addObject();
        }

        private void inicializarComboBoxDisc()
        {
            int grupoD = d.grupoDisciplinar.num;
            SqlCommand command = new SqlCommand("SELECT nome FROM GestaoEscola.Disciplina WHERE grupoDisciplinar=@numGrupo", cn);
            // Add vars 
            command.Parameters.Add("@numGrupo", SqlDbType.Int);
            command.Parameters["@numGrupo"].Value = grupoD;
            SqlDataReader r = command.ExecuteReader();
            int c = 0;
            while (r.Read())
            {
                comboDisciplina.Items.Insert(c, r["nome"].ToString());
                c++;
            }
            r.Close();
        }

        private void inicializarComboBoxSala()
        {
            SqlCommand command = new SqlCommand("SELECT numero FROM GestaoEscola.Sala", cn);
            SqlDataReader r = command.ExecuteReader();
            int c = 0;
            while (r.Read())
            {
                comboSala.Items.Insert(c, r["numero"].ToString());
                c++;
            }
            r.Close();
        }
        private void inicializarComboBoxTurma()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT nivel,Turma.nome,anoLetivo, Pessoa.nome AS nomeDT ,diretorDeTurma FROM GestaoEscola.Turma JOIN GestaoEscola.Pessoa ON diretorDeTurma = NMec WHERE Pessoa.telemovel IS NOT NULL", cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Turma t = new Turma();
                t.nome = r["nome"].ToString();
                t.nivel = Int32.Parse(r["nivel"].ToString());
                t.nMecDT = Int32.Parse(r["diretorDeTurma"].ToString());
                t.nomeDT = r["nomeDT"].ToString();
                t.anoID = Int32.Parse(r["anoLetivo"].ToString());
                comboTurma.Items.Add(r["nome"].ToString());
                turmas.Add(t);
            }
            r.Close();
        }

        private void panelObjectEditar_Click(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
               editObject();
            }
        }

        private void listObjects_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }

        private void panelObjectEliminar_Click_1(object sender, EventArgs e)
        {
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
                    submitForm((Aula)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitForm(null);
                }
            }
        }

        private void panelFormHide_Click(object sender, EventArgs e)
        {
            panelForm.Visible = false;
        }

        private void panelObjectHide_Click(object sender, EventArgs e)
        {
            panelObject.Visible = false;
        }

        private void Aulas_FormClosed(object sender, FormClosedEventArgs e)
        {
            prev.Show();
        }

        private Turma getTurma(String nomeT)
        {
            foreach (Turma t in turmas)
            {
                if (nomeT == t.nome)
                    return t;
            }
            return null;
        }

        private void submitForm(Aula a)
        {
            bool edit = (a != null);

            // Get form data 
            int sala = Int32.Parse(comboSala.SelectedItem.ToString());
            string disciplina = comboDisciplina.Text;
            String nTurma = comboTurma.Text;
            TimeSpan horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            int diaSem = comboDiaSemana.SelectedIndex + 1;
            
            // Create command 
            SqlCommand command = new SqlCommand("GestaoEscola.AulaSP", cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@sala", SqlDbType.Int);
            command.Parameters["@sala"].Value = sala;
            command.Parameters.Add("@disciplina", SqlDbType.VarChar);
            command.Parameters["@disciplina"].Value = disciplina;
            command.Parameters.Add("@nomeT", SqlDbType.VarChar);
            command.Parameters["@nomeT"].Value = nTurma;
            command.Parameters.Add("@horaI", SqlDbType.Time);
            command.Parameters["@horaI"].Value = horaInicio;
            command.Parameters.Add("@horaF", SqlDbType.Time);
            command.Parameters["@horaF"].Value = horaFim;
            command.Parameters.Add("@diaS", SqlDbType.Int);
            command.Parameters["@diaS"].Value = diaSem;
            command.Parameters.Add("@docente", SqlDbType.Int);
            command.Parameters["@docente"].Value = d.nmec;
            command.Parameters.Add("@Edit", SqlDbType.Bit);
            command.Parameters["@Edit"].Value = 0;
            if (edit)
                command.Parameters["@Edit"].Value = 1;

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
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If query is successful 
            if (rowsAffected == 1 || rowsAffected == 2)
            {
                // If add operation, construct object (was null)
                if (!edit)
                    a = new Aula();
                a.sala = sala;
                a.disciplina = disciplina;
                a.diaSemana = diaSem;
                a.turma = getTurma(nTurma);
                a.hInicio = horaInicio;
                a.hFim = horaFim;

                if (!edit)
                    listObjects.AddObject(a);
                // SHow feedback to user 
                String successMessage = "A aula foi adicionada com sucesso!";
                if (edit)
                    successMessage = "A aula foi editada com sucesso";
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
    }
}
