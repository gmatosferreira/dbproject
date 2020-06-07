using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class BlocoTipo
    {
        private int _codigo;
        private String _nome;

        public BlocoTipo() { }

        public int codigo
        {
            get { return this._codigo; }
            set { this._codigo= value; }
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String str
        {
            get { return _nome; }
        }

    }
}
