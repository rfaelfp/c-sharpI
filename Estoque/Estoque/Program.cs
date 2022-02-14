using System;
using System.Globalization;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto " + p);

            while(true)
            {
                Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
                p.AdicionarProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados atualizados " + p);
                Console.WriteLine();
                Console.Write("Digite o numero de produtos a ser removido no estoque: ");
                p.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados atualizados " + p);
            }

        }
    }
}
