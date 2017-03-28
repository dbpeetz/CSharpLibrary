using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Adventure_Game
{
    class Enemy
    {
        protected Random rnd = new Random();
        protected ArrayList insult = new ArrayList { "wimp", "window licker", "nerd-cake", "scrub", "noob" };
        public string Name { get; set; }
        public int PowerLevel { get; set; }


        public virtual void InsultPlayer()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("You're in the wrong neighborhood, {0}.", insult[r]);

        }
           
    }
}
