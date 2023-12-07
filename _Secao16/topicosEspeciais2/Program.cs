using System;
using topicosEspeciais2.Extensions;

namespace topicosEspeciais2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension methods");

            DateTime dt = new DateTime(2023, 12, 07, 8, 10, 45);
            System.Console.WriteLine(dt.ElapsedTime());
        }
    }
}