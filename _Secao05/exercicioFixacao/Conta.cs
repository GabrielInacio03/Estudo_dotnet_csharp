using System;
using System.Collections.Generic;
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
        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}