using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._10._24
{
    internal class Airplane
    {
        public string Name { get;set;}
        public string CreatorComp { get;set;}
        public int Year { get;set;}
        public string Type { get;set;}
        public Airplane() { }
        public Airplane(string name, string creatorComp, int year, string type)
        {
            Name = name;
            CreatorComp = creatorComp;
            Year = year;
            Type = type;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCreator company: {CreatorComp}\nYear: {Year}\nType: {Type}";
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nCreator company: {CreatorComp}\nYear: {Year}\nType: {Type}");
        }

    }

}
