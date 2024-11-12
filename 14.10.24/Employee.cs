using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _14._10._24
{
    internal class Employee
    {
        private string name;
        private DateTime birthdate;
        private string tel;
        private string email;
        private string position;
        private string[] resp;

        public Employee() { }
       public Employee(string name, DateTime birthdate, string tel, string email, string position, string[] resp)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.tel = tel;
            this.email = email;
            this.position = position;
            this.resp = resp;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Birthdate: {birthdate}");
            Console.WriteLine($"Phone: {tel}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine("Responsibilities: ");
            for (int i = 0; i < resp.Length; i++)
            {
                Console.WriteLine(resp[i]);
            }
        }
        public string GetName() { return name; }
        public DateTime GetBirthdate() { return birthdate; }
        public string GetTel() { return tel; } 
        public string GetEmail() { return email; }
        public string GetPosition() { return position; }
        public string[] GetResp() { return resp; }
        public void SetName(string name) { this.name = name; }
        public void SetBirthdate(DateTime dateTime) { this.birthdate = dateTime; }
        public void SetTel(string tel) { this.tel = tel; }
        public void SetEmail(string email) { this.email = email; }
        public void SetPosition(string position) { this.position = position; }
    }
}
