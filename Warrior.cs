﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myspace
{
    internal class Warrior
        : Hero
    {
        public Warrior(string name, double health, double attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalchance) : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalchance)
        {

        }
        public override double AttackPow(Attack attack, double attackPower)
        {
            Random randomShield = new Random();
            int randomshield = randomShield.Next(1, 100);

            double TotalDamage = 0;
            if (randomshield > 80)
            {
                Console.WriteLine("Shield def all damage!");
                TotalDamage = 0;
                return 0;
            }

            if (attack == Attack.Physical)
            {
                Random randomCriticalChance = new Random();
                int randomcriticalchance = randomCriticalChance.Next(1, 100);

                double CriticalDamage = 0;
                if (randomcriticalchance < CriticalChance)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 50;
                }

                Random randomSpecialAttack = new Random();
                int randomspecialattack = randomSpecialAttack.Next(1, 100);

                double damage = 0;
                if (randomspecialattack < 21)
                {
                    Console.WriteLine($"{Name} used a special attack!");
                    damage = AttackPow(Attack.Physical, AttackPower * 2);
                }
                return TotalDamage = attackPower + CriticalDamage + damage;
            }

            else if (attack == Attack.Magical)
            {
                Random randomMagicalCriticalChance = new Random();
                int randommagicalcriticalchance = randomMagicalCriticalChance.Next(1, 100);

                double CriticalDamage = 0;
                if (randommagicalcriticalchance < CriticalChance / 5)
                {
                    Console.WriteLine($"{Name} used a Critical Damage!");
                    CriticalDamage += 20;
                }
                return TotalDamage = attackPower + CriticalDamage;
            }

            return TotalDamage;
        }
    }
}