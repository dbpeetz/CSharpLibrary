using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for (int i = 0; i < 11; i++)
              {
                  if (i % 2 == 0)               
                      Console.WriteLine("Even");

                  else
                      Console.WriteLine(i);
              } */
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }




            Console.ReadLine();
        }
    }
}
