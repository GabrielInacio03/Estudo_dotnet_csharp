using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao06_MemoriaArraysListas
{
    public class Calculator
    {
        //1 função apenas
        //chamada -> int result = Calculator.Sum(10,20,30,40);
        //modificador de parametro params, com isso n é necessario declarar a instancia new int[] na chamada
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //3 sobrecargas
        //public static int Sum(int n1, int n2) { return  n1 + n2; }
        //public static int Sum(int n1, int n2, int n3) { return n1 + n2 + n3; }
        //public static int Sum(int n1, int n2, int n3, int n4) { return n1 + n2 + n3 + n4; }
    }
}
