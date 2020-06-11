using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Turma
    {
        private int _nivel, _nMecDT, _anoID;
        private String _nomeDT, _nome;
        private DateTime _dataInicio, _dataF;

        
            public int nivel
            {
                get { return this._nivel; }
                set { this._nivel = value; }
            }
            public int anoID
            {
                get { return this._anoID; }
                set { this._anoID = value; }
            }

        public int nMecDT
            {
                get { return this._nMecDT; }
                set { this._nMecDT = value; }
            }

            public DateTime dataInicio
            {
                get { return this._dataInicio; }
                set { this._dataInicio = value; }
            }

            public DateTime dataF
            {
                get { return this._dataF; }
                set { this._dataF = value; }
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
            public String strAnoLetivo
            {
            get { return _dataInicio.ToString("dd/MM/yy",null) + " até: " + _dataF.ToString("dd/MM/yy", null); }
             }
    }
}
