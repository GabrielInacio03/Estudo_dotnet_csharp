using System;

namespace RecapitulacaoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool cond1 = a < 10; //false
            bool cond2 = a < 20; //true
            bool cond3 = a > 10; //false
            bool cond4 = a > 5;  //true

            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);
            Console.WriteLine(cond4);
            Console.WriteLine("------------------");

            bool cond5 = a <= 10; //true
            bool cond6 = a >= 10; //true
            bool cond7 = a == 10; //true
            bool cond8 = a != 10; //false

            Console.WriteLine(cond5);
            Console.WriteLine(cond6);
            Console.WriteLine(cond7);
            Console.WriteLine(cond8);
        }
    }
}