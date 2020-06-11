using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Requisicao
    {
        private Livro _livro;
        private Pessoa _pessoa;
        private DateTime _dataRequisicao, _dataEntrega;
        private bool _entregue;

        public Requisicao() { }

        public Livro livro
        {
            get { return this._livro; }
            set { this._livro = value; }
        }

        public Pessoa pessoa
        {
            get { return this._pessoa; }
            set { this._pessoa = value; }
        }

        public DateTime dataRequisicao
        {
            get { return this._dataRequisicao; }
            set { this._dataRequisicao = value; }
        }

        public DateTime dataEntrega
        {
            get { return this._dataEntrega; }
            set { this._dataEntrega = value; }
        }

        public bool entregue
        {
            get { return this._entregue; }
            set { this._entregue = value; }
        }

        
        // 
        public String estado
        {
            get
            {
                if (_entregue)
                    return "Entregue";
                else
                {
                    if (dataEntrega < DateTime.Today)
                        return "EM ATRASO";
                }
                return "Emprestado";
            }
        }

        public String dataRequisicaoStr
        {
            get { return String.Format("{0:dd/MM/yyyy}", _dataRequisicao); }
        }

        public String dataEntregaStr
        {
            get { return String.Format("{0:dd/MM/yyyy}", _dataEntrega); }
        }

    }
}
