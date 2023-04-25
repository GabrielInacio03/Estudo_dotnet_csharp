using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioFixacao
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(){ }
        public Conta(int numero, string titular, double saldo) :  this()
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        public Conta(int numero, string titular) : this()
        {
            this.Numero = numero;
            this.Titular = titular;
        }

		public void AdicionarNoSaldo(double valor)
		{
			this.Saldo +=  valor;
		}
		public void RemoverNoSaldo(double valor)
		{
			this.Saldo -=  valor - 5;
		}
        public override string ToString()
        {
            return string.Format("Conta {0}, Titular: {1}, Saldo: $ {2}", this.Numero, this.Titular, this.Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}