using Favouriete_album.Models;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Favouriete_album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameAlbum;
            int numberSongs;
            int durationInMinutes;
            DateTime releaseDate;
            bool isDateOK;
            string pattern = "dd/MM/yyyy";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** Favoriete Album ***");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Wat is de naam van je favoriete album?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            nameAlbum = Console.ReadLine();
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine("Op welke datum werd het uitgebracht?");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                string date = Console.ReadLine();
                Console.ResetColor();
                isDateOK = DateTime.TryParseExact(date, pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate);
                if (isDateOK)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ongeldige Formaat. Gebruik ({pattern})");
                Console.ResetColor();
            }
            while (true)
            {
                Console.WriteLine("Hoeveel nummers staan er op het album?");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                string input = Console.ReadLine();
                Console.ResetColor();
                if (int.TryParse(input, out numberSongs) && numberSongs > 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Verkeerde ingave");
                Console.ResetColor();
            }

            while (true)
            {
                Console.WriteLine("Hoelang duurt het album in totaal? (minuten)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                string input = Console.ReadLine();
                Console.ResetColor();
                if (int.TryParse(input, out durationInMinutes) && durationInMinutes > 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Verkeerde ingave");
                Console.ResetColor();
            }
            Album album = new Album();
            album.Name = nameAlbum;
            album.ReleaseDate = releaseDate;
            album.NumberSongs = numberSongs;
            album.DurationInMinutes = durationInMinutes;

            ShowTitle(album);

            static void ShowTitle(Album album)
            {
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"Naam:",-15} {album.Name}");
                Console.WriteLine($"{"Uitgebracht:",-15} {album.FormattedDate}");
                Console.WriteLine($"{"Aantal nummers:",-15} {album.NumberSongs}");
                Console.WriteLine($"{"Totale duur:",-15} {album.FormattedDuration}");
                Console.ResetColor();
                Console.ReadLine();
            }
            
        }
    }
}
