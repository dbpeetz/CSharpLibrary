using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Devan";
            lastName = "Peetz";
            occupation = "Student";
            string fullname = firstName + " " + lastName;
            Console.WriteLine(fullname);

            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullname, occupation);

            //Silver Challenge
            string first = "Use those types ";
            string second = "to concatenate a string. ";
            string third = "Any string will do";

            Console.WriteLine("{0}" + "{1}" + "{2}", first, second, third);

            //Bronze Challenge
            string multiple = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);

            //Other silver challenge
            string date = "3/22/2017";
            Convert.ToDateTime(date);

            Console.WriteLine("Dear Mr Jones, \nToday is " + DateTime.Now + ".  I'm enjoying class, " +
                "and I think I like C# the best.\nI'd like to get a job as a developer after I finish this course.");

            //Gold Challenge
            string userName = "dpeetz";
            string userName2 = "DPEETZ";

            bool result = userName.Equals(userName2, StringComparison.Ordinal);

            Console.WriteLine("Comparison: {0} and {1} are {2}", userName, userName2, result ? "equal." : "not equal.");






            Console.ReadLine();
        }
    }
}
