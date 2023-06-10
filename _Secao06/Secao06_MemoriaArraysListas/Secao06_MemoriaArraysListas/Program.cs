// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Globalization;

namespace Secao06_MemoriaArraysListas // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 O struct tem como objetivo estruturar alguns dados comuns a um mesmo contexto, 
			  bem parecida com a ideia de classes
			 */
			Point p; //tipo valor, a simples declaração ja sera criada as caixinhas na memoria.
			p.X = 10;
			p.Y = 20;


			double? x = null; //permite nulo no tipo valor (Nullable<double> ou double?)
			double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //pega o valor do x ou se não existir o valor padrõa, nesse caso o padrão seria 0
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //verifica se a variavel possui valor, retornando true ou false
            Console.WriteLine(y.HasValue);

			
            Console.WriteLine((x.HasValue) ? x.Value : "x is null");
            Console.WriteLine((y.HasValue) ? y.Value : "y is null");

			//operador de coalescência nula
			double? x2 = null;
			double? y2 = x ?? 0.00; //se o valor de x não for nulo o y recebe o x, se não ele recebe o valor 0.00

			//vetor
			double[] vetorDouble = new double[3];
			vetorDouble[0] = 1.72;
			vetorDouble[1] = 1.56;
			vetorDouble[2] = 1.80;

            Console.WriteLine("Trabalhando com vetores");
			for (int i = 0; i < vetorDouble.Length; i++)
			{
                Console.WriteLine(i + " - " + vetorDouble[i].ToString("F2"));
            }
            Console.WriteLine(p);


            Console.WriteLine("======= Vetor parte 2 =======");
			//tipo referencia o padrão é nulo
			int n = int.Parse(Console.ReadLine());

			Product[] products = new Product[n];
			double? media = 0.00;
			for (int i = 0; i < n; i++)
			{
                string name = Console.ReadLine();
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				products[i] = new Product { Name = name, Price = price };
				media += products[i].Price;
            }

			media = media / products.Length;

            Console.WriteLine("A média de preço dos produtos é de: R$"+ media);



			/*
			 * Boxing -> é o processo de conversão de um objetio tipo valor para um objeto tipo referência compativel
			 
			int x = 20;
			Object obj = x; de stack vai para o apontamento heap memory
			 
			 */

			/*
			 Unboxing -> é o contrário do Boxing
			 */


			//foreach paara cada objeto contifo em vect, faça:
			//string[] vect = new string[] { "Maria", "Bob", "João" };

			//foreach (string v in vect)
			//{
			//	Console.WriteLine(v);
			//}

			List<string> list = new List<string>();
			list.Add("Gabriel Inácio");
			list.Add("Gabriel Ramos");
			list.Add("Alex");
			list.Add("Ana");
			list.Add("Maria");

			//insert a diferença para o add é q nele vc pode definir a posição
			list.Insert(2, "Marco");

			foreach (string item in list)
			{
                Console.WriteLine(item);
            }
        }
	}
}