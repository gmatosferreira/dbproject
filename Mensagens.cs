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
    public partial class Mensagens : Form
    {
        private SqlConnection cn;
        private Form prev;
        private Estudante est;
        public Mensagens(Form prev, SqlConnection cn, Estudante est)
        {
            InitializeComponent();
            this.prev = prev;
            this.cn = cn;
            this.est = est;
        }

        private void Mensagens_FormClosed(object sender, FormClosedEventArgs e)
        {
            prev.Show();
        }

        private void Mensagens_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            
            String cmdTxt = "SELECT data,hora,mensagem,assunto,docente, nome FROM GestaoEscola.Anuncio JOIN GestaoEscola.EstudanteTurma ON (EstudanteTurma.turmaNivel =Anuncio.turmaNivel AND EstudanteTurma.turmaNome=Anuncio.turmaNome AND EstudanteTurma.anoLetivo= Anuncio.anoLetivo) JOIN GestaoEscola.Pessoa ON docente=NMec WHERE telemovel IS NOT NULL AND estudanteNMec=@nmec; ";
            SqlCommand cmd = new SqlCommand(cmdTxt, cn);
            cmd.Parameters.AddWithValue("@nmec", est.nmec);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                mensagem m = new mensagem(this);
                m.setAssunto = reader["assunto"].ToString();
                m.setData = DateTime.Parse(reader["data"].ToString());
                m.setHora = TimeSpan.Parse(reader["hora"].ToString());
                m.setMsg = reader["mensagem"].ToString();
                m.setNomeDocente = reader["nome"].ToString();
                m.GetHoraData();
                m.setTipo = "Anúncio".ToString();

                //add  Notification to flow layout
                flowLayoutPanel1.Controls.Add(m);
            }
            reader.Close();

            String cmdTxt2 = "SELECT Pessoa.nome,[data],assunto,mensagem FROM GestaoEscola.Recado JOIN GestaoEscola.Pessoa ON docenteNMEC=NMec WHERE telemovel IS NOT NULL AND estudanteNMec=@nmec; ";
            SqlCommand cmd2 = new SqlCommand(cmdTxt2, cn);
            cmd2.Parameters.AddWithValue("@nmec", est.nmec);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                mensagem m2 = new mensagem(this);
                m2.setAssunto = reader2["assunto"].ToString();
                m2.setData = DateTime.Parse(reader2["data"].ToString());
                m2.setMsg = reader2["mensagem"].ToString();
                m2.setNomeDocente = reader2["nome"].ToString();
                m2.GetHoraData();
                m2.setTipo = "Recado".ToString();

                //add  Notification to flow layout
                flowLayoutPanel1.Controls.Add(m2);
            }
            reader2.Close();
        }
    }
}
