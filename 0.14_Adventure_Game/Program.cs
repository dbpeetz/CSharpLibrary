﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Clan Name?");
            string clan = Console.ReadLine();
            Console.WriteLine("What player type?\n" +
                                "0: Asassin\n" +
                                "1: BlitzenBlopper\n" +
                                "2: Professor\n" +
                                "3: HorseMange\n" +
                                "4: TaxMan\n" +
                                "5: Human\n");

            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(0);


            Console.WriteLine(player.ToString());

            Orc orc = new Orc();
            orc.InsultPlayer();




           
           // Quagga.InsultPlayer();
            Console.ReadLine();

        }
    }
}
