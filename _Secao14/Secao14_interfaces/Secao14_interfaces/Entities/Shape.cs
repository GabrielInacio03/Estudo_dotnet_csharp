﻿using Secao14_interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao14_interfaces.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
