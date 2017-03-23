using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Netflix
    {  
        
        //Fields
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public int Minutes { get; set; }


        //Methods with no return
        public void GetSuggestion()
        {
            if (Rating >= 4)
                Console.WriteLine("You should defintely watch this show.");
            else
                Console.WriteLine("You probably shouldn't watch this show.");
        }

        //Method with Return

        public int ShowRuntime()
        {
            Console.WriteLine(this.Minutes + " minute episodes.");
            return this.Minutes;
        }

        //Methods that have parameters
        public string ShowWhoViewed(string user, string time)
        {
            string details = user + " watched this at " + time;
            Console.WriteLine(details);
            return details;
        }

        public int ShowMinutesLeft (int watched)
        {
            int remaining = this.Minutes - watched;
            Console.WriteLine("There are " + remaining + " remaining in the show");
            return remaining ;
        }


    }
        
}
