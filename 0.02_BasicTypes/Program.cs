using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types");

            //string name = "Devan";
            //string teacher = "Paul";
            int a;
            a = 100;
            string year = "1991";
            bool t;
            t = true;
            bool f;
            f = false;
            float flt;
            flt = 120f;
            double number;
            number = 12.35;
            decimal dec;
            dec = 0.1m;

            Console.WriteLine("******Bronze******");
            Console.WriteLine(t);
            Console.WriteLine(f);
            Console.WriteLine(flt);
            Console.WriteLine(number);
            Console.WriteLine(dec);
            Console.WriteLine("******Silver******");
            Console.WriteLine("The current year is " + a + "? " + f);
            Console.WriteLine("********Gold************");
            Convert.ToInt32(year);

            //int numVal = Int32.Parse(year);
            //Console.WriteLine(name);
            Console.WriteLine("I was born in " + year);
            Console.ReadLine();

        }
    }
}
