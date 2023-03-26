// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
namespace Secao04_ClassesAtributosMetodosMembrosEstaticos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();
            
            //p.Nome = "TV";
            //p.Preco = 900.00;
            //p.Quantidade = 10;

            Console.WriteLine("Digite o nome do produto");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em estoque");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: ", p.ToString());

            Console.WriteLine("Digite u número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtd);

            Console.WriteLine("Dados do produto: ", p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int qtd_retirar = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd_retirar);
            
            Console.WriteLine("Dados do produto: ", p);
        }
    }
}
