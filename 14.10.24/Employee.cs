using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _14._10._24
{
    internal class Employee
    {
        #region Areas
        private string name;
        private DateTime birthdate;
        private string tel;
        private string email;
        private string position;
        private string[] resp;
        private int Salary { get; set; }
        #endregion

        #region MethodsConst
        public Employee() { }
       public Employee(string name, DateTime birthdate, string tel, string email, string position, string[] resp, int s)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.tel = tel;
            this.email = email;
            this.position = position;
            this.resp = resp;
            Salary = s;
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
        #endregion

        #region Overrides
        public static Employee operator +(Employee obj, int addS)
        {
            return new Employee(obj.name, obj.birthdate, obj.tel, obj.email, obj.position, obj.resp, obj.Salary + addS);
        }

        public static Employee operator -(Employee obj, int minS)
        {
            return new Employee(obj.name, obj.birthdate, obj.tel, obj.email, obj.position, obj.resp, obj.Salary - minS);
        }

        public static bool operator <(Employee a, Employee b)
        {
            return a.Salary < b.Salary;
        }

        public static bool operator >(Employee a, Employee b)
        {
            return a.Salary > b.Salary;
        }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Salary == b.Salary;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return a.Salary != b.Salary;
        }
        #endregion

        #region GetSet
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
        #endregion
    }
}
