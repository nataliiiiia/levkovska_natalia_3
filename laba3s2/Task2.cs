using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3s2
{
    internal class Tariff : IComparable<Tariff>
    {
        private int numberofclients;
        private double price;
        internal string Name { get; set; }
        internal int Traffic { get; set; }
        internal int NumberOfClients
        {
            get { return numberofclients; }
            set
            {
                if (value > 0)
                {
                    numberofclients = value;
                }
                else numberofclients = value * (-1);
            }
        }
        internal double Price
        {
            get { return price; }
            set
            {
                if(value > 0)
                    price = value;
                else price = value *(-1);
            }
        }
        internal Tariff(string Name, int Traffic, int NumberOfClients, double Price)
        {
            this.Name = Name;
            this.Traffic = Traffic;
            this.NumberOfClients = NumberOfClients;
            this.Price = Price;
        }
        internal string PackageInfo()
        {
            return $"Назва: {Name}, Об'єм трафiку: {Traffic}Гб, Клiєнти: {NumberOfClients}, Цiна: {Price} грн";
        }
        public int CompareTo(Tariff tariff)
        {
            if (this.Traffic < tariff.Traffic)
            {
                return 1;
            }
            else return -1;
        }
        internal string Clients()
        {
            return $"Кiлькiсть клiєнтiв для тарифу \"{Name}\": {NumberOfClients} ";
        }
    }
    internal class PerfectTarriffList
    {
        internal List<Tariff> TariffsList;
        int mintraffic;
        internal int MinTraffic
        {
            get { return mintraffic; }
            set
            {
                if (value > 0) mintraffic = value;
                else mintraffic = value * (-1);
            }
        }
        int maxtraffic;
        internal int MaxTraffic
        {
            get { return maxtraffic; }
            set
            {
                if (value > 0) maxtraffic = value;
                else maxtraffic = value * (-1);
            }
        }
        int minprice;
        internal int MinPrice
        {
            get { return minprice; }
            set
            {
                if (value > 0) minprice = value;
                else minprice = value * (-1);
            }
        }
        int maxprice;
        internal int MaxPrice
        {
            get { return maxprice; }
            set 
            {
                if (value > 0) maxprice = value;    
                else maxprice = value * (-1);
            }
        }
        internal string FindPerfectTariff()
        {
            string result = "";
            List<Tariff> PerfectTariff = TariffsList.FindAll
                (t => t.Traffic >= MinTraffic && t.Traffic <= MaxTraffic && t.Price >= MinPrice && t.Price <= MaxPrice);
            if (PerfectTariff.Count != 0)
            {

                foreach (Tariff t in PerfectTariff)
                {
                    string s = t.Name;
                    result = result + s + ", ";
                }
                result = $"Ваш iдеальний тариф: {result}";
            }
            else result = "На жаль, бажаного тарифу нема.";
            return result;
        }
        internal PerfectTarriffList(List<Tariff> TariffsList, int MinTraffic, int MaxTraffic, int MinPrice, int MaxPrice)
        {
            this.TariffsList = TariffsList;
            this.MinTraffic = MinTraffic;
            this.MaxTraffic = MaxTraffic;
            this.MinPrice = MinPrice;
            this.MaxPrice = MaxPrice;
        }
    }

}
