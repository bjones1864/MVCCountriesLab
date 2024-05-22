using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.Write($"{DisplayCountry.Name}  Continent: {DisplayCountry.Continent} Colors: ");
            foreach(string color in DisplayCountry.Colors)
            {
                ChangeTextColor(color);
                Console.Write($"{color} ");
                ResetColor();
            }
            Console.WriteLine();
           
        }

        public void ChangeTextColor(string color)
        {
            switch(color.Trim().ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "purple":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "black":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
