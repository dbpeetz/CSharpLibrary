using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone devan = new MobilePhone("Devan", "iPhone", "6s Plus");
            MobilePhone steve = new MobilePhone("Steve", "LG", "V20");
            MobilePhone stuart = new MobilePhone("Stuart", "iPhone", "7 Plus");
            MobilePhone karli = new MobilePhone("Karli", "iPhone", "7");
            MobilePhone dustin = new MobilePhone("Dustin", "Samsung", "S7");

            Console.ReadLine();


        }
    }
}
