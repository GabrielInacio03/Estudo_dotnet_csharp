using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao10_herancaEpolimorfismo.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } //titular
        public double Balance { get; protected set; } //saldo

        public Account(){}
        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;            
        }

        //Withdraw == saque, amount == quantia
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
        //deposito
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}