// See https://aka.ms/new-console-template for more information
using System;

namespace exercicio01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
           
            Console.WriteLine("Informe a largura e altura do seu retângulo!");
            
            Console.WriteLine("largura");
            r.Largura = double.Parse(Console.ReadLine());
        
            Console.WriteLine("altura");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = "+ r.Area());
            Console.WriteLine("PERÍMETRO = "+ r.Perimetro());
            Console.WriteLine("DIAGONAL = "+ r.Diagonal());


        }
    }
}