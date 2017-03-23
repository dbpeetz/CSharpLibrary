using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArraysOfObjects
{
    class Country
    {

        public Country(string name, string capital)
        {
            this.Name = name;
            this.Capital = capital;
        }

        public string Name { get; set; }
        public string Capital { get; set; }
        
        //Method

        public void PrintBetterDetails()
        {
            Console.WriteLine("The capital of {0} is {1}.", this.Name, this.Capital);

        }
    }
}
