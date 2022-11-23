using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadastroDeProdutos
{
    public class ProdutoImportado : ProdutoComum
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco,double taxaAlfandega) : base(nome,preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }


        public  double  PrecoTotal()
        {
          return  Preco + TaxaAlfandega;
        }

        public override string ToString()
        {
            return Nome + " (importado) , R$: " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) + $", (taxa da alfandega: R$ {TaxaAlfandega.ToString("F2",CultureInfo.InvariantCulture)}) " ;
        }
    }
}
