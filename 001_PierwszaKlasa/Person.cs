using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PierwszaKlasa
{
    class Car
    {
        private String name;
        private int year;

        public string Name { get => name; set => name=value; }
        public int Year { get => year; set => year=value; }
        
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.year;
            }
        }
    }
}
