using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;
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
        public int Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
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
            return String.Format("{0} Tesla {1} with {2} batteries.", Color, Model, Battery);
        }
    }
}
