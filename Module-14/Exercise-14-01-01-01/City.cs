using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_01_01_01
{
    internal class City
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
