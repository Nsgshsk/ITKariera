namespace PharmacyManager_Logic
{
    internal class Pharmacy
    {
        private string name;
        private List<Medicine> medicineList;
        internal Pharmacy(string name)
        {
            if (name.Length <= 3 || name == null)
            {
                throw new ArgumentException("Invalid name");
            }
            else
            {
                this.name = name;
                medicineList = new List<Medicine>();
            }
        }
        internal string Name { get { return name; } }
        internal void Order(Medicine medicine)
        {
            medicineList.Add(medicine);
        }
        internal bool Sell(Medicine medicine)
        {
            if (medicine.Name == name)
            {
                return true;
            }
            return false;
        }
        internal double CalculateTotalPrice()
        {
            return medicineList.Sum(e => e.Price);
        }
        internal Medicine GetMedicineWithHighestPrice()
        {
            return medicineList.OrderByDescending(e => e.Price).First();
        }
        internal Medicine GetMedicineWithLowestPrice()
        {
            return medicineList.OrderBy(e => e.Price).First();
        }
        internal void RenamePharmacy(string newName)
        {
            if (newName.Length <= 3)
            {
                throw new ArgumentException("Invalid name");
            }
            else
            {
                name = newName;
            }
        }
        internal void SellAllMedicines()
        {
            medicineList.Clear();
        }
        public override string ToString()
        {
            string tmp = $"Pharmacy {name} has {medicineList.Count} medicines and they are:";
            if (medicineList.Count > 0)
            {
                foreach (var item in medicineList)
                {
                    tmp += "\n" + item.ToString();
                }
            }
            else
            {
                tmp += "\nN/A";
            }
            return tmp;
        }
    }
}
