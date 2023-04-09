// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace exercicio03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("======== Exercicio 03 ========");
            Console.WriteLine("==============================");

            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            string notas = Console.ReadLine();

            //dividindo notas
            string[] vetor = notas.Split(" ");
            
            a.CalcularMedia(double.Parse(vetor[0], CultureInfo.InvariantCulture), double.Parse(vetor[1], CultureInfo.InvariantCulture), double.Parse(vetor[2], CultureInfo.InvariantCulture));

            Console.WriteLine("NOTA FINAL = "+ a.Media.ToString("F2", CultureInfo.InvariantCulture));

            a.VerificarStatus();

            Console.WriteLine(a.ToString());
        }
    }
}
