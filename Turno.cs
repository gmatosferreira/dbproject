using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Turno
    {
        private int _codigo;
        private TimeSpan _horaInicio, _horaFim;

        public Turno() { }

        public int codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
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

        public String str
        {
            get { return _horaInicio.ToString(@"hh\:mm\:ss", null) + " às " + _horaFim.ToString(@"hh\:mm\:ss", null); }
        }

        public static bool isInside(Turno t1, Turno t2)
        {
            if (t1.horaInicio.CompareTo(t2.horaInicio) >= 0) {
                if (t1.horaFim.CompareTo(t2.horaFim) <= 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
