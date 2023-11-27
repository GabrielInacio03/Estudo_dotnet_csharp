using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao14_interfaces.Entities
{
    public class Rectangle : AbstractShape
    {
        public double With { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return With * Height;
        }
        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + With.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
