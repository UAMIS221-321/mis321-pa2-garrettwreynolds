using mis321_pa2_garrettwreynolds.Attacks;
using System;

namespace mis321_pa2_garrettwreynolds.Characters
{
    public class Executrix : Character
    {
        public Executrix()
        {
            charName = "Executrix";
            maxCharPower = new Random().Next(1,100);
            charHealth = 100;
            charAtkStrength = new Random().Next(1, maxCharPower);
            charDefPower = new Random().Next(1,maxCharPower);
            
            attackBehavior = new TarkinAtk();
            
        }
    }
}