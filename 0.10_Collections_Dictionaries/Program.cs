using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("cat", "annoying creature");
            dictionary.Add("dog", "mans best friend");

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
        }
    }
}
