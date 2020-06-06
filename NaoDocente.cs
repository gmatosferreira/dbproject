using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class NaoDocente : Funcionario
    {
        private int _grupoDisciplinar;
        private String _grupoDisciplinarStr;

        public NaoDocente() { }

        public int grupoDisciplinar
        {
            get { return this._grupoDisciplinar; }
            set { this._grupoDisciplinar = value; }
        }

        public String grupoDisciplinarStr
        {
            get { return this._grupoDisciplinarStr; }
            set { this._grupoDisciplinarStr = value; }
        }

    }
}
