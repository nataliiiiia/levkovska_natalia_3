using System;
using System.Collections.Generic;

namespace laba3s2
{
     class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();
            Console.Clear();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("Task1");
            Hours hr = new();
            Minutes min = new();
            hr.Hour = int.Parse(Console.ReadLine());
            min.Minute = int.Parse(Console.ReadLine());
            Day day = new() { minutes = min.Minute, hours = hr.Hour };
            Console.WriteLine(day.ToString());
            Console.WriteLine(day.DayTime());   
        }
        static void Task2()
        {
            Tariff tariff1 = new ("Комфорт", 12, 7500, 150);
            Tariff tariff2 = new ("Оптимум", 15, 6000, 175);
            Tariff tariff3 = new ("Економ", 5, 2300, 120);
            Tariff tariff4 = new ("Премiум", 25, 9600, 230);
            List<Tariff> ListOfTariffes = new List<Tariff>(){tariff1, tariff2, tariff3, tariff4};
            ListOfTariffes.Sort();
            ListOfTariffes.ForEach(t => Console.WriteLine(t.PackageInfo()));
            ListOfTariffes.ForEach(t => Console.WriteLine(t.Clients()));
            FindPerfectTariff(ListOfTariffes);

        }
        static void FindPerfectTariff(List<Tariff> ListOfTariffes)
        {
            Console.WriteLine("Введiть мiнiмальний об'єм трафiку: ");
            int minTraffic = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть максимальний об'єм трафiку: ");
            int maxTraffic = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть мiнiмальну цiну: ");
            int minPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть максимальну цiну: ");
            int maxPrice = int.Parse(Console.ReadLine());
            PerfectTarriffList perfectTarriffList = new(ListOfTariffes, minTraffic, maxTraffic, minPrice, maxPrice);
            Console.WriteLine(perfectTarriffList.FindPerfectTariff());
        }

     }
}
