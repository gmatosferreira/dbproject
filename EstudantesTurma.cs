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
    public partial class EstudantesTurma : Form
    {
        private SqlConnection cn;
        private int current = 0, counter = 0;
        private Form prev;
        private String nomeT;
        private List<EstudanteTurma> tuplos = new List<EstudanteTurma>();
        private int nivel, anoLetivo;
        public EstudantesTurma(SqlConnection cn, Form prev, int nivel, String nomeT, int anoLetivo )//passaar turma?
        {
            InitializeComponent();
            this.prev = prev;
            this.nivel = nivel;
            this.nomeT = nomeT;
            this.anoLetivo = anoLetivo;
            this.cn = cn;

            this.nmec.GroupKeyGetter = delegate (object rowObject) {
                // When the same is returned by every object, all of them are put together in one group
                return "Número mecanográfico";
            };
            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome";
            };
           
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaAtributo.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        private void EstudantesTurma_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT estudanteNMec,nome,turmaNivel,turmaNome,anoLetivo FROM GestaoEscola.EstudanteTurma JOIN GestaoEscola.Pessoa ON NMec = estudanteNMec WHERE telemovel IS NOT NULL AND turmaNivel=" + nivel + " AND turmaNome='" + nomeT + "' AND anoLetivo=" + anoLetivo + " ", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            while (reader.Read())
            {
                EstudanteTurma est = new EstudanteTurma();
                est.nmec = Int32.Parse(reader["estudanteNMec"].ToString());
                est.nome = reader["nome"].ToString();
                est.nomeT = reader["turmaNome"].ToString();
                est.anoLetivoID = Int32.Parse(reader["anoLetivo"].ToString());
                est.nivelT = Int32.Parse(reader["turmaNivel"].ToString());
                tuplos.Add(est);
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

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            EstudanteTurma f = (EstudanteTurma)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = f.nome;
            panelObjectSubtitulo.Text = f.nmec.ToString();
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
        }

        private void addObject()
        {
            // Clear all fields
            comboEstudantesSemTurma.SelectedIndex = 0;

            panelFormButton.Text = "Adicionar aluno";
            // Deselect pre selected row
            listObjects.DeselectAll();
            // Make panel visible
            if (!panelFormAddAluno.Visible)
                panelFormAddAluno.Visible = true;
            panelObject.Visible = false;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            EstudanteTurma f = (EstudanteTurma)listObjects.SelectedObjects[0];
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que pretende remover o estudante " + f.nome.ToString() + " da turma?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            MessageBox.Show("Funcionalidade em implementação...");

            // Hide panels
            panelFormAddAluno.Visible = false;
            panelObject.Visible = false;
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
                    EstudanteTurma estudante = (EstudanteTurma)x;
                    String toFilter = "";
                    switch (atr)
                    {
                        case "Número mecanográfico":
                            toFilter = estudante.nmec.ToString();
                            break;
                        case "Nome":
                            toFilter = estudante.nome;
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
            panelFormAddAluno.Visible = false;
        }

        private Boolean formValid() //usar no recado !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb = new StringBuilder();
           /* if (!RegexExpressions.isInteger(panelFormFieldNMec.Text))
            {
                error = true;
                sb.Append(" NMec");
            }
            if (!RegexExpressions.isDouble(panelFormFieldSalario.Text))
            {
                error = true;
                sb.Append(" Salário");
            }
            if (!RegexExpressions.isPhoneNumber(panelFormFieldContacto.Text))
            {
                error = true;
                sb.Append(" Telemovel");
            }
            if (!RegexExpressions.isEmail(panelFormFieldEmail.Text))
            {
                error = true;
                sb.Append(" Email");
            }
            // Check others
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 65)
            {
                error = true;
                sb.Append(" Nome (max 65 caracteres)");
            }*/
            // Give user feedback
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
        /*
        private void submitForm(NaoDocente ndocente)
        {
            bool edit = (ndocente != null);

            // Get form data 
            int nmec = Int32.Parse(panelFormFieldNMec.Text);
            String nome = panelFormFieldNome.Text;
            Double salario = Double.Parse(panelFormFieldSalario.Text);
            int telemovel = Int32.Parse(panelFormFieldContacto.Text);
            String emailPrefixo = panelFormFieldEmail.Text.Split('@')[0];
            String emailDominio = panelFormFieldEmail.Text.Split('@')[1];
            Turno turno = getTurno(panelFormFieldTurno.Text);

            // Create command 
            String commandText = "pr_NaoDocentes";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@NMec", SqlDbType.Int);
            command.Parameters["@NMec"].Value = nmec;
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters["@Nome"].Value = nome;
            command.Parameters.Add("@Telemovel", SqlDbType.Int);
            command.Parameters["@Telemovel"].Value = telemovel;
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters["@Email"].Value = emailPrefixo;
            command.Parameters.Add("@EmailDominio", SqlDbType.VarChar);
            command.Parameters["@EmailDominio"].Value = emailDominio;
            command.Parameters.Add("@Salario", SqlDbType.Money);
            command.Parameters["@Salario"].Value = salario;
            command.Parameters.Add("@Turno", SqlDbType.Int);
            command.Parameters["@Turno"].Value = turno.codigo;
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
            // If query is successful 
            if (rowsAffected == 3 && returnValue == 1)
            {
                // If add operation, construct object (was null)
                if (!edit)
                    ndocente = new NaoDocente();
                ndocente.nmec = nmec;
                ndocente.nome = nome;
                ndocente.email = emailPrefixo + "@" + emailDominio;
                ndocente.telemovel = telemovel;
                ndocente.salario = salario;
                ndocente.turno = turno;
                if (!edit)
                    listObjects.AddObject(ndocente);
                // SHow feedback to user 
                String successMessage = "O não docente foi adicionado com sucesso!";
                if (edit)
                    successMessage = "O não docente foi editado com sucesso";
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
        */

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "Esta turma tem " + listObjects.Items.Count.ToString() + " estudantes";
        }


        private void panelObjectHide_Click(object sender, EventArgs e)
        {
            // Hide data panel (both edit and data)
            panelObject.Visible = false;
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            panelRecado.Visible = false;
        }

        private void hidde1_Click(object sender, EventArgs e)
        {
            panelFormAddAluno.Visible = false;
        }

        private void buttonAdicionarObject_Click(object sender, EventArgs e)
        {
            panelFormAddAluno.Visible = true;
            inicializarComboBoxAdd();
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }

        private void panelObjectEliminar_Click(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                deleteObject();
            }
        }

        private void enviarRecado_Click(object sender, EventArgs e)
        {
            // if(todos)
                //Recado r = new Recado();
                //submitForm(r);
            //if(!todos)
                //Anuncio a = new Anuncio();
                //submitForm(a);
            panelRecado.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRecado.Visible = true;
            inicializarComboBoxTo();
            inicializarComboBoxFrom();
        }

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            // Get form data 
            int nmecE = Int32.Parse(comboEstudantesSemTurma.SelectedItem.ToString().Split('-')[0]);
            String nomeE = comboEstudantesSemTurma.SelectedItem.ToString().Split('-')[1];

            // Create command 
            String commandText = "INSERT INTO GestaoEscola.EstudanteTurma VALUES (@nmec, @turmaNivel, @turmaNome, @ano)";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@nmec", SqlDbType.Int);
            command.Parameters["@nmec"].Value = nmecE;
            command.Parameters.Add("@turmaNivel", SqlDbType.Int);
            command.Parameters["@turmaNivel"].Value = nivel;
            command.Parameters.Add("@turmaNome", SqlDbType.VarChar);
            command.Parameters["@turmaNome"].Value = nomeT;
            command.Parameters.Add("@ano", SqlDbType.Int);
            command.Parameters["@ano"].Value = anoLetivo;

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

            EstudanteTurma et = new EstudanteTurma();
            et.nivelT = nivel;
            et.nomeT = nomeT;
            et.anoLetivoID = anoLetivo;
            et.nmec = nmecE;
            et.nome = nomeE;
            tuplos.Add(et);
            listObjects.AddObject(et);
            listObjects.BuildList(true);

            inicializarComboBoxAdd();
            updateStats();
            panelFormAddAluno.Visible = false;
        }

        private void EstudantesTurma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.prev.Show();
        }

        private void inicializarComboBoxAdd()
        {
            comboEstudantesSemTurma.Items.Clear();
            SqlCommand cmd = new SqlCommand("GestaoEscola.EstudantesSemTurmaSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int c = 0;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                // lista de docentes nao diretores de turma e nmec
                String s = r["NMec"].ToString() + "-" + r["nome"].ToString();
                comboEstudantesSemTurma.Items.Insert(c, s);
                c++;
            }
            r.Close();
        }

        private void pesquisaTexto_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void inicializarComboBoxFrom()
        {
            docenteCombo.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT nome, nmec FROM vw_Docentes WHERE telemovel IS NOT NULL", cn);
            int c = 0;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                // lista de docentes nao diretores de turma e nmec
                String s = r["NMec"].ToString() + "-" + r["nome"].ToString();
                docenteCombo.Items.Insert(c, s);
                c++;
            }
            r.Close();
        }

        private void inicializarComboBoxTo()
        {
            destinarioCombo.Items.Clear();
            destinarioCombo.Items.Insert(0, "Todos");
            
            int c = 1;
            foreach (EstudanteTurma est in tuplos) {
                String s = est.nmec.ToString() + "-" + est.nome;
                destinarioCombo.Items.Insert(c, s);
                c++;
            }
        }
    }
}
