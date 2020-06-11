using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Biblioteca
    {
        private String _nome;
        private Turno _horario;
        private NaoDocente _supervisor;
        private int _diasEntregaLivros;

        public Biblioteca() { }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public Turno horario
        {
            get { return this._horario; }
            set { this._horario = value; }
        }

        public NaoDocente supervisor
        {
            get { return this._supervisor; }
            set { this._supervisor = value; }
        }

        public int diasEntregaLivros
        {
            get { return this._diasEntregaLivros; }
            set { this._diasEntregaLivros = value; }
        }
    }
}
