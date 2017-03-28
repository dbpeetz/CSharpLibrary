using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Adventure_Game
{
    class Orc : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int> {
                { "Headbutt",5},
                { "Mallet", 10},
                { "Orc Smash", 45}
             };

        public Orc()
        {
            this.PowerLevel = 50;
            this.Name = "Orc";
        }

 

        public override void InsultPlayer()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I {0} you {1}.", this.Name, insult[r]);

        }

        public void OrcAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }

    }
}
