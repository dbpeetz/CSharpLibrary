using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Lemur : Animal
    {
        public bool HasFingers { get; set; }
        public bool HasTail { get; set; }
        public string Color { get; set; }

        public void SitLikePeople()
        {
            Console.WriteLine("Lemur's sit like people.");
        }
    }
}
