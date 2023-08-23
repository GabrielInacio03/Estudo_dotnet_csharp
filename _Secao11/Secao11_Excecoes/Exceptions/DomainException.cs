using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao11_Excecoes.Exception
{
   public class DomainException : ApplicationException
   {
        public DomainException(string message) : base(message)
        {
            
        }
   }
}