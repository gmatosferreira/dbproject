using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class NDTrabalhaBloco
    {
        private NaoDocente _nd;
        private NDFuncao _funcao;
        private Bloco _bloco;
        private Turno _turno;

        public NDTrabalhaBloco() { }

        public NaoDocente nd
        {
            get { return this._nd; }
            set { this._nd = value; }
        }

        public NDFuncao funcao
        {
            get { return this._funcao; }
            set { this._funcao = value; }
        }

        public Bloco bloco
        {
            get { return this._bloco; }
            set { this._bloco = value; }
        }

        public Turno turno
        {
            get { return this._turno; }
            set { this._turno = value; }
        }

    }
}
