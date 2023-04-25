using System;
using System.Globalization;

namespace exercicioFixacao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================  EXERCÍCIOS DE FIXAÇÃO ================");
            Conta conta;

            System.Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.Write("Haverá depósito inicial (s/n)?");
            char temDeposito = char.Parse(Console.ReadLine());

            System.Console.WriteLine();
            double valorSaldo = 0.00;
            
            if(temDeposito == 's')
            {
                System.Console.Write("Entre com o valor de depósito inicial: ");
                valorSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            conta = new Conta(numConta, titular, valorSaldo);

            System.Console.WriteLine("Dados da Conta: ");
            System.Console.WriteLine(conta.ToString());

            System.Console.Write("Entre com um valor para depósito: ");
            double novoSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.AdicionarNoSaldo(novoSaldo);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta atualizadas:");
            System.Console.WriteLine(conta.ToString());

            System.Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.RemoverNoSaldo(saque);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta.ToString());
        }
    }
}