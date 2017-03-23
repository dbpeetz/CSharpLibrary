using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class MobilePhone
    {

        public MobilePhone(string user, string brand, string model)
        {
            this.Make = brand;
            this.Model = model;
            this.Name = user;
            Console.WriteLine(this.Name + " owns a " + this.Make + " " + this.Model);
        }

        public string Make { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }



    }
}
