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
    public partial class NaoDocenteHorario : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private NaoDocente nd;
        private int current = 0, counter = 0;
        private List<Bloco> blocos;
        private List<NDFuncao> funcoes;

        // Constructor
        public NaoDocenteHorario(SqlConnection cn, NaoDocente nd, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.nd = nd;
            this.blocos = new List<Bloco>();
            this.funcoes = new List<NDFuncao>();
            InitializeComponent();
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

        private Bloco getBlocoByNome(String nome)
        {
            foreach (Bloco b in blocos)
            {
                if (nome.Equals(b.nome, StringComparison.InvariantCultureIgnoreCase))
                    return b;
            }
            return null;
        }

        private void loadBibliotecas()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Biblioteca", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bloco t = new Bloco();
                t.nome = "Biblioteca " + reader["nome"].ToString();
                blocos.Add(t);
            }

            // Close reader
            reader.Close();
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

        private NDFuncao getFuncao(String nome)
        {
            foreach (NDFuncao f in funcoes)
            {
                if (nome.Equals(f.nome, StringComparison.InvariantCultureIgnoreCase))
                    return f;
            }
            return null;
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar o horário do funcionário "+nd.nmec.ToString();
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
            loadBibliotecas();
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
                addToInterface(d);
                counter++;
            }
            // Close reader
            reader.Close();

            // Execute SQL query to get trabalha_Biblioteca rows
            cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_trabalha_Biblioteca WHERE NMec=" + nd.nmec.ToString(), cn);
            reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            while (reader.Read())
            {
                NDTrabalhaBloco d = new NDTrabalhaBloco();
                d.nd = nd;
                d.funcao = getFuncao(Int32.Parse(reader["codFuncao"].ToString()));
                d.bloco = getBlocoByNome("Biblioteca " + reader["biblioteca"].ToString());
                Turno t = new Turno();
                t.horaInicio = TimeSpan.Parse(reader["horaInicio"].ToString());
                t.horaFim = TimeSpan.Parse(reader["horaFim"].ToString());
                d.turno = t;
                addToInterface(d);
            }
            // Close reader
            reader.Close();

            // Update stats
            updateStats();
        }

        void addToInterface(NDTrabalhaBloco d)
        {
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(00,00,00), new TimeSpan(02,00,00)))
            {
                horario0002.Text = horario0002.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(02, 00, 00), new TimeSpan(04, 00, 00)))
            {
                horario0204.Text = horario0204.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(04, 00, 00), new TimeSpan(06, 00, 00)))
            {
                horario0406.Text = horario0406.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(06, 00, 00), new TimeSpan(08, 00, 00)))
            {
                horario0608.Text = horario0608.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(08, 00, 00), new TimeSpan(10, 00, 00)))
            {
                horario0810.Text = horario0810.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(10, 00, 00), new TimeSpan(12, 00, 00)))
            {
                horario1012.Text = horario1012.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(12, 00, 00), new TimeSpan(14, 00, 00)))
            {
                horario1214.Text = horario1214.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(14, 00, 00), new TimeSpan(16, 00, 00)))
            {
                horario1416.Text = horario1416.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(16, 00, 00), new TimeSpan(18, 00, 00)))
            {
                horario1618.Text = horario1618.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(18, 00, 00), new TimeSpan(20, 00, 00)))
            {
                horario1820.Text = horario1820.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(20, 00, 00), new TimeSpan(22, 00, 00)))
            {
                horario2022.Text = horario2022.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
            if (turnoInsideTimeSpan(d.turno, new TimeSpan(22, 00, 00), new TimeSpan(24, 00, 00)))
            {
                horario2224.Text = horario2224.Text + d.turno.str + "\r\n" + d.bloco.nome + ", como " + d.funcao.nome + "\r\n\r\n";
            }
        }

        bool turnoInsideTimeSpan(Turno t, TimeSpan inicio, TimeSpan fim)
        {
            if (t.horaInicio >= inicio && t.horaInicio < fim)
                return true;
            if (t.horaInicio < inicio && t.horaFim > fim)
                return true;
            if (t.horaFim > inicio && t.horaFim <= fim)
                return true;
            return false;
        }



    }
}
