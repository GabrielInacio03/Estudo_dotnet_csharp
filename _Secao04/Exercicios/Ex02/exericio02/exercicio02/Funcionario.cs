using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio02
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            //code...
            SalarioBruto =SalarioBruto + ( SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return "Dados atualizados: "+ Nome + ", $ "+ SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}