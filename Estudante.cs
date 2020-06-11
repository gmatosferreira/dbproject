using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{ 
    class Estudante
    {
        private int _nmec, _telemovel, _telemovelEE;
        private String _nome, _nomeEE, _email, _emailEE;

        public Estudante() {}

        public int nmec
        {
            get { return this._nmec; }
            set { this._nmec = value; }
        }

        public int telemovel
        {
            get { return this._telemovel; }
            set { this._telemovel = value; }
        }

        public int telemovelEE
        {
            get { return this._telemovelEE; }
            set { this._telemovelEE = value; }
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String nomeEE
        {
            get { return this._nomeEE; }
            set { this._nomeEE = value; }
        }


        public String email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public String emailEE
        {
            get { return this._emailEE; }
            set { this._emailEE = value; }
        }
    }
}
