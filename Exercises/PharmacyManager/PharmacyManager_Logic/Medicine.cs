namespace PharmacyManager_Logic
{
    internal class Medicine
    {
        private readonly string name;
        private readonly double price;
        internal Medicine(string name, double price)
        {
            if (name == null)
            {
                throw new ArgumentException("Invalid name");
            }
            else
            {
                this.name = name;
            }
            if (price <= 0)
            {
                throw new ArgumentException("Invalid price");
            }
            else
            {
                this.price = price;
            }
        }
        internal string Name { get { return name; } }
        internal double Price { get { return price; } }
        public override string ToString()
        {
            return $"Medicine: {name} with price {price:F2}";
        }
    }
}