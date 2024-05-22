using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public CountryController(List<Country> _countryDB)
        {
            CountryDB = _countryDB;
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);

            Console.WriteLine("Hello, welcome to the country app!");
            
            do
            {
                int choice;

                do
                {
                    Console.WriteLine("Please select a country from the following list:");
                    clv.Display();

                    choice = -1;

                    if(int.TryParse(Console.ReadLine().Trim(), out choice) && !(choice < 0 || choice >= CountryDB.Count))
                    {
                        break;
                    }

                    Console.WriteLine("Please enter a number corresponding to the countries on the list.");
                    
                } while (true);

                CountryAction(CountryDB[choice]);

                Console.WriteLine("Would you like to learn about another country?  Enter y to continue, enter anything else to end");
            } while (Console.ReadLine().Trim().ToLower() == "y");
        }
    }
}
