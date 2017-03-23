using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Loop_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            int input = Int32.Parse(Console.ReadLine());

            Console.WriteLine("**************************");

            Console.WriteLine("Please enter another number");
            int input2 = Int32.Parse(Console.ReadLine());

            for (int i = input; i <= input2; i++)
            {
                int total = input + i;
                Console.WriteLine(total);
            }
   





            Console.ReadLine();
        }
    }
}
