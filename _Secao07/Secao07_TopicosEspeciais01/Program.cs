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
            System.Console.WriteLine("------------");
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

            System.Console.WriteLine("--------------");
            DateTime dbase = new DateTime(2023, 07, 12, 11, 30, 58, 275);

            System.Console.WriteLine(dbase);
            System.Console.WriteLine("1) Date: "+ dbase.Date);
            System.Console.WriteLine("2) Day: "+ dbase.Day);
            System.Console.WriteLine("3) DayOfWeek: "+ dbase.DayOfWeek);
            System.Console.WriteLine("4) DayOfYear: "+ dbase.DayOfYear);
            System.Console.WriteLine("5) Hour: "+ dbase.Hour);
            System.Console.WriteLine("6) Kind: "+ dbase.Kind);
            System.Console.WriteLine("7) Millsecond: "+ dbase.Millisecond);
            System.Console.WriteLine("8) Minute: "+ dbase.Minute);
            System.Console.WriteLine("9) Month: "+ dbase.Month);
            System.Console.WriteLine("10) Second: "+ dbase.Second);
            System.Console.WriteLine("11) Ticks: "+ dbase.Ticks);
            System.Console.WriteLine("12) TimeOfDay: "+ dbase.TimeOfDay);
            System.Console.WriteLine("13) Year: "+ dbase.Year);

            System.Console.WriteLine(dbase.ToString("yyyy-MM-dd"));

            string s1 = dbase.ToLongDateString();
            System.Console.WriteLine(s1);

            System.Console.WriteLine("--------------");
            //System.Console.WriteLine(dbase.ToLocalTime());
            //ISO 8601 -> yyyy-MM-ddTHH:mm:ssZ
        }
    }
}