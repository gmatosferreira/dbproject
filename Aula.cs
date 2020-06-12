using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Aula
    {
        private int _sala, _diaS, _docente;
        private String _disciplina;
        private DateTime _hInicio, _hFim;
        private Turma _turma;

        public Aula() { }

        public int sala
        {
            get { return this._sala; }
            set { this._sala = value; }
        }
        public int diaS
        {
            get { return this._diaS; }
            set { this._diaS = value; }
        }
        public int docente
        {
            get { return this._docente; }
            set { this._docente = value; }
        }
        public String disciplina
        {
            get { return this._disciplina; }
            set { this._disciplina = value; }
        }
        public DateTime hInicio
        {
            get { return this._hInicio; }
            set { this._hInicio = value; }
        }
        public DateTime hFim
        {
            get { return this._hFim; }
            set { this._hFim = value; }
        }
        public Turma turma
        {
            get { return this._turma; }
            set { this._turma = value; }
        }
        public String horario
        {
            get { return _hInicio.ToString(@"hh\:mm\:ss", null) + " às " + _hFim.ToString(@"hh\:mm\:ss", null); }
        }
        public String anoStr { 
            get { return turma.strAnoLetivo;  }
        }
    }
}
