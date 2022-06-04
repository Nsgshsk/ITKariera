using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManager_Logic
{
    public static class Manager_Logic
    {
        private static List<Pharmacy> pharmacies = new List<Pharmacy>();
        private static Dictionary<string, Medicine> medicineDict = new Dictionary<string, Medicine>();
        public static string AddMedicine(string name, double price)
        {
            if (medicineDict.ContainsKey(name)) /*"no"*/;
            else if (name != null)
                medicineDict.Add(name, new Medicine(name, price));
            else
                throw new ArgumentException("Invalid name");
            return medicineDict[name].ToString();
        }
        public static void CreatePharmacy(string name)
        {
            pharmacies.Add(new Pharmacy(name));
        }
        public static void Order(string nameM, string nameP)
        {
            pharmacies.Find(e => e.Name == nameP).Order(medicineDict[nameM]);
        }
        public static bool Sell(string nameM, string nameP)
        {
            return pharmacies.Find(e => e.Name == nameP).Sell(medicineDict[nameM]);
        }
        public static double CalculateTotalPrice(string name)
        {
            return pharmacies.Find(e => e.Name == name).CalculateTotalPrice();
        }
        public static void RenamePharmacy(string name, string newName)
        {
            pharmacies.Find(e => e.Name == name).RenamePharmacy(newName);
        }
        public static void SellAllMedicines(string name)
        {
            pharmacies.Find(e => e.Name == name).SellAllMedicines();
        }
        public static void GetMedicineWithHighestPrice(string name)
        {
            pharmacies.Find(e => e.Name == name).GetMedicineWithHighestPrice();
        }
        public static void GetMedicineWithLowestPrice(string name)
        {
            pharmacies.Find(e => e.Name == name).GetMedicineWithLowestPrice();
        }
    }
}
