using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Cellini
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        public void Display(Country c)
        {
            Console.Clear();
            Console.WriteLine("Here's your country: ");
            Console.WriteLine($"Name: {c.Name}");
            Console.WriteLine($"Continent: {c.Continent}");
            Console.WriteLine($"Colors: {c.Colors}");
            Console.WriteLine("Press any key to return to the list view.");
            Console.ReadKey();


        }
    }
}
