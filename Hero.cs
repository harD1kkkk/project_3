using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Myspace
{
    public abstract class Hero
    {
        public string Name { set; get; }
        public double Health { set; get; }

        public double AttackPower { set; get; }

        public double ResistanceToPhysical { set; get; }

        public double ResistanceToMagical { set; get; }

        public double CriticalChance { set; get; }


        public Hero(string name, double health, double attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance)
        {
            this.Name = name;
            this.Health = health;
            this.AttackPower = attackPower;
            this.ResistanceToPhysical = resistanceToPhysical;
            this.ResistanceToMagical = resistanceToMagical;
            this.CriticalChance = criticalChance;
        }

        public delegate double AttackDelegate(Attack attack, double attackPower);

        public abstract double AttackPow(Attack attack, double attackPower);
    }
}