using System.Globalization;
using System.Text;
using System;

namespace Secao06_MemoriaArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //inferir no tipo das variáveis
            var x = 10;
            var y = "o valor é uma string";

            //estrutura switch-case

            int isBoy = 1;

            switch (isBoy)
            {
                case 1:
                    System.Console.WriteLine("é menino");
                    break;
                case 2:
                    System.Console.WriteLine("é menina");
                    break;
                default:
                    System.Console.WriteLine("é gemeos");
                    break;
            }


            //ternário -> quando se deseja decidir um valor com base em uma condição

            var ten = (2 > 4) ? "verdadeiro" : "falso";

            //funções básicas de string
            string nomeCompleto = "Gabriel da Silva Inácio";

            nomeCompleto = nomeCompleto.ToLower(); //letras minusculas
            nomeCompleto = nomeCompleto.ToUpper(); //letras maiusculas
            
            int indice = nomeCompleto.IndexOf('G'); 

            string sobrenome = nomeCompleto.Substring(6 + 1);
            System.Console.WriteLine("sobrenome: "+ sobrenome);
            System.Console.WriteLine(------------);
            System.Console.WriteLine("Datetime");

            //datetime. tickes -> nanosegundos
            DateTime d1 = DateTime.Now;
            
            System.Console.WriteLine(d1);

            //determinar formato
            DateTime d2 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            System.Console.WriteLine(d2);


            System.Console.WriteLine("--------------");
            System.Console.WriteLine("TimeSpan");
            //Um objeto timespan internamente armazena uma duração na forma de tcks(100 nanosegundos)

            TimeSpan t1 = new TimeSpan(0, 1, 30);//hora,minuto e segundos
            System.Console.WriteLine(t1);
            System.Console.WriteLine(t1.Ticks);
        }
    }
}