using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Docente : Funcionario
    {
        private GrupoDisciplinar _grupoDisciplinar;

        public Docente() { }

        public GrupoDisciplinar grupoDisciplinar
        {
            get { return this._grupoDisciplinar; }
            set { this._grupoDisciplinar = value; }
        }

    }
}
