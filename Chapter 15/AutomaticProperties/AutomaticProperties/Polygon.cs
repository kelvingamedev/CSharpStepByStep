using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomaticProperties
{
    class Polygon
    {
        public int NumSides { get; set; }
        public double SideLenght { get; set; }
        
        public Polygon()
        {
            this.NumSides = 4;
            this.SideLenght = 10.0;
        }

    }
}
