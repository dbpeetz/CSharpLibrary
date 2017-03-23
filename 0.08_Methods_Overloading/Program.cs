using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.Name = "The JS Wizard";
            theJSWizard.Attack();
            theJSWizard.Attack("Hard Drive");
            theJSWizard.Attack("Hard Drive", 14);

            Console.ReadLine();
        }
    }
}
