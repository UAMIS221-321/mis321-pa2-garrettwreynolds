using mis321_pa2_garrettwreynolds.Characters;
using System;
using System.Collections.Generic;

namespace mis321_pa2_garrettwreynolds
{
    public class GameUtilities
    {
        public void GameSetup()
        {
            
            Negotiator obiWan1 = new Negotiator();
            Malevolence grievous1 = new Malevolence();
            HomeOne ackbar1 = new HomeOne();
            Executrix tarkin1 = new Executrix();

            // Negotiator obiWan2 = new Negotiator();
            // Malevolence grievous2 = new Malevolence();
            // HomeOne ackbar2 = new HomeOne();
            // Executrix tarkin2 = new Executrix();

            List<Character> characters = new List<Character>();
            characters.Add(obiWan1);
            characters.Add(grievous1);
            characters.Add(ackbar1);
            characters.Add(tarkin1);

        }
        public void GamePlay(Negotiator obiWan1,Malevolence grievous1, HomeOne ackbar1,Executrix tarkin1, List<Character> characters)
        {
            Console.WriteLine("Player 1, Press the associated number to select your character: \n1. Obi-Wan piloting Negotiator \n2. General Grievous piloting Malevolence \n3. Admiral Ackbar piloting Home One \n4. Grand Moff Tarkin piloting Executrix ");
            string userChoice1 = Console.ReadLine();

            Console.WriteLine("Player 2, Press the associated number to select your character: \n1. Obi-Wan piloting Negotiator \n2. General Grievous piloting Malevolence \n3. Admiral Ackbar piloting Home One \n4. Grand Moff Tarkin piloting Executrix ");
            string userChoice2 = Console.ReadLine();

            if(userChoice1 == "1" && userChoice2 == "2")
            {
                System.Console.WriteLine("Prepare for battle!!");

            int turnOrder = new Random().Next(1,2);

            if(turnOrder == 1)
            {
                Console.WriteLine("Player 1 goes first!");
                
                while(obiWan1.charHealth > 0 && grievous1.charHealth > 0)
                {
                    Console.WriteLine($"Negotiator (Player 1)'s health is {obiWan1.charHealth}.");
                    Console.WriteLine($"Malevolence (Player 2)'s health is {grievous1.charHealth}");
                    Console.WriteLine("");
                    Console.WriteLine("Player 1 choose an action: Press 1 to use Focus Fire attack or 2 to Defend.");
                    int player1Choice = int.Parse(Console.ReadLine());

                    if(player1Choice == 1)
                    {
                        obiWan1.attackBehavior.Attack();

                    }
                }
            }
            else if(turnOrder == 2)
            {
                Console.WriteLine("Player 2 goes first!");
            }
            }
            
        }

        
    }
}