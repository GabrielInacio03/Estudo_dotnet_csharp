// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
namespace Secao04_ClassesAtributosMetodosMembrosEstaticos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados da primeira funcionário: ");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda funcionário: ");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());

            double salMedio = (f1.Salario + f2.Salario) / 2.00;

            Console.WriteLine("Salário médio = "+ salMedio);
        }
    }
}