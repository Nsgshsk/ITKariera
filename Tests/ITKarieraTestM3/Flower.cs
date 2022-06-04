namespace ITKarieraTestM3
{
    public class Flower
    {
        private string type;
        private string color;
        private double price;
        public Flower(string type, string color, double price)
        {

            this.type = type;
            this.color = color;
            if (price <= 100)
                this.price = price;
            else
                throw new ArgumentException("Invalid flower price!");

        }

        public string Type
        {

            get { return type; }

        }

        public string Color
        {

            get { return color; }

        }

        public double Price
        {

            get { return price; }

        }

        public override string ToString()
        {

            return $"Flower {type} with color {color} costs {price:F2}";

        }
    }
}
