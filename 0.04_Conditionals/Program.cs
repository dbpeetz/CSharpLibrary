using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
           // bool isOn = true;
            //bool isHot = false;
            bool isAdmin = false;
            bool isLoggedIn = true;

            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site!");
            }

            if(!isAdmin)
            {
                Console.WriteLine("Welcome to the site Admin");
            }

            if(isLoggedIn && isAdmin)
            {
                Console.WriteLine("You're logged in, and you're an admin!");
            }
            Console.ReadLine();
        }
    }
}
