using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int wiek { get; set; }


        public Person(string fn, string ln, int w)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.wiek = w;
        }

        public override string ToString()
        {
            return FirstName+ " " + LastName + " - " + wiek;
        }
    }
}
