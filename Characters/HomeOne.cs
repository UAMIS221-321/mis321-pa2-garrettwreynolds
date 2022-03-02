using mis321_pa2_garrettwreynolds.Attacks;

namespace mis321_pa2_garrettwreynolds.Characters
{
    public class HomeOne : Character
    {
        public HomeOne()
        {
            attackBehavior = new AckbarAtk();
        }
    }
}