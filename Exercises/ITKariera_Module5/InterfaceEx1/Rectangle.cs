using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx1
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        public int Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; i++)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.WriteLine(mid);
            }
            Console.WriteLine(end);
        }
    }
}
