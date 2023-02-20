// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
namespace Secao04_ClassesAtributosMetodosMembrosEstaticos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iniciando POO
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de x = "+ areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = "+ areaY.ToString("F4", CultureInfo.InvariantCulture));

            if( areaX > areaY){
                Console.WriteLine("Área X é a maior");
            } else if( areaX < areaY){
                Console.WriteLine("Área Y é a maior");
            } else{
                Console.WriteLine("Áreas com tamanhos iguais");
            }
        }
    }
}