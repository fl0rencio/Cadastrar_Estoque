using System.Globalization;
using System.Collections.Generic;



namespace CadastroDeProdutos
{
    class Program
    {

       


        public static void Main(string[] args)
        {
            List<ProdutoComum> lista = new List<ProdutoComum>();
            Console.Write("Digite o numero de produtos que deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto # {i} ");
                Console.Write("O produto é comum usado ou importado? (c / u / i ): ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine();    

                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine();

                if(ch == 'i' || ch == 'I')
                {
                    
                    Console.Write("Digite a taxa da alfandega: ");
                    double taxa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome,preco,taxa));
                    Console.WriteLine();
                }
                else if(ch == 'u' || ch == 'U')
                {
                    
                    Console.Write("Digite a data de fabricaçao (DD/MM/AAA) :");
                    DateOnly d1 = DateOnly.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome,preco,d1));
                    Console.WriteLine();
                }
                else
                {
                    lista.Add(new ProdutoComum (nome, preco));
                }

                
            }

            Console.WriteLine();
            Console.WriteLine("Tabela de preços");

            foreach (ProdutoComum prod in lista)
            {
                Console.WriteLine(prod.ToString());
            }
        }
    }
}