using System;
using mis321_pa2_garrettwreynolds.Characters;


namespace mis321_pa2_garrettwreynolds
{
    public class Matchups
    {
        public void NegotiatorVsMalevolence()
        {
            Negotiator obiWan1 = new Negotiator();
            Malevolence grievous1 = new Malevolence();
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