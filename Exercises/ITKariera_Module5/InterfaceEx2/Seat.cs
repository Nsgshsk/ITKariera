using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Start()
        {
            return "Engine start!";
        }
        public string Stop()
        {
            return "Breaak!";
        }

        public override string ToString()
        {
            return String.Format("{0} Seat {1}.", Color, Model);
        }
    }
}
