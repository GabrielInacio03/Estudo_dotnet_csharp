// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine(p);
        }
	}
}