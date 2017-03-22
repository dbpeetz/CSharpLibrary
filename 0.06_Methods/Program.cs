using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";
            theJSWizard.PrintCustomerName();
            theJSWizard.GoodbyeMessage();

            Customer theSheriff = new Customer();
            theSheriff.FirstName = "Sheriff";
            theSheriff.LastName = "Holler";
            theSheriff.PrintCustomerName();
            theSheriff.GoodbyeMessage();

            Customer devan = new Customer();
            devan.FirstName = "Devan";
            devan.LastName = "Peetz";
            devan.PrintCustomerName();
            devan.GoodbyeMessage();



            Console.ReadLine();
        }
    }
}
