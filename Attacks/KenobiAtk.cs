using mis321_pa2_garrettwreynolds.Interfaces;

namespace mis321_pa2_garrettwreynolds.Attacks
{
    public class KenobiAtk : IAttack
    {
        public void Attack()
        {
            
            System.Console.WriteLine($"Attack power is: {charAtkPower}");
        }
    }
}