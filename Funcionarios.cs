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
    public partial class Funcionarios : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        int counter = 0;

        // Constructor
        public Funcionarios(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            InitializeComponent();
        }
        

        //  Methods
        private void updateStats()
        {
            stats.Text = "A mostrar " + counter.ToString() + " registos";
        }

        // Event handlers
        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous.Show();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // Executar query SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Funcionario", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Add data to list
            list.View = View.Details;
            ListViewItem item;
            while (reader.Read())
            {
                item = new ListViewItem(reader["PNMec"].ToString());
                item.SubItems.Add(reader["salario"].ToString());
                list.Items.Add(item);
                counter++;
            }
            list.Columns.Add("NMec", 150, HorizontalAlignment.Left);
            list.Columns.Add("Salário (€)", 150, HorizontalAlignment.Left);
            // Update stats
            updateStats();
        }


    }
}
