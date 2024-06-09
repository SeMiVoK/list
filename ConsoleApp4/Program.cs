using System;
using System.Collections.Generic;

namespace CityRegistry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>
            {
                new City("Город 1"),
                new City("Город 2"),
                new City("Город 3")
            };

            foreach (var city in cities)
            {
                city.Buildings.Add(new Building("Улица 1", "1", 100));
                city.Buildings.Add(new Building("Улица 2", "2", 200));
                city.Buildings.Add(new Building("Улица 3", "3", 150));
            }

            Console.WriteLine("Минимальное количество экземпляров класса «город»: " + cities.Count);
            foreach (var city in cities)
            {
                Console.WriteLine($"Минимальное количество экземпляров класса «здание» в городе {city.Name}: {city.Buildings.Count}");
            }

            Console.ReadLine();
        }
    }

    class City
    {
        public string Name { get; set; }
        public List<Building> Buildings { get; set; }

        public City(string name)
        {
            Name = name;
            Buildings = new List<Building>();
        }
    }

    class Building
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public int Area { get; set; }

        public Building(string streetName, string houseNumber, int area)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
            Area = area;
        }
    }
}
