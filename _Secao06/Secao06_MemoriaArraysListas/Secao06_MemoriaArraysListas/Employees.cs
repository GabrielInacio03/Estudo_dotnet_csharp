using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao06_MemoriaArraysListas
{
    public class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Salary { get; set; }

        public static List<string> lista = new List<string>();


        public Employees() { }
        public Employees(int id, string? name, double? salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void GetEmployeesForId(int id)
        {
            var valor = lista.FindIndex(x => x[0] == id);

            Console.WriteLine("Resultado da Pesquisa");
        }
    }
}
