﻿using System;
using System.IO;

namespace Secao13_arquivos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com arquivos");

            /*
            File -> static members, um pouco mais lento, simples programa usa o file
            FileInfo -> instance members, mais rapido, sistemas grande e exige perfomrmace
            */

            string sourcePath = @"C:\workspace\Estudo_dotnet_csharp\_Secao13\Secao13_arquivos\arquivos\file1.txt";
            string targetPath = @"C:\workspace\Estudo_dotnet_csharp\_Secao13\Secao13_arquivos\arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    System.Console.WriteLine("Line: "+ line);
                }
            }
            catch(IOException e)
            {
                System.Console.WriteLine("An error occurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
