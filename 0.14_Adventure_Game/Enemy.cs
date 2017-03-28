using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Adventure_Game
{
    abstract class Enemy
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
        
        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
            
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1} damage", attackName, attackVal);

            Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal;
            
        }
           
    }
}
