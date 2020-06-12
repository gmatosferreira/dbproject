using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Aula
    {
        private int _sala, _diaSemana, _docente;
        private String _disciplina;
        private TimeSpan _hInicio, _hFim;
        private Turma _turma;

        public Aula() { }

        public int sala
        {
            get { return this._sala; }
            set { this._sala = value; }
        }
        public int diaSemana
        {
            get { return this._diaSemana; }
            set { this._diaSemana = value; }
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
        public TimeSpan hInicio
        {
            get { return this._hInicio; }
            set { this._hInicio = value; }
        }
        public TimeSpan hFim
        {
            get { return this._hFim; }
            set { this._hFim = value; }
        }
        public Turma turma
        {
            get { return this._turma; }
            set { this._turma = value; }
        }
        public String turmaNome
        {
            get { return turma.nome; }
        }
        public String turmaAno
        {
            get { return turma.strAnoLetivo; }
        }

        public String horario
        {
            get { return _hInicio.ToString(@"hh\:mm\:ss", null) + " às " + _hFim.ToString(@"hh\:mm\:ss", null); }
        }

        public String diaS {
            get
            {
                switch(_diaSemana){
                    case 1:
                        return "Segunda-Feira";
                    case 2:
                        return "Terça-Feira";
                    case 3:
                        return "Quarta-Feira";
                    case 4:
                        return "Quinta-Feira";
                    case 5:
                        return "Sexta-Feira";
                    default:
                        return "";
                }
            }
        }
    }
}
