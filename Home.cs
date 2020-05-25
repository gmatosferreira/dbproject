using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// SQL Stuff
using System.Data.SqlClient;
using System.Data;

namespace Funcionarios
{
    public partial class Home : Form
    {
        // Attributes
        private SqlConnection cn;
        private bool debug = true;

        // Constructor
        public Home()
        {
            InitializeComponent();
        }

        // SQL methods
        private SqlConnection getSGBDConnection()
        {
            // Constructs a new SqlConnection
            return new SqlConnection("data source=tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p4g2; uid = p4g2; password = somosLINDOS2020");
        }
        private bool verifySGBDConnection()
        {
            // Opens connection to the DB
            if (cn == null)
                cn = getSGBDConnection();

            if (cn!=null)
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();
                } catch (SqlException e)
                {
                    return false;
                }

                return cn.State == ConnectionState.Open;
            }

            return false;
        }

        // Other methods
        private void featureNotImplemented()
        {
            MessageBox.Show("This functionality is not implemented yet, sorry!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getStats()
        {
            // Make SQL requests for every table to get the number of rows of each one
            SqlCommand cmd = new SqlCommand("SELECT COUNT(NMec) AS N FROM GestaoEscola.Docente", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String n = reader["N"].ToString();
            statsDocentesLabel.Text = n;
            reader.Close();
        }

        // Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            // Construct SqlConnection
            cn = getSGBDConnection();
            // Open connection
            verifySGBDConnection();
            // Check if there was an error 
            DialogResult userfeedback;
            bool repeat = true;
            while (repeat)
            {
                if (cn == null || cn.State != ConnectionState.Open)
                {
                    // If there was an error, ask the user if he wants to retry the connection to the DB
                    userfeedback = MessageBox.Show("Could not connect to DB. Do tou want to retry?", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    repeat = (userfeedback == DialogResult.Retry);
                    if (userfeedback == DialogResult.Cancel)
                        this.Close();
                    verifySGBDConnection();
                }
                else
                {
                    repeat = false;
                }

            }
            getStats();
        }

        private void menuFuncionariosPanel_Click(object sender, EventArgs e)
        {
            // Hide this form and open the interface for the clicked item
            this.Hide();
            Docentes f = new Docentes(cn, this);
            f.ShowDialog();
        }

    }
}
