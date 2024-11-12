using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._10._24
{
    internal class City
    {
        private string[] areas;
        private string name;
        private string numb;
        private string country;
        private int population;
        public City() { }
        public City(string[] a, string n, string num, string c, int p) 
        {
            areas = a;
            name = n;
            numb = num;
            country = c;    
            population = p;
        }

        public void Show()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Country: "+country);
            Console.WriteLine("Population: "+population);
            Console.WriteLine("Number: "+numb);
            Console.WriteLine("Areas: ");
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine(areas[i]);
            }
        }
        public void SetArea(string[] a) { areas = a; }
        public void SetName(string n) { name = n; }
        public void SetNumb(string n) { numb = n; }
        public void SetCountry(string c) { country = c; }
        public void SetPopulation(int p) { population = p; }
        public string[] GetArea() { return areas; }
        public string GetName() { return name; }
        public string GetNumb() { return numb; } 
        public string GetCountry() { return country; }
        public int GetPopulation() { return population; }
    }
}
