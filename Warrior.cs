using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myspace
{
    public class Warrior
        : Hero
    {
        public Warrior(string name, double health, double attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance) : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalChance)
        {
        }

        private Random randomShield = new Random();
        private Random randomCriticalChance = new Random();
        private Random randomSpecialAttack = new Random();

        public override double AttackPow(Attack attack, double attackPower)
        {
            double TotalDamage = 0.0;
            if (shield()) // call the Shield function
            {
                Console.WriteLine("Shield def all damage!");
                TotalDamage = 0.0;
                return 0;
            }

            if (attack == Attack.Physical)
            {
                double CriticalDamage = criticalChance(attack); // call the CriticalChance function
                double damage = specialAttack(attackPower); // call the SpecialAttack function
                return TotalDamage = attackPower + CriticalDamage + damage;
            }

            else if (attack == Attack.Magical)
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
            int randomcriticalchance = randomCriticalChance.Next(1, 100);

            double CriticalDamage = 0;
            if (attack == Attack.Physical)
            {
                if (randomcriticalchance <= CriticalChance)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 60;
                }
            }
            else if (attack == Attack.Magical)
            {
                if (randomcriticalchance <= CriticalChance / 5)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 30;
                }
            }
            return CriticalDamage;
        }

        // define the SpecialAttack function
        public double specialAttack(double attackPower)
        {
            int randomspecialattack = randomSpecialAttack.Next(1, 100);

            double damage = 0;

            if (randomspecialattack <= 20)
            {
                Console.WriteLine($"{Name} used a special attack!");
                damage = attackPower * 2;
            }

            return damage;
        }
    }
}