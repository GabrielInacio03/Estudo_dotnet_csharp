﻿// See https://aka.ms/new-console-template for more information
using System.Drawing;

namespace Secao06_MemoriaArraysListas // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 O struct tem como objetivo estruturar alguns dados comuns a um mesmo contexto, 
			  bem parecida com a ideia de classes
			 */
			Point p; //tipo valor, a simples declaração ja sera criada as caixinhas na memoria.
			p.X = 10;
			p.Y = 20;


			double? x = null; //permite nulo no tipo valor (Nullable<double> ou double?)
			double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //pega o valor do x ou se não existir o valor padrõa, nesse caso o padrão seria 0
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //verifica se a variavel possui valor, retornando true ou false
            Console.WriteLine(y.HasValue);

			
            Console.WriteLine((x.HasValue) ? x.Value : "x is null");
            Console.WriteLine((y.HasValue) ? y.Value : "y is null");

			//operador de coalescência nula
			double? x2 = null;
			double? y2 = x ?? 0.00; //se o valor de x não for nulo o y recebe o x, se não ele recebe o valor 0.00

            Console.WriteLine(p);
        }
	}
}