using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao09_EnumeracaoComposicao.Enums;

namespace Secao09_EnumeracaoComposicao.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}