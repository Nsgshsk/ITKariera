namespace ITKarieraTestM3
{
    public class FlowerStore
    {
        private string name;
        private List<Flower> flowerList;
        public FlowerStore(string name)
        {
            if (name.Length >= 6)
                this.name = name;
            else
                throw new ArgumentException("Invalid flower store name!");
            flowerList = new List<Flower>();

        }
        public string Name
        {

            get { return name; }

        }
        public List<Flower> FlowerList { get { return flowerList; } }
        public void AddFlower(Flower flower)
        {

            flowerList.Add(flower);

        }
        public bool SellFlower(Flower flower)
        {

            foreach (var item in flowerList)
            {
                if (flower.Type == flower.Type && flower.Color == flower.Color && flower.Price == flower.Price)
                {
                    flowerList.Remove(item);
                    return true;
                }
            }
            return false;

        }

        public double CalculateTotalPrice()
        {

            return flowerList.Sum(e => e.Price);

        }

        public Flower GetFlowerWithHighestPrice()
        {

            return flowerList.OrderByDescending(e => e.Price).First();

        }

        public Flower GetFlowerWithLowestPrice()
        {

            return flowerList.OrderBy(e => e.Price).First();

        }

        public void RenameFlowerStore(string newName)
        {

            if (newName.Length >= 6)
                this.name = newName;
            else
                throw new ArgumentException("Invalid flower store name!");

        }

        public void SellAllFlowers()
        {

            flowerList.Clear();

        }

        public override string ToString()
        {
            if (flowerList.Count == 0)
                return $"Flower store {name} has no available flowers.";
            string tmp = $"Flower store {name} has {flowerList.Count} flower/s:";
            foreach (var item in flowerList)
            {
                tmp += "\n" + item.ToString();
            }
            return tmp;
        }
    }
}
