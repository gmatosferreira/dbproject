using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class NaoDocente : Funcionario
    {
        private Turno _turno;

        public NaoDocente() { }

        public Turno turno
        {
            get { return this._turno; }
            set { this._turno = value; }
        }

    }
}
