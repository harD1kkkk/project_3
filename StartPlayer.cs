using System.Numerics;

namespace Myspace
{
    static class StartPlayer
    {
        public static void startPlayer()
        {
            Round round1 = new();
            Round round2 = new();
            // Create the characters
            Mage mage1 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer1 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior1 = new("Warrior", 600, 45, 30, 15, 20);

            Mage mage2 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer2 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior2 = new("Warrior", 600, 45, 30, 15, 20);

        // Let the players choose their characters
        repeat0:
            PrintManager.printMenuPlayer1();

            if (Int32.TryParse(Console.ReadLine(), out int player1Choice) == false || player1Choice == 0 || player1Choice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat0;
            }

            Hero? player1 = null;
            switch (player1Choice)
            {
                case 1:
                    Console.WriteLine("Player 1: Choosed Mage");
                    player1 = mage1;
                    break;
                case 2:
                    Console.WriteLine("Player 1: Choosed Archer");
                    player1 = archer1;
                    break;
                case 3:
                    Console.WriteLine("Player 1: Choosed Warrior");
                    player1 = warrior1;
                    break;
            }

            Console.WriteLine();

        repeat1:
            PrintManager.printMenuPlayer2();
            if (Int32.TryParse(Console.ReadLine(), out int player2Choice) == false || player2Choice == 0 || player2Choice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat1;
            }

            Hero? player2 = null;
            switch (player2Choice)
            {
                case 1:
                    Console.WriteLine("Player 2: Choosed Mage");
                    player2 = mage2;
                    break;
                case 2:
                    Console.WriteLine("Player 2: Choosed Archer");
                    player2 = archer2;
                    break;
                case 3:
                    Console.WriteLine("Player 2: Choosed Warrior");
                    player2 = warrior2;
                    break;
            }

            Console.WriteLine();

        // Let the players choose the battlefield
        repeat2:
            Console.WriteLine("battlefield selection: random - 1 or choose your own - 2");
            if (Int32.TryParse(Console.ReadLine(), out int BattlefieldChoice) == false || BattlefieldChoice == 0 || BattlefieldChoice > 2)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat2;
            }

            if (BattlefieldChoice == 1)
            {
                Random Battlefield = new();
                int battlefield = Battlefield.Next(1, 4);
                if (battlefield == 1)
                {
                    Console.WriteLine("Randomly choosed Storm");
                    Location.Storm(mage1, mage2, archer1, archer2, warrior1, warrior2);

                }
                else if (battlefield == 2)
                {
                    Console.WriteLine("Randomly choosed Forest");
                    Location.Forest(mage1, mage2, archer1, archer2, warrior1, warrior2);
                }
                else
                {
                    Console.WriteLine("Randomly choose Desert");
                    Location.Desert(mage1, mage2, archer1, archer2, warrior1, warrior2);
                }
            }

            else
            {
            repeat3:
                PrintManager.printMenuBattlefield();
                Console.WriteLine("Choose map: ");
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
                        Location.Storm(mage1, mage2, archer1, archer2, warrior1, warrior2);
                        break;
                    case 2:
                        Console.WriteLine("Choosed Forest");
                        Location.Forest(mage1, mage2, archer1, archer2, warrior1, warrior2);
                        break;
                    case 3:
                        Console.WriteLine("Choosed Desert");
                        Location.Desert(mage1, mage2, archer1, archer2, warrior1, warrior2);
                        break;
                }
            }

            Console.WriteLine();

            // Start the battle
            Random random = new();

            // Choose the first player randomly
            int currentPlayer = random.Next(1, 3);
            int countShop = 0;
            int count1 = 0;
            int count2 = 0;

            while (player1?.Health > 0 && player2?.Health > 0)
            {
                Attack selectedAttack;
                if (countShop == 5)
                {
                    PrintManager.ShopMenuPlayervsPlayer(player1, player2);
                    countShop = 0;
                }

                Console.WriteLine("Current player: " + currentPlayer);

                if (currentPlayer == 1)
                {
                repeat4:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player1);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat4;
                    }

                    Console.WriteLine();


                    if (action == 1)
                    {
                    repeat5:
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat5;
                        }

                        selectedAttack = PrintManager.printAttackType(AttackType);

                        PrintManager.printAction1(selectedAttack, player1, player2, round1);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the current player
                        if (count1 == 3)
                        {
                            Console.WriteLine("You have reached the limit");
                            goto repeat4;
                        }
                        PrintManager.printDefend(player1);
                        PrintManager.printDefendsPlayer1(player1);
                        count1++;
                        Console.WriteLine();
                    }
                }



                else if (currentPlayer == 2)
                {
                repeat6:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player2);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat6;
                    }

                    Console.WriteLine();
                    if (action == 1)
                    {
                    repeat7:
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat7;
                        }

                        selectedAttack = PrintManager.printAttackType(AttackType);

                        PrintManager.printAction2(selectedAttack, player1, player2, round2);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the current player
                        if (count2 == 3)
                        {
                            Console.WriteLine("You have reached the limit");
                            goto repeat6;
                        }
                        PrintManager.printDefend(player2);
                        PrintManager.printDefendsPlayer2(player2);
                        count2++;
                        Console.WriteLine();
                    }
                }

                // Switch to the next player
                currentPlayer = (currentPlayer % 2) + 1;
                countShop++;


                // Declare the winner
                PrintManager.printWinner(player1, player2, round1, round2);
                Console.WriteLine();


            }
        }
    }
}