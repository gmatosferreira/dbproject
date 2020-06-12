using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Anuncio
    {
        private int _nmecEst, _nmecDocente;
        private String _assunto, _mensagem;
        private DateTime _data;
        private TimeSpan _hora;
        private Turma _turma;

        public Anuncio() { }

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
        public Turma turma
        {
            get { return this._turma; }
            set { this._turma = value; }
        } 
        public TimeSpan hora
        {
            get { return this._hora; }
            set { this._hora = value; }
        }
        public DateTime data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
