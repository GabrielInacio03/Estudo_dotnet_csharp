namespace Secao06_MemoriaArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //inferir no tipo das variáveis
            var x = 10;
            var y = "o valor é uma string";

            //estrutura switch-case

            int isBoy = 1;

            switch (isBoy)
            {
                case 1:
                    System.Console.WriteLine("é menino");
                    break;
                case 2:
                    System.Console.WriteLine("é menina");
                    break;
                default:
                    System.Console.WriteLine("é gemeos");
                    break;
            }


            //ternário -> quando se deseja decidir um valor com base em uma condição

            var ten = (2 > 4) ? "verdadeiro" : "falso";
        }
    }
}