using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Pessoa
    {
        private int _nmec, _telemovel;
        private String _nome, _email;

        public Pessoa()
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

        public String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_nmec.ToString());
            sb.Append(" (");
            sb.Append(_nome);
            sb.Append(")");
            return sb.ToString();

        }

        public String str
        {
            get { return this.ToString(); }
        }
    }
}
