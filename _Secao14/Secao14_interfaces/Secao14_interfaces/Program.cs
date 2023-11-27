using System;
using System.Globalization;
using Secao14_interfaces.Entities;
using Secao14_interfaces.Services;

namespace Secao14_interfaces // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Radius = 2.0,
                Color = Enums.Color.White
            };
            IShape s2 = new Rectangle()
            {
                With = 3.5,
                Height = 4.2,
                Color = Enums.Color.Black
            };

            Console.WriteLine("Figura S1: "+ s1.ToString());
            Console.WriteLine("Figura S2: " + s2.ToString());
        }
    }
}