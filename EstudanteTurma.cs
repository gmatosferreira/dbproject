using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class EstudanteTurma
    {

        private int _nmec, _nivelT, _anoLetivoID;
        private String _nome, _nomeT;

        public EstudanteTurma() { }

        public int nivelT
        {
            get { return this._nivelT; }
            set { this._nivelT = value; }
        }

        public int anoLetivoID
        {
            get { return this._anoLetivoID; }
            set { this._anoLetivoID = value; }
        }

        public int nmec
        {
            get { return this._nmec; }
            set { this._nmec = value; }
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }
        public String nomeT
        {
            get { return this._nomeT; }
            set { this._nomeT = value; }
        }
    }
}
