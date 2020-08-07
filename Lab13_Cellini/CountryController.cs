using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Cellini
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb.Add(new Country() { Name = "Ünderland", Continent = "North America", Colors = { "Maroon Red", "Gold" } });
            CountryDb.Add(new Country() { Name = "Genosha", Continent = "Africa", Colors = { "Purple", "Magenta" } });
            CountryDb.Add(new Country() { Name = "Arstotzka", Continent = "Europe", Colors = { "Red", "Grey" } });
            CountryDb.Add(new Country() { Name = "Latveria", Continent = "Europe", Colors = { "Green", "Black" } });
        }
        public void WelcomeAction()
        {
            CountryListView v = new CountryListView();
            v.Display(CountryDb);
            Country c = v.GetUserSelection(CountryDb);
            

            Console.ReadKey();
        }

        public void CountryAction(Country c)
        {
            CountryView v = new CountryView();
            v.Display(c);
        }
    }
}
