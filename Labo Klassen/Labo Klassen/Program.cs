using System;
using Labo.Models;

namespace Labo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string firstName = "";
            string lastName = "";
            DateTime birthDate;
            decimal salary = 0m;
            decimal percentage = 0m;

            Console.Write("Voornaam: ");
            firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            salary = decimal.Parse(Console.ReadLine());


            while (true)
            {
                Console.Write("Opslag percentage: ");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out percentage) && percentage >= 0 && percentage <= 10)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geen geldig getal...");
                Console.ResetColor();
            }

            Employee employee = new Employee();
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.BirthDate = birthDate;
            employee.Salary = salary;
            employee.IncreaseSalary(percentage);

            ShowDetails(employee, percentage);
        }
            
            /*Console.WriteLine();
            Console.WriteLine(employee);
            Console.WriteLine();

            Console.Write("Voornaam: ");
            firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            salary = decimal.Parse(Console.ReadLine());

            Employee employee2 = new Employee(firstName, lastName);
            employee2.BirthDate = birthDate;
            employee2.Salary = salary;

            Console.WriteLine();
            Console.WriteLine(employee);
            Console.WriteLine(employee2);
            Console.WriteLine();
            Console.ReadLine();
        }*/
        public static void ShowDetails(Employee employee, decimal percentage)
        {
            Employee employee1 = new Employee();
            Console.Clear();
            Console.WriteLine($"Opslag percentage: {percentage}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Werknemer: {employee.FirstName}");
            Console.WriteLine($"Geboortedatum: {employee.BirthDate.ToString("dddd dd MMMM yyyy")} ({employee.Age})");
            Console.WriteLine($"Salaris: {employee.Salary}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(employee);
        }
    }
}
