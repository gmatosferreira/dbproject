using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class GrupoDisciplinar
    {
        private int _num;
        private String _nome;

        public GrupoDisciplinar() { }

        public int num
        {
            get { return this._num; }
            set { this._num = value; }
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }
    }
}
