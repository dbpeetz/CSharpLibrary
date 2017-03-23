using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Netflix blackMirror = new Netflix();
            blackMirror.Rating = 3;
            blackMirror.Genre = "Sci-Fi";
            blackMirror.Name = "Black Mirror";
            blackMirror.Minutes = 48;
            

            Netflix strangerThings = new Netflix();
            strangerThings.Rating = 5;
            strangerThings.Genre = "Sci-Fi";
            strangerThings.Name = "Stranger Things";

            Netflix theMagicians = new Netflix();
            theMagicians.Rating = 5;
            theMagicians.Genre = "Drama";
            theMagicians.Name = "The Magicians";


            blackMirror.GetSuggestion();
            blackMirror.ShowRuntime();
            blackMirror.ShowWhoViewed("Karli", "10:30am");
            blackMirror.ShowMinutesLeft(30);


            strangerThings.GetSuggestion();
            theMagicians.GetSuggestion();




            Console.ReadLine();


        }
    }
}
