using System;
using System.Net.Http.Headers;

namespace _001_PierwszaKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            Console.WriteLine("Podaj markę: ");
            c.Name = Console.ReadLine();
            //c.Year = Int32.Parse( Console.ReadLine());
            //c.Year = Convert.ToInt32(Console.ReadLine());
            
            int tmp;
            Console.WriteLine("Podaj rocznik: ");
            while (! Int32.TryParse(Console.ReadLine(), out tmp))
            {
                Console.WriteLine("Podaj rocznik: ");
            }
            c.Year = tmp;
            System.Console.WriteLine($"Wiek: {c.Age}");
            Console.ReadLine();
        }


    }
}
