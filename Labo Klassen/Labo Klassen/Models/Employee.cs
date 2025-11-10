using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Models
{
    internal class Employee
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private decimal _salary;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _birthDate.Year;
                if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
                    age--;
                return age;
            }
        }
        public Employee()
        {
        }
        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void IncreaseSalary(decimal percentage)
        {
            _salary = _salary * (1 + percentage / 100m);
        }

        public override string ToString()
        {
            // Toon salaris als valuta met spatie en juiste opmaak
            CultureInfo be = new CultureInfo("nl-BE");
            return $"Samenvatting: {_firstName} {_lastName} - {Age} - {_salary.ToString("C", be)}";
        }


    }
}