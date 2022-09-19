using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx1
{
    public class Circle : IDrawable
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public void Draw()
        {
            double r_in = Radius - 0.4;
            double r_out = Radius + 0.4;

            for (double y = Radius; y >= -Radius; y--)
            {
                for (double x = Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
