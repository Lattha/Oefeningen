using System.Runtime.CompilerServices;
using Snelste_atleet.Models;

namespace Snelste_atleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int time = 0;
            Athlete fastest = null;

            do
            {
                Console.Write("Naam: ");
                name = Console.ReadLine();

                if (name == "STOP")
                    break;

                while (true)
                {
                    Console.Write("Tijd in seconden: ");
                    string input = Console.ReadLine();
                    Console.WriteLine();

                    if (int.TryParse(input, out time) && time > 0)
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ongeldige waarde. Geef een positief tijd in.");
                    Console.ResetColor();
                }

                Athlete current = new Athlete(name, time);

                if (fastest == null || current.Time < fastest.Time)
                {
                    fastest = current;
                }
            } while (true);

            Console.WriteLine();
            Console.Write("De snelste atleet is ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(fastest.Name);
            Console.ResetColor();
            Console.Write(" met een tijd van ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(fastest.FormattedTime);
            Console.ResetColor();
        }
    }
}
