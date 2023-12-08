// See https://aka.ms/new-console-template for more information
using lambdaDelegatesLinq.Services;

namespace lambdaDelegatesLinq // Note: actual namespace depends on the project name.
{
    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a,b);
            
        }
    }
}