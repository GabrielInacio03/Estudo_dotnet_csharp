﻿// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Globalization;

namespace Secao06_MemoriaArraysListas // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			int n = int.Parse(Console.ReadLine());

			int[,] mat = new int[n, n];

			for(int i = 0; i < n; i++)
			{
				string[] values = Console.ReadLine().Split(' ');
				for(int j = 0; j < n; j++)
				{
					mat[i, j] = int.Parse(values[j]);
					System.Console.WriteLine(mat[i,j]);
				}
			}
			
			//System.Console.WriteLine("Ola Seção 06 - matrizes");
			
			//declarar matriz
			//double[,] mat = new double[2, 3]; // , indica que você ta criando um arranjo bidimensional com 2 linhas e 3 colunas

			//System.Console.WriteLine(mat.Length); //qtd de elementos a matriz tem no total

			//System.Console.WriteLine(mat.Rank); //primeira dimensão da matriz, que é a qtd de linhas

			//System.Console.WriteLine(mat.GetLength(0)); //dimensão 0 da matriz ela tem tamanho 2

			//System.Console.WriteLine(math.GetLength(1));

        }
	}
}