using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogica
{
	internal class Exercicio01
	{
		public void Inicio()
		{
			Console.WriteLine("Informação dos Nomes");
			Console.WriteLine("");

			Console.WriteLine("Digite os nome (separados por virgula)");
			string nomes = Console.ReadLine();

			Console.WriteLine("Digite os sobrenomes (serpados por virgula)");
			string sobrenomes = Console.ReadLine();

			string[] vetorNomes = nomes.Split(",");
			string[] vetorSobrenomes = sobrenomes.Split(",");

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"{vetorNomes[i]} {vetorSobrenomes[i]}");
			}
		}
		
	}
}
