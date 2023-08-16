using System;
using Secao10_herancaEpolimorfismo.Entities;

namespace Secao10_herancaEpolimorfismo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001,"Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

			global::System.Console.WriteLine(acc1.Balance);
            global::System.Console.WriteLine(acc2.Balance);
            /*Herança e Polimorfismo*/
            /*
                Herança: É um tipo de associação que permite que uma classe herde dados e comportamentos de outra. A vantagem é o reuso e polimorfismo. Sintaxe: : e base (referenciar a superclasse)
            */
            //casting -> converter de um tipo para o outro
            //Upcasting -> convertendo um objeto para uma variavel subclasse para superclasse, uso comum do polimorfismo
            //Downcasting -> da superclasse para a subclasse

            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            ////UPCASTING 
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            //DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount)acc2; //casting
            //acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; //casting //erro
            //if(acc3 is BusinessAccount) //verificando se a varivel é do tipo de uma classe especifica
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3; //casting //erro
            //    BusinessAccount acc5 = acc3 as BusinessAccount; //casting
            //    acc5.Loan(200.0);
            //    System.Console.WriteLine("LOAN!!!!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    System.Console.WriteLine("FIZ UM UPDATE");
            //}

        }
    }
}