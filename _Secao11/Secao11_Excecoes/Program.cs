using System;
using System.IO;

namespace Secao11_Excecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {                
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"Erro File: {e.Message}");
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}