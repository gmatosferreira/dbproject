using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class NDTrabalhaBloco
    {
        private int _nmec, _codigoFuncao;
        private String _blocoCoordenadas;
        private TimeSpan _horaInicio, _horaFim;

        public NDTrabalhaBloco() { }

        public int nmec
        {
            get { return this._nmec; }
            set { this._nmec = value; }
        }

        public int codigoFuncao
        {
            get { return this._codigoFuncao; }
            set { this._codigoFuncao = value; }
        }

        public String blocoCoordenadas
        {
            get { return this._blocoCoordenadas; }
            set { this._blocoCoordenadas = value; }
        }

        public TimeSpan horaInicio
        {
            get { return this._horaInicio; }
            set { this._horaInicio = value; }
        }

        public TimeSpan horaFim
        {
            get { return this._horaFim; }
            set { this._horaFim = value; }
        }

    }
}
