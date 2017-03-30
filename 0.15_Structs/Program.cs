using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder St",
                City = "Westfield",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 40
            };
            AddressBookEntry Devan = new AddressBookEntry()
            {
                Address = "111 Coder St",
                City = "Lafayette",
                Zip = "47905",
                FirstName = "Devan",
                LastName = "Peetz",
                Age = 25
            };
            AddressBookEntry Steve = new AddressBookEntry()
            {
                Address = "100 Coder St",
                City = "West Lafayette",
                Zip = "47906",
                FirstName = "Steve",
                LastName = "Neal",
                Age = 26
            };
            AddressBookEntry Stuart = new AddressBookEntry()
            {
                Address = "155 Coder St",
                City = "West Lafayette",
                Zip = "47906",
                FirstName = "Stuart",
                LastName = "Bilan",
                Age = 24
            };

            Console.WriteLine(Paul.GetAddress());
            Console.ReadLine();
        }

        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }

            public void AddName(string first, string last, int age)
            {
                this.FirstName = first;
                this.LastName = last;
                this.Age = age;
            }
        }
    }
}
