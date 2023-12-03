using Secao15_generics_set_dictionary.Entities;
using System;

namespace Secao15_generics_set_dictionary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedSet mantem os elementos ordenados
           SortedSet<int> a = new SortedSet<int>()
           {
               0,2,4,5,6,8,10
           };
           SortedSet<int> set = new SortedSet<int>()
           {
               5,6,7,8,9,10
           };
            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(set);

            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(set); //elementos q existem nos dois conjuntos

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(set); //elementos de A excluido aqueles elementos de B
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}