// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace exercicio02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("======== Exercicio 02 ========");
            Console.WriteLine("==============================");

            Funcionario f = new Funcionario();
            f.Imposto = 1000.00;
            f.SalarioBruto = 6000.00;

            Console.WriteLine();
            Console.WriteLine("Informe seu nome");
            f.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Funcionário: "+ f.Nome + ", $ "+ f.SalarioLiquido());

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(porcen);

            Console.WriteLine(f.ToString());
        }
    }
}
