// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace Secao04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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