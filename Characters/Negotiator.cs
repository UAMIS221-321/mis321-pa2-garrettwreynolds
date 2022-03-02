using System;
using mis321_pa2_garrettwreynolds.Attacks;

namespace mis321_pa2_garrettwreynolds.Characters
{
    public class Negotiator : Character
    {
        public Negotiator()
        {
            charName = "Negotiator";
            maxCharPower = new Random().Next(1,100);
            charHealth = 100;
            charAtkStrength = new Random().Next(1, maxCharPower);
            charDefPower = new Random().Next(1,maxCharPower);

            attackBehavior = new KenobiAtk();
        }
    }
}