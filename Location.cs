using static System.Net.Mime.MediaTypeNames;

namespace Myspace
{
     static class Location 
    {
        public static void Storm(Mage mage1, Mage mage2, Archer archer1, Archer archer2, Warrior warrior1, Warrior warrior2)
        {
            mage1.ResistanceToMagical += 5; // Mage gets extra resistance to magical in storm
            mage2.ResistanceToMagical += 5; // Mage gets extra resistance to magical in storm

            mage1.ResistanceToPhysical += 10; // Mage gets extra damage in storm
            mage2.ResistanceToPhysical += 10; // Mage gets extra damage in storm

            mage1.AttackPower += 10; // Mage gets extra attack power in storm
            mage2.AttackPower += 10; // Mage gets extra attack power in storm

            mage1.Health += 20; // Mage gets extra health in storm
            mage2.Health += 20; // Mage gets extra health in storm

            mage1.CriticalChance += 10; // Mage gets extra critical chance in storm
            mage2.CriticalChance += 10; // Mage gets extra critical chance in storm



            warrior1.ResistanceToMagical -= 15; // Warrior gets reduced resistance to magical in storm
            warrior2.ResistanceToMagical -= 15; // Warrior gets reduced resistance to magical in storm

            warrior1.ResistanceToPhysical -= 5; // Warrior gets reduced resistance to physical in storm
            warrior2.ResistanceToPhysical -= 5; // Warrior gets reduced resistance to physical in storm

            warrior1.AttackPower += 10; // Warrior gets extra attack power in storm
            warrior2.AttackPower += 10; // Warrior gets extra attack power in storm

            warrior1.Health -= 15; // Warrior gets reduced health in storm
            warrior2.Health -= 15; // Warrior gets reduced health in storm

            warrior1.CriticalChance -= 10; // Warrior gets reduced critical chance in storm
            warrior2.CriticalChance -= 10; // Warrior gets reduced critical chance in storm



            archer1.ResistanceToMagical -= 5; // Archer gets reduced resistance to magical in storm
            archer2.ResistanceToMagical -= 5; // Archer gets reduced resistance to magical in storm

            archer1.ResistanceToPhysical += 10; // Archer gets extra resistance to physical in storm
            archer2.ResistanceToPhysical += 10; // Archer gets extra resistance to physical in storm

            archer1.AttackPower -= 10; // Archer gets reduced attack power in storm
            archer2.AttackPower -= 10; // Archer gets reduced attack power in storm

            archer1.Health += 20; // Archer gets extra health in storm
            archer2.Health += 20; // Archer gets extra health in storm

            archer1.CriticalChance += 10; // Archer gets extra critical chance in storm
            archer2.CriticalChance += 10; // Archer gets extra critical chance in storm
        }

        public static void Forest(Mage mage1,Mage mage2, Archer archer1,Archer archer2, Warrior warrior1,Warrior warrior2)
        {
            archer1.ResistanceToMagical += 5; // Archer gets extra resistance to magical in forest
            archer2.ResistanceToMagical += 5; // Archer gets extra resistance to magical in forest

            archer1.ResistanceToPhysical -= 10; // Archer gets reduced resistance to physical in forest
            archer2.ResistanceToPhysical -= 10; // Archer gets reduced resistance to physical in forest

            archer1.AttackPower += 15; // Archer gets extra attack power in forest
            archer2.AttackPower += 15; // Archer gets extra attack power in forest

            archer1.Health += 10; // Archer gets extra health in forest
            archer2.Health += 10; // Archer gets extra health in forest

            archer1.CriticalChance += 20; // Archer gets extra critical chance in forest
            archer2.CriticalChance += 20; // Archer gets extra critical chance in forest 



            warrior1.ResistanceToMagical += 10; // Warrior gets extra resistance to magical in forest
            warrior2.ResistanceToMagical += 10; // Warrior gets extra resistance to magical in forest

            warrior1.ResistanceToPhysical -= 20; // Warrior gets reduced resistance to physical in forest
            warrior2.ResistanceToPhysical -= 20; // Warrior gets reduced resistance to physical in forest

            warrior1.AttackPower += 10; // Warrior gets extra attack power in forest
            warrior2.AttackPower += 10; // Warrior gets extra attack power in forest

            warrior1.Health -= 30; // Warrior gets reduced health in forest
            warrior2.Health -= 30; // Warrior gets reduced health in forest

            warrior1.CriticalChance -= 10; // Warrior gets reduced critical chance in forest
            warrior2.CriticalChance -= 10; // Warrior gets reduced critical chance in forest




            mage1.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in forest
            mage2.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in forest

            mage1.ResistanceToPhysical += 10;  // Mage gets extra resistance to physical in forest
            mage2.ResistanceToPhysical += 10;  // Mage gets extra resistance to physical in forest

            mage1.AttackPower -= 5; // Mage gets reduced attack power in forest
            mage2.AttackPower -= 5; // Mage gets reduced attack power in forest

            mage1.Health -= 10; // Mage gets reduced health in forest
            mage2.Health -= 10; // Mage gets reduced health in forest

            mage1.CriticalChance -= 10; // Mage gets reduced critical chance in forest
            mage2.CriticalChance -= 10; // Mage gets reduced critical chance in forest
        }

       public  static void Desert(Mage mage1, Mage mage2, Archer archer1, Archer archer2, Warrior warrior1, Warrior warrior2)
        {
            warrior1.ResistanceToPhysical += 10; // Warrior gets extra resistance to physical in desert
            warrior2.ResistanceToPhysical += 10; // Warrior gets extra resistance to physical in desert

            warrior1.AttackPower += 10; // Warrior gets extra attack power in desert
            warrior2.AttackPower += 10; // Warrior gets extra attack power in desert

            warrior1.Health += 10; // Warrior gets extra health in desert
            warrior2.Health += 10; // Warrior gets extra health in desert

            warrior1.ResistanceToMagical -= 10; // Warrior gets reduced resistance to magical in desert
            warrior2.ResistanceToMagical -= 10; // Warrior gets reduced resistance to magical in desert

            warrior1.CriticalChance -= 10; // Warrior gets reduced critical chance in desert
            warrior2.CriticalChance -= 10; // Warrior gets reduced critical chance in desert

            mage1.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in desert
            mage2.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in desert

            mage1.AttackPower -= 10; // Mage gets reduced attack power in desert
            mage2.AttackPower -= 10; // Mage gets reduced attack power in desert

            mage1.Health -= 10; // Mage gets reduced health in desert
            mage2.Health -= 10; // Mage gets reduced health in desert

            mage1.ResistanceToPhysical += 10; // Mage gets extra resistance to physical in desert
            mage2.ResistanceToPhysical += 10; // Mage gets extra resistance to physical in desert

            mage1.CriticalChance += 10; // Mage gets extra critical chance in desert
            mage2.CriticalChance += 10; // Mage gets extra critical chance in desert

            archer1.ResistanceToPhysical -= 10; // Archer gets reduced resistance to physical in desert
            archer2.ResistanceToPhysical -= 10; // Archer gets reduced resistance to physical in desert

            archer1.Health -= 10; // Archer gets reduced health in desert
            archer2.Health -= 10; // Archer gets reduced health in desert

            archer1.AttackPower -= 10; // Archer gets reduced attack power in desert
            archer2.AttackPower -= 10; // Archer gets reduced attack power in desert

            archer1.CriticalChance -= 10; // Archer gets reduced critical chance in desert
            archer2.CriticalChance -= 10; // Archer gets reduced critical chance in desert
        }
    }
}
