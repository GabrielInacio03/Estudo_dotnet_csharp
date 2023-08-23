using System;

namespace Secao11_Excecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = 20;
                int n2 = 0;

                int result = n1 / n2;
                System.Console.WriteLine($"Resultado: {result}");
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Erro DevideByZeroException");
            }
            catch(FormatException e)
            {
                System.Console.WriteLine($"FormatException: {e.Message}");
            }
        }
    }
}