﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}