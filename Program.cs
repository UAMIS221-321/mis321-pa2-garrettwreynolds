using System;
using mis321_pa2_garrettwreynolds.Characters;

namespace mis321_pa2_garrettwreynolds
{
    class Program
    {
        static void Main(string[] args)
        {
            Negotiator obiWan1 = new Negotiator();
            Malevolence grievous1 = new Malevolence();
            HomeOne ackbar1 = new HomeOne();
            Executrix tarkin1 = new Executrix();
            GameUtilities gameUtil = new GameUtilities();
            
            gameUtil.GameSetup();


        }
        
        static public void Menu()
        {
            Console.WriteLine("             Star Wars Fleet Battles              ");
            Console.WriteLine("             Press any key to start");

        }
    }
}
