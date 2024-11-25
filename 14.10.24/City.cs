using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14._10._24
{
    internal class City
    {
    
        #region Areas
        private string[] areas;
        private string name;
        private string numb;
        private string country;
        private int population;
        #endregion
        #region Constructors
        public City() { }
        public City(string[] a, string n, string num, string c, int p) 
        {
            areas = a;
            name = n;
            numb = num;
            country = c;    
            population = p;
        }
        #endregion
        
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

        #region OperationsOverrides
        public static City operator +(City obj, int addPeople)
        {
            return new City(obj.areas, obj.name, obj.numb, obj.country, obj.population + addPeople);
        }

        public static City operator -(City obj, int removePeople)
        {
            return new City(obj.areas, obj.name, obj.numb, obj.country, obj.population - removePeople);
        }
        public static bool operator <(City a, City b)
        {
            if (a.population < b.population)
                return true;
            else
                return false;
        }

        public static bool operator >(City a, City b)
        {
            if (a.population > b.population)
                return true;
            else
                return false;
        }

        public static bool operator ==(City a, City b)
        {
            if (a.population == b.population)
                return true;
            else
                return false;
        }

        public static bool operator !=(City a, City b)
        {
            if (a.population == b.population)
                return true;
            else
                return false;
        }

        #endregion

        #region GetSet
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
        #endregion
    }
}
