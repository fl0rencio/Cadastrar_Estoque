using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CadastroDeProdutos
{
    public class ProdutoUsado : ProdutoComum
    {
        public DateOnly Data { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateOnly data) : base(nome,preco)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Nome} (usado) R$: {Preco.ToString("F2", CultureInfo.InvariantCulture)}, (data de fabricação: {Data})";
        }
    }
}
