using Secao05_ConstrutoresThisSobrecargaEncapsulamento;
using System;
using System.Globalization;

namespace Secao05 // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==============================");
			Console.WriteLine("========== SEÇÃO 05 ==========");
			Console.WriteLine("==============================");

            //Sintaxe Alternativa para inicializar valores
            Produto p2 = new Produto
            {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0
            };

			Produto p;
			

            Console.WriteLine("Entrando com os dados do produto:");
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("Digite a quantidade em estoque");
            int quantidade = int.Parse(Console.ReadLine());

			p = new Produto(nome, preco, quantidade);

			Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite u número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtd);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int qtd_retirar = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd_retirar);

            Console.WriteLine("Dados do produto: " + p);
        }
	}
}