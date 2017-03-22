using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today 1-5?");
            string feelingNumber = Console.ReadLine();
            Convert.ToInt32(feelingNumber);

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow. That's great to hear.");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("nice");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("well alright");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Bummer");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("That is awful");
            }
            


            Console.ReadLine();
        }
    }
}
