using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;

            Lemur melman = new Lemur();
            melman.Weight = 25;
            melman.HasFingers = true;
            melman.NumberOfLegs = 2;

            PolarBear cokeaCola = new PolarBear();
            Animal theJSWiz = new Animal();
            theJSWiz.NumberOfLegs = 2;
            theJSWiz.Eyes = true;
            



            barryTheBear.Walk();
            barryTheBear.Speak();

            Console.ReadLine();
        }
    }
}
