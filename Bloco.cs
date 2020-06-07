using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Bloco
    {
        private int _codigo;
        private String _nome, _coordenadas;
        private BlocoTipo _tipo;
        private NaoDocente _supervisor; // Not implemented yet

        public Bloco() { }

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

        public String coordenadas
        {
            get { return this._coordenadas; }
            set { this._coordenadas = value; }
        }

        public BlocoTipo tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public String str
        {
            get {
                String st = _nome;
                if (_tipo != null)
                    st += " (" + _tipo.str + ")";
                return st; 
            }
        }

    }
}
