using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao10_herancaEpolimorfismo.Entities
{
    public class SavingsAccount : Account
    {
        public double interestRate { get; set; } //taxa de juros

        public SavingsAccount(){}
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }
        public void UpdateBalance()
        {
            this.Balance = this.Balance * this.interestRate;
        }
        public override void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
    }
}