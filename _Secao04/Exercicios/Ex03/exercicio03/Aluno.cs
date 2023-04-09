using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio03
{
    public class Aluno
    {
        public string Nome;
        public double Media;
        public string Status;
        public void CalcularMedia(double n1, double n2, double n3)
        {
            Media = n1 + n2 + n3;
        }
        public void VerificarStatus()
        {
            if(Media >= 60.00)
                Status = "Aprovado";
            else
                Status = "Reprovado";
        }

        public override string ToString()
        {
            if(Status.Contains("Aprovado"))
            {
                return "APROVADO";
            } else 
            {
                double faltantes = 60.00 - Media;
                return "REPROVADO, FALTARAM "+ faltantes.ToString("F2", CultureInfo.InvariantCulture);
            }
            
        }
    }
}