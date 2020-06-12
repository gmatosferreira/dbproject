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
using BrightIdeasSoftware;

namespace Funcionarios
{
    public partial class BlocoSalas : Form
    {
        private SqlConnection cn;
        private Form previous;
        private Bloco b;
        private int current = 0, counter = 0;
        private List<BlocoSala> salas = new List<BlocoSala>();

        public BlocoSalas(Form prev, SqlConnection cn, Bloco b)
        {
            InitializeComponent();
            previous = prev;
            this.cn = cn;
            this.b = b;
            this.listObjects.FullRowSelect = true;   //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0;      //Make the first row selected ad default
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " salas do Bloco " + b.nome.ToString();
        }

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            //criar sala
            if (RegexExpressions.isInteger(numSalaInput.Text)){
                //codigo insert sala
                String commandText = "INSERT INTO GestaoEscola.Sala VALUES(@numS, @BlocoCoord)";
                SqlCommand command = new SqlCommand(commandText, cn);
                // Add vars 
                command.Parameters.Add("@BlocoCoord", SqlDbType.VarChar);
                command.Parameters["@BlocoCoord"].Value = b.coordenadas;
                command.Parameters.Add("@numS", SqlDbType.Int);
                command.Parameters["@numS"].Value = Int32.Parse(numSalaInput.Text);

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
                        "Ocorreu um erro, tente novamente!\r\n" + ex.ToString(),
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                // If successful query  
                if (rowsAffected == 2)
                {
                    BlocoSala s1 = new BlocoSala();
                    s1.numSala = Int32.Parse(numSalaInput.Text);
                    s1.coordenadas = b.coordenadas;
                    salas.Add(s1);
                    listObjects.BuildList(true);
                    updateStats();
                }
                else
                {
                    MessageBox.Show(
                  "Esse número de sala já existe!",
                  "Erro na submissão!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                    );
                }
            }
            else {
                MessageBox.Show(
                  "Confirme que preencheu corretamente o campo com um número inteiro!",
                  "Erro na submissão!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
              );
            }
        }

        private void buttonAdicionarObject_Click(object sender, EventArgs e)
        {
            panelCriarSala.Visible = true;
        }

        private void loadSalas(object sender, EventArgs e)
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Sala WHERE SalaCoord=@bCoord", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@bCoord", b.coordenadas);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BlocoSala s = new BlocoSala();
                s.coordenadas = reader["SalaCoord"].ToString();
                s.numSala = Int32.Parse(reader["numero"].ToString());
                salas.Add(s);
            }

            // Close reader
            reader.Close();
            updateStats();
            listObjects.SetObjects(salas);
        }

        private void BlocoSalas_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelSala.Visible = false;
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listObjects.SelectedIndex >= 0)
            {
                showObject();
            }
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            BlocoSala s = (BlocoSala)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = s.numSala.ToString();
            // Show panel
            if (!panelSala.Visible)
                panelSala.Visible = true;
            panelCriarSala.Visible = false;

        }
        private void panelFormHide_Click(object sender, EventArgs e)
        {
            panelCriarSala.Visible = false;
        }
    }
}
