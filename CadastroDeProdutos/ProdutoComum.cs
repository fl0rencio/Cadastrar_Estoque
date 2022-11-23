using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadastroDeProdutos
{
    public class ProdutoComum
    {
        public string Nome { get; set; }
        public double Preco { get; protected set; }

        public ProdutoComum()
        {

        }

        public ProdutoComum(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + " (comum) , R$: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
