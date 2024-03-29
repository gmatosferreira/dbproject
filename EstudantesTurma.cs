﻿using BrightIdeasSoftware;
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

        private Boolean formValid() 
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb = new StringBuilder();
            
            if (assuntoText.Text == "" || assuntoText.Text.Length > 30)
            {
                error = true;
                sb.Append(" Assunto (max 30 caracteres).");
            }
            if (MensagemText.Text == "" )
            {
                error = true;
                sb.Append(" Mensagem vazia!");
            }
            if (destinarioCombo.Text.Length == 0) {
                error = true;
                sb.Append(" Escolha um destinatário.");
            }
            if (docenteCombo.Text.Length == 0)
            {
                error = true;
                sb.Append(" Escolha um docente.");
            }
            // Give user feedback
            if (error)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente os seguintes campos:" + sb.ToString(),
                   "Atenção!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
               );
            }
            return !error;
        }
       
        private void submitForm(Object o)
        {
            Type tipo = o.GetType();
            bool recado = (tipo.Equals(typeof(Recado)));

            // Get form data 
            String mensagem = MensagemText.Text;
            String assunto = assuntoText.Text;
            String nomeDocente = docenteCombo.SelectedItem.ToString().Split('-')[1];
            int nmecDocente = Int32.Parse(docenteCombo.SelectedItem.ToString().Split('-')[0]);
            String estudante = "";
            int numEstudante = 0;
            DateTime data = DateTime.Now;
            TimeSpan hora = DateTime.Now.TimeOfDay;
            MessageBox.Show(hora.ToString());

            if (recado)
            {
                estudante = destinarioCombo.SelectedItem.ToString().Split('-')[1];
                numEstudante = Int32.Parse(destinarioCombo.SelectedItem.ToString().Split('-')[0]);
            }
            // Create command 
            SqlCommand command = new SqlCommand("GestaoEscola.mensagensSP", cn);
            command.CommandType = CommandType.StoredProcedure;

            // Add vars 
            command.Parameters.Add("@docenteNmec", SqlDbType.Int);
            command.Parameters["@docenteNmec"].Value = nmecDocente;
            command.Parameters.Add("@assunto", SqlDbType.VarChar);
            command.Parameters["@assunto"].Value = assunto;
            command.Parameters.Add("@mensagem", SqlDbType.Text);
            command.Parameters["@mensagem"].Value = mensagem;
            command.Parameters.Add("@nomeT", SqlDbType.VarChar);
            command.Parameters["@nomeT"].Value = nomeT;
            command.Parameters.Add("@nivelT", SqlDbType.Int);
            command.Parameters["@nivelT"].Value = nivel;
            command.Parameters.Add("@ano", SqlDbType.Int);
            command.Parameters["@ano"].Value = anoLetivo ;
            command.Parameters.Add("@NmecEst", SqlDbType.Int);
            command.Parameters["@NmecEst"].Value = numEstudante;
            command.Parameters.Add("@dataA", SqlDbType.Date);
            command.Parameters["@dataA"].Value = data;
            command.Parameters.Add("@hora", SqlDbType.Time);
            command.Parameters["@hora"].Value = hora;
            command.Parameters.Add("@dataR", SqlDbType.DateTime);
            command.Parameters["@dataR"].Value = data;
            command.Parameters.Add("@Recado", SqlDbType.Bit);
            if(recado)
                command.Parameters["@Recado"].Value = 1;
            else
                command.Parameters["@Recado"].Value = 0;
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
            if (rowsAffected == 1)
            {              
                String successMessage = "O anúncio foi enviado para a turma com sucesso!";
                if (recado)
                    successMessage = "O recado foi enviado para o aluno com sucesso";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Hide panels 
                panelRecado.Visible = false;
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
            if (formValid()) { 
                String destinatario = destinarioCombo.SelectedItem.ToString();
                if (destinatario.Equals("Todos"))
                {
                    Anuncio a = new Anuncio();
                    submitForm(a);
                }
                else
                {
                    Recado r = new Recado();
                    submitForm(r);
                }
                panelRecado.Visible = false;
            }
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

        private void pesquisaAtributo_SelectedIndexChanged(object sender, EventArgs e)
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
