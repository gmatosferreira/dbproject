using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Recado
    {
        private int _nmecEst, _nmecDocente;
        private String _assunto, _mensagem;
        private DateTime _data;

        public Recado() { }

        public int nmecEst
        {
            get { return this._nmecEst; }
            set { this._nmecEst = value; }
        }

        public int nmecDocente
        {
            get { return this._nmecDocente; }
            set { this._nmecDocente = value; }
        }

        public String assunto
        {
            get { return this._assunto; }
            set { this._assunto = value; }
        }

        public String mensagem
        {
            get { return this._mensagem; }
            set { this._mensagem = value; }
        }


        public DateTime data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
