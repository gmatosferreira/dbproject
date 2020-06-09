using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Funcionario
    {
        private int _nmec, _telemovel;
        private double _salario;
        private String _nome, _email;

        public Funcionario()
        {
        }
        public int nmec
        {
            get { return this._nmec; }
            set { this._nmec= value; }
        }

        public int telemovel
        {
            get { return this._telemovel; }
            set { this._telemovel= value; }
        }

        public double salario
        {
            get { return this._salario; }
            set { this._salario = value; }
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public void clone(Funcionario f)
        {
            this.nmec = f.nmec;
            this.telemovel = f.telemovel;
            this.salario = f.salario;
            this.nome = f.nome;
            this.email = f.email;
        }

    }
}
