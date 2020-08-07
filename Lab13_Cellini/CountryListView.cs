using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Cellini
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public void Display(List<Country> Countries)
        {
            Console.Clear();
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];
                Console.WriteLine(i + "  " + c.Name);
            }
        }
            public Country GetUserSelection(List<Country> Countries)
            {

                Country output;
                int select;

                while (true)
                {
                    Console.WriteLine($"Which country would like to learn about? 1 to { Countries.Count - 1}");

                    string input = Console.ReadLine();
                    try
                    {
                        select = int.Parse(input);
                        if (select >= 0 && select < Countries.Count)
                        {
                            output = Countries[select];
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"That is not an acceptible input, please input a number between 0 and { Countries.Count - 1} ");
                            Console.WriteLine("Let's try again");
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That wasn't a integer let's try again");
                        continue;
                    }

                }


                return output;
            }
    }
}
