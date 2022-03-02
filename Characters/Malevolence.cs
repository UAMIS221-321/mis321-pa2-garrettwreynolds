using mis321_pa2_garrettwreynolds.Attacks;

namespace mis321_pa2_garrettwreynolds.Characters
{
    public class Malevolence : Character
    {
        public Malevolence()
        {
            attackBehavior = new GrievousAtk();
        }
    }
}