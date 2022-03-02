using mis321_pa2_garrettwreynolds.Interfaces;
using System;

namespace mis321_pa2_garrettwreynolds
{
    public class Character
    {
        public string charName {get; set;}
        public int maxCharPower {get;set;}
        public int charHealth {get; set;}
        public int charAtkStrength {get; set;}
        public int charDefPower {get; set;}
        public IAttack attackBehavior {get; set;}
        public IDefend defendBehavior {get; set;}

        public Character()
        {
            maxCharPower = new Random().Next(1,100);
            
            defendBehavior = new DefendBehavior();
        }

        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
        public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }
        
    }
}