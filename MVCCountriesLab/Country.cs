﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string _name, string _continent, List<string> _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors;
        }
    }
}
