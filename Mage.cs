namespace Myspace
{
    public class Mage :
        Hero
    {
        public Mage(string name, double health, double attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance) : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalChance)
        {
        }

        private Random randomShield = new();
        private Random randomCriticalChance = new();
        private Random randomSpecialAttack = new();

        public override double AttackPow(Attack attack, double attackPower)
        {
            double TotalDamage = 0.0;
            if (shield()) // call the Shield function
            {
                Console.WriteLine("Shield def all damage!");
                return 0;
            }

            if (attack == Attack.Magical)
            {
                double CriticalDamage = criticalChance(attack); // call the CriticalChance function
                double damage = specialAttack(attackPower); // call the SpecialAttack function
                return TotalDamage = attackPower + CriticalDamage + damage;
            }

            else if (attack == Attack.Physical)
            {
                double CriticalDamage = criticalChance(attack); // call the CriticalChance function
                return TotalDamage = attackPower + CriticalDamage;
            }

            return TotalDamage;
        }

        // define the Shield function
        public bool shield()
        {
            int randomshield = randomShield.Next(1, 100);
            bool shield = false;
            if (randomshield <= 10)
            {
                shield = true; // shield is activated
                return shield; // return the value of shield
            }
            else
            {
                shield = false; // shield is not activated
                return shield; // return the value of shield
            }
        }

        // define the CriticalChance function
        public double criticalChance(Attack attack)
        {
            int randomcriticalchance = randomCriticalChance.Next(1, 101);

            double CriticalDamage = 0;
            if (attack == Attack.Physical)
            {
                if (randomcriticalchance <= CriticalChance / 3)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 10;
                }
            }
            else if (attack == Attack.Magical)
            {
                if (randomcriticalchance <= CriticalChance)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 60;
                }
            }
            return CriticalDamage;
        }

        // define the SpecialAttack function
        public double specialAttack(double attackPower)
        {
            int randomspecialattack = randomSpecialAttack.Next(1, 101);

            double damage = 0;

            if (randomspecialattack <= 20)
            {
                Console.WriteLine($"{Name} used a special attack!");
                damage = attackPower * 4;
            }
            return damage;
        }

    }
}
   