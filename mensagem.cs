using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class mensagem : UserControl
    {
        private Form f;
        private DateTime _data;
        private TimeSpan _hora;

        public mensagem(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        public String setTipo
        {
            set { tipo.Text = value; }
        }
        public String setAssunto
        {
            set { assuntoText.Text = value ; }
        }
        public String setMsg
        {
            set { mensagemText.Text = value; }
        }

        public String setNomeDocente
        {
            set { docenteNome.Text = value; }
        }

        public void GetHoraData()
        {
            data_hora.Text = (_data + " " + _hora).ToString();
        }
        public void GetData()
        {
            data_hora.Text = _data.ToString();
        }
        public DateTime setData
        {
            set { this._data = value; }
        }

        public TimeSpan setHora
        {
            set { this._hora = value; }
        }
    }
}
