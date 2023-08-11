using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao10_herancaEpolimorfismo.Entities
{
    public class BusinessAccount : Account
    {
		public double LoanLimite { get; set; }

		public BusinessAccount()
		{

		}
		public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //reaproveitando o construtor
		{			
			this.LoanLimite = loanLimit;
		}
		public void Loan(double amount) //emprestimo
		{
			if(amount <= LoanLimite)
				this.Balance += amount;
		}

	}
}