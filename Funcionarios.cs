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
            this.funcionariosListView.FullRowSelect = true;
            this.funcionariosListView.SelectedIndex = 0;
        }

        //  Methods
        private void updateStats()
        {
            stats.Text = "A mostrar " + counter.ToString() + " registos";
        }

        private void showObject()
        {
            if (funcionariosListView.Items.Count == 0 | current < 0)
                return;
            Funcionario f = (Funcionario)funcionariosListView.SelectedObjects[0];
            panelObjectTitulo.Text = f.nome;
            panelObjectSubtitulo.Text = f.nmec.ToString();
            if (!panelObject.Visible)
                panelObject.Visible = true;

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
            funcionariosListView.SetObjects(funcionarios);

            // Update stats
            updateStats();

            // Close reader
            reader.Close();
        }

   
        private void funcionariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (funcionariosListView.SelectedIndex >= 0)
            {
                current = funcionariosListView.SelectedIndex;
                showObject();
            }
        }
    }
}
