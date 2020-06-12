using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class BlocoSala
    {
        private int _numSala;
        private String _coordenadas;

        public BlocoSala() { }

        public int numSala
        {
            get { return this._numSala; }
            set { this._numSala = value; }
        }

        public String coordenadas
        {
            get { return this._coordenadas; }
            set { this._coordenadas = value; }
        }
    }
}
