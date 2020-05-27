using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Turma
    {
        private int _nivel, _anoLetivo;
            private String _nomeDT, _nome;

            public Turma() { }

            public int nivel
            {
                get { return this._nivel; }
                set { this._nivel = value; }
            }

            public int anpLetivo
            {
                get { return this._anoLetivo; }
                set { this._anoLetivo = value; }
            }

            public String nome
            {
                get { return this._nome; }
                set { this._nome = value; }
            }

            public String nomeDT
            {
                get { return this._nomeDT; }
                set { this._nomeDT = value; }
            }
        }
}
