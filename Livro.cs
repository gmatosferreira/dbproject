using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Livro
    {
        private String _ISBN, _titulo, _autores, _editora;
        private int _anoEdicao, _idinterno;
        private LivroEstado _estado;

        public Livro() { }

        public String ISBN
        {
            get { return this._ISBN; }
            set { this._ISBN = value; }
        }

        public String titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public String autores
        {
            get { return this._autores; }
            set { this._autores = value; }
        }

        public String editora
        {
            get { return this._editora; }
            set { this._editora= value; }
        }

        public int anoedicao
        {
            get { return this._anoEdicao; }
            set { this._anoEdicao = value; }
        }

        public int idinterno
        {
            get { return this._idinterno; }
            set { this._idinterno  = value; }
        }

        public LivroEstado estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }
    }
}
