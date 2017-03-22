using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = false;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNum = 13;

            if(elevatorUp == true)
            {
                Console.WriteLine("Going Up");
            }

            else
            {
                Console.WriteLine("Going down");
            }

            if (elevatorBroken)
            {
                Console.WriteLine("Panic!!");
            }
            else
            {
                Console.WriteLine("Man, this is a nice elevator");
            }

            if (elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Let's go Diehard in this elevator shaft");
                Console.WriteLine("Yea,let's climb the cord.");
            }
            else
            {
                Console.WriteLine("Do you have those TPS Reports for me?");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("Weeee");
            }
            else
            {
                Console.WriteLine("I wish this was broken.");
            }

            if (elevatorBroken || elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Dude, we're in Mexico. We're in 4th grade. We're stuck on an elevator.");
            }

            if (elevatorNum == 13)
            {
                Console.WriteLine("You are on floor 13, which doesn't exist");
            }
            
               


            Console.ReadLine();
        }
    }
}
