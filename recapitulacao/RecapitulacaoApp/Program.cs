using System;

namespace RecapitulacaoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //bool cond1 = a < 10; //false
            //bool cond2 = a < 20; //true
            //bool cond3 = a > 10; //false
            //bool cond4 = a > 5;  //true

            //Console.WriteLine(cond1);
            //Console.WriteLine(cond2);
            //Console.WriteLine(cond3);
            //Console.WriteLine(cond4);
            //Console.WriteLine("------------------");

            //bool cond5 = a <= 10; //true
            //bool cond6 = a >= 10; //true
            //bool cond7 = a == 10; //true
            //bool cond8 = a != 10; //false

            //Console.WriteLine(cond5);
            //Console.WriteLine(cond6);
            //Console.WriteLine(cond7);
            //Console.WriteLine(cond8);

            //Console.WriteLine("------------------");
            
            //bool c1 = 2 > 3 || 4 != 5; //true
            //bool c2 = !(2 > 3) && 4 != 5; //true
            //bool c3 = 10 < 5;
            //bool c4 = c1 || c2 && c3; // true
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            //Console.WriteLine("------------------");
            //var data = DateTime.Now;

            //Console.WriteLine("Data Atual: "+ data);
            //if(data.Hour < 12)
            //{
            //    Console.WriteLine("Bom dia");
            //} else if(data.Hour >= 12 && data.Hour < 18)
            //{
            //    Console.WriteLine("Boa Tarde");
            //} else
            //{
            //    Console.WriteLine("Boa Noite");
            //}              

            //Console.WriteLine("------------------");

            //funções exemplos

            //Console.WriteLine("Digite três número:");
            //string resposta = Console.ReadLine();

            //string[] vetor = resposta.Split(" ");
            //int n1 = int.Parse(vetor[0]);
			//int n2 = int.Parse(vetor[1]);
			//int n3 = int.Parse(vetor[2]);

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine("Maior valor -> " + resultado);
		
            Console.WriteLine("------------------------");
            var raiz = 0.00;

            while (raiz >= 0)
            {
                System.Console.WriteLine("Digite um Número");
                var valor = double.Parse(Console.ReadLine());
                raiz = Math.Sqrt(valor);
                System.Console.WriteLine(valor);
            }

            System.Console.WriteLine("valor negativo "+ raiz);


            int tabuada = 5;
            for(int i = 0; i <= 10; i++)
			{
				Console.WriteLine(tabuada + "X"+ i + "= "+ (tabuada*i));
			}
        
        }
        public static double Maior(int n1, int n2, int n3)
        {
            double resultado = 0;
			if (n1 > n2 && n1 > n3)
			{
                resultado = n1;
			}
			else if (n2 > n3)
			{
				resultado = n2;
			}
			else
			{
				resultado = n3;
			}

            return resultado;
		}
    }
}