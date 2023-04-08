using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio01
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            var area = Largura * Altura;
            return area;
        }
        public double Perimetro(){
            var perimetro = 2*(Largura * Altura);
            return perimetro;
        }
        public double Diagonal(){
            var diagonal = Math.Sqrt(Largura * Largura + Altura * Altura);
            return diagonal;
        }
    }
}