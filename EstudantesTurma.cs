using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class EstudantesTurma : Form
    {
        private Form prev;
        private String nomeT;
        private int nivel, anoLetivo;
        public EstudantesTurma(Form prev, int nivel, String nomeT, int anoLetivo )//passaar turma?
        {
            InitializeComponent();
            this.prev = prev;
            this.nivel = nivel;
            this.nomeT = nomeT;
            this.anoLetivo = anoLetivo;
        }

        private void EstudantesTurma_Load(object sender, EventArgs e)
        {
            // "SELECT * FROM GestaoEscola.EstudanteTurma WHERE nivel="+nivel+" AND nome='"+nomeT+"' AND anoLetivo="+anoLetivo";"

        }

        private void EstudantesTurma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.prev.Show();
        }
    }
}
