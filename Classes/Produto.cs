using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto.Classes
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, int quantidade, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double QuantidadeEmEstoque()
        {
            return Quantidade * Preco;

        }

        public override string ToString()
        {
            return _nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + QuantidadeEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


    }
}
