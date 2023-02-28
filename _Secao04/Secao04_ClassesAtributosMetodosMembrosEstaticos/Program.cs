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
            
            p.Nome = "TV";
            p.Preco = 900.00;
            p.Quantidade = 10;

            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());

            Console.WriteLine("Digite u número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtd);

            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int qtd_retirar = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd_retirar);
            
            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());
        }
    }
}
