using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx1
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size)
        {

        }

        public override string GetName()
        {
            return "Triangle";
        }

        public override double GetArea()
        {
            return Size * Size * Math.Sqrt(3) / 4;
        }
    }
}
