// See https://aka.ms/new-console-template for more information
using lambdaDelegatesLinq.Entities;
using lambdaDelegatesLinq.Services;

namespace lambdaDelegatesLinq // Note: actual namespace depends on the project name.
{
    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.90));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.price >= 100.00);
            //o Predicate é um delegate, ou seja, uma referencia para uma função
            //list.RemoveAll(ProductTest);

            //recebe product e retorna string
            //Func<Product, string> func = NameUpper;

            //lambda
            Func<Product, string> func = p => p.Name.ToUpper();
            List<string> result = list.Select(func).ToList();
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        public static bool ProductTest(Product p)
        {
            return p.price >= 100;
        }
    }
}