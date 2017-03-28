using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Adventure_Game
{
    class Orc : Enemy
    {
     //   public string Attack { get; set; }
     //   public string Weapon { get; set; }
     //   public int Strength { get; set; }

        public Orc()
        {
            this.PowerLevel = 50;
            this.Name = "Orc";
        }

      //  public Orc (string attack, string weapon, int strength)
       // {
       //     this.Attack = attack;
       //     this.Weapon = weapon;
       //     this.Strength = strength;
        //}

        public override void InsultPlayer()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I {0} you {1}.", this.Name, insult[r]);

        }

    }
}
