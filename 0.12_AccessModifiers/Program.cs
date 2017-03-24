using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura tl = new Acura("TL", 2006, 15000 );


            Console.WriteLine(tl.AcuraDetails());

            Console.ReadLine();
        }
    }
}
