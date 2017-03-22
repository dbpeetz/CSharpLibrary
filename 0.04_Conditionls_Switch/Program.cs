using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionls_Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            string friend = "Steve";

            switch (friend)
            {
                case "Matt":
                    Console.WriteLine("Hey Matt");
                    break;
                case "Stuart":
                    Console.WriteLine("Hey Stuart");
                    break;
                default:
                    break;
            }
            //Ternary Operator

            int num = 10;
            if (num == 7)
                Console.WriteLine("Hey this is the number 7.");
            else
                Console.WriteLine("This isn't number 7.");


            int input = Convert.ToInt32(Console.ReadLine());
            string classify;

            classify = (input > 0) ? "positive" : "negative";
            Console.WriteLine(classify);
            Console.ReadLine();

        }
    }
}
