using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Dictionaries_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("2000", "Gladiator" );
            dictionary.Add("2001", "A Beautiful Mind");
            dictionary.Add("2002", "Gangs of New York");
            dictionary.Add("2003", "Find Nemo");
            dictionary.Add("2004", "Ray");
            dictionary.Add("2005", "Crash");

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }

            //string[] 2000 = new string[] 
            // { "Wonder Boys", "Traffic", "Sunshine", "Erin Brockovich", "Crouching Tiger, " +
            //         "Hidden Dragon", "Chocolat", "Billy Elliot" };

            Dictionary<string, string[]> bestPicture = new Dictionary<string, string[]>();
            bestPicture.Add("2000", new string[] { "Gladiator", "Choclat", "CTHD" });
            bestPicture.Add("2001", new string[] { "Beautiful Mind", "Gosford Park", "In the Bedroom" });
            bestPicture.Add("2002", new string[] { "Chicago", "Gangs of New York", "Harry Potter CS" });




            foreach (KeyValuePair<string, string[]> year in bestPicture)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", year.Key, year.Value[0], year.Value[1], year.Value[2]);
            }


            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();
            if (dictionary.ContainsKey(input1))
            {
                string valueForKey = dictionary[input1];
                Console.WriteLine("The best picture in {0} was {1}", input1, valueForKey);
            }

            Console.WriteLine("Please type the year to show the movie that were nominated that year.");
            string input2 = Console.ReadLine();

            if (bestPicture.ContainsKey(input2))
            {
                string[] valueForKey = bestPicture[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The Nominees for that year were: {0}", nomineeString);
            }
            

            Console.ReadLine();

        }
    }
}
