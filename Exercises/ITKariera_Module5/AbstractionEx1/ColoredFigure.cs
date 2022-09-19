using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx1
{
    public abstract class ColoredFigure
    {
        private string color;
        private double size;
        public string Color
        {
            get { return color; }
            set { if (value != String.Empty) color = value; }
        }
        public double Size
        {
            get { return size; }
            set { if (value > 0) size = value; }
        }
        public ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine($"{GetName()}:\nColor: {color}\nSize: {size:F2}\nArea: {GetArea():F2}");
        }

        public abstract string GetName();
        public abstract double GetArea();
    }
}
