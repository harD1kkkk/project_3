// See https://aka.ms/new-console-template for more information
namespace Myspace;

public enum Attack
{
    Physical,
    Magical
}
public enum Action
{
    Attack,
    Defend
}



class Program
{
    static void Main()
    {
        // Create the characters
        Mage mage1 = new("Mage", 100, 35, 10, 20, 40);
        Archer archer1 = new("Archer", 150, 40, 15, 10, 50);
        Warrior warrior1 = new("Warrior", 200, 45, 30, 15, 20);

        Mage mage2 = new("Mage", 100, 35, 10, 20, 40);
        Archer archer2 = new("Archer", 150, 40, 15, 10, 50);
        Warrior warrior2 = new("Warrior", 200, 45, 30, 15, 20);

        // Let the players choose their characters
        PrintManager.printMenuPlayer1();

    repeat1:
        if (Int32.TryParse(Console.ReadLine(), out int player1Choice) == false || player1Choice == 0 || player1Choice > 3)
        {
            Console.WriteLine("Error.You entered an incorrect value");
            goto repeat1;
        }

        Hero? player1 = null;
        switch (player1Choice)
        {
            case 1:
                Console.WriteLine("Choosed Mage");
                player1 = mage1;
                break;
            case 2:
                Console.WriteLine("Choosed Archer");
                player1 = archer1;
                break;
            case 3:
                Console.WriteLine("Choosed Warrior");
                player1 = warrior1;
                break;
        }

        Console.WriteLine();

        PrintManager.printMenuPlayer2();

    repeat2:
        if (Int32.TryParse(Console.ReadLine(), out int player2Choice) == false || player2Choice == 0 || player2Choice > 3)
        {
            Console.WriteLine("Error.You entered an incorrect value");
            goto repeat2;
        }

        Hero? player2 = null;
        switch (player2Choice)
        {
            case 1:
                Console.WriteLine("Choosed Mage");
                player2 = mage2;
                break;
            case 2:
                Console.WriteLine("Choosed Archer");
                player2 = archer2;
                break;
            case 3:
                Console.WriteLine("Choosed Warrior");
                player2 = warrior2;
                break;
        }

        Console.WriteLine();

        // Let the players choose the battlefield
        PrintManager.printMenuBattlefield();

    repeat3:
        if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice == 0 || choice > 3)
        {
            Console.WriteLine("Error.You entered an incorrect value");
            goto repeat3;
        }

        // Apply the battlefield modifiers to the characters
        switch (choice)
        {
            case 1:
                Console.WriteLine("Choosed Storm");
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
                break;
            case 2:
                Console.WriteLine("Choosed Forest");
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
                break;
            case 3:
                Console.WriteLine("Choosed Desert");
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
                break;
        }

        Console.WriteLine();

        // Start the battle
        Random random = new();

        // Choose the first player randomly
        int currentPlayer = random.Next(1, 3);

        while (player1?.Health > 0 && player2?.Health > 0)
        {
            Console.WriteLine("Current player: " + currentPlayer);

            // Choose the action for the current player
            PrintManager.printMenuAction();

        repeat4:
            if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat4;
            }

            Console.WriteLine();

            if (action == 1) // Attack
            {
                // Choose the attack type 
                PrintManager.printMenuAttackType();

            repeat5:
                if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                    goto repeat5;
                }

                Attack selectedAttack;

                if (AttackType == 1)
                {
                    selectedAttack = Attack.Physical;
                }
                else
                {
                    selectedAttack = Attack.Magical;
                }

                // Calculate the damage dealt by the current player
                double damageDealt;
                if (currentPlayer == 1)
                {

                    if (selectedAttack == Attack.Physical)
                    {
                        damageDealt = player1.AttackPow(selectedAttack, player1.AttackPower);
                        if (damageDealt <= 0)
                        {
                            player2.Health -= damageDealt;
                        }
                        else if (damageDealt > 0)
                        {
                            damageDealt -= player2.ResistanceToPhysical;
                            player2.Health -= damageDealt;
                        }

                        //Result
                        PrintManager.printAttackPlayer1(player1, player2, damageDealt);
                        Console.WriteLine();
                    }


                    else if (selectedAttack == Attack.Magical)
                    {
                        damageDealt = player1.AttackPow(selectedAttack, player1.AttackPower);
                        if (damageDealt <= 0)
                        {
                            player2.Health -= damageDealt;
                        }
                        else if (damageDealt > 0)
                        {
                            damageDealt -= player2.ResistanceToMagical;
                            player2.Health -= damageDealt;
                        }

                        //Result
                        PrintManager.printAttackPlayer1(player1, player2, damageDealt);
                        Console.WriteLine();
                    }
                }



                else if (currentPlayer == 2)
                {
                    if (selectedAttack == Attack.Physical)
                    {
                        damageDealt = player2.AttackPow(selectedAttack, player2.AttackPower);
                        if (damageDealt <= 0)
                        {
                            player1.Health -= damageDealt;
                        }
                        else if (damageDealt > 0)
                        {
                            damageDealt -= player1.ResistanceToPhysical;
                            player1.Health -= damageDealt;
                        }

                        //Result
                        PrintManager.printAttackPlayer2(player1, player2, damageDealt);
                        Console.WriteLine();
                    }


                    else if (selectedAttack == Attack.Magical)
                    {
                        damageDealt = player2.AttackPow(selectedAttack, player2.AttackPower);
                        if (damageDealt <= 0)
                        {
                            player1.Health -= damageDealt;
                        }
                        else if (damageDealt > 0)
                        {
                            damageDealt -= player1.ResistanceToMagical;
                            player1.Health -= damageDealt;
                        }

                        //Result
                        PrintManager.printAttackPlayer2(player1, player2, damageDealt);
                        Console.WriteLine();
                    }
                }
            }

            else if (action == 2) // Defend
            {
                // Increase the resistance of the current player
                if (currentPlayer == 1)
                {
                    player1.ResistanceToPhysical += 5;
                    player1.ResistanceToMagical += 5;
                    PrintManager.printDefendsPlayer1(player1);
                    Console.WriteLine();
                }
                else if (currentPlayer == 2)
                {
                    player2.ResistanceToPhysical += 5;
                    player2.ResistanceToMagical += 5;
                    PrintManager.printDefendsPlayer2(player2);
                    Console.WriteLine();
                }
            }

            // Switch to the next player
            currentPlayer = (currentPlayer % 2) + 1;


            // Declare the winner
            PrintManager.printWinner(player1, player2);
        }
    }
}