using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool Eyes { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public string Sound { get; set; }


        public void Walk()
        {
            Console.WriteLine("I just took four steps.");
        }

    }
}
