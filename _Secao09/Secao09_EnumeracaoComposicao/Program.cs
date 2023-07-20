using System.Globalization;
using System.Text;
using System;
using Secao09_EnumeracaoComposicao.Models;
using Secao09_EnumeracaoComposicao.Enums;

namespace Secao09_EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Enumerações: é um tipo especial que serve par especificar de forma literal um conjunto de constantes relacionadas
                
                Vantagem é a melhor semântica, codigo mais legivel e auxiliado pelo compilador
                
                O enum é um tipo valor
            */   
            /*
                Composição: É um tipo de associação que permite que um objeto contenha outro. Exemplo

                Order e OrderItem: é uma relação de composição entre os objetos
            */

            Order order = new Order
                {
                    Id = 1080,
                    Moment = DateTime.Now,
                    Status = OrderStatus.PendingPayment
                };

            System.Console.WriteLine(order.ToString());


            string txt = OrderStatus.PendingPayment.ToString();
            System.Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>(txt);
            System.Console.WriteLine(os);
        }
    }
}