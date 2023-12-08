using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace lambdaDelegatesLinq.Entities
{
    public class Product
    {        
        public string Name { get; set; }
        public double price { get; set; }

        public Product(string name, double price) 
        {
            this.Name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return Name + ", "+ price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}