using System;

namespace AppLogica // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("=== Bem vindo ao meu primeiro sistema ===");
            Console.WriteLine("==========================================");

            //var ex01 = new Exercicio01();
            //ex01.Inicio();
            
            Console.WriteLine("Digite um número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            var resultado = numero1 * 100;

            Console.WriteLine($"O resultado da operação é: {resultado}");

            Console.WriteLine("========== [Finalizando Sistema] ==========");
        }
    }
}