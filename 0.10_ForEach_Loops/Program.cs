using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForEach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[3] = 4;
            number[4] = 5;

            int[] lottoNum = new int[] { 15, 4, 16, 23, 42, 7 };
            string[] names = new string[] { "James", "Paul", "Obi Wan", "Anakin", "Meow" };

            foreach(int numbers in number)
            {
                Console.WriteLine(numbers);
            }
            foreach(int lotto in lottoNum)
            {
                Console.WriteLine(lotto);
            }

            foreach(string n in names)
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();
        }
    }
}
