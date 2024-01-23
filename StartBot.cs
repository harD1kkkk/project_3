namespace Myspace
{
    static class StartBot
    {
        public static void startBot()
        {
            Round roundPlayer = new();
            Round roundBot = new();

            // Create the characters
            Mage mage1 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer1 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior1 = new("Warrior", 600, 45, 30, 15, 20);

            Mage mage2 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer2 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior2 = new("Warrior", 600, 45, 30, 15, 20);

            // Let the players choose their characters
            PrintManager.printMenuPlayer();

        repeat0:
            if (Int32.TryParse(Console.ReadLine(), out int player1Choice) == false || player1Choice == 0 || player1Choice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat0;
            }

            Hero? player = null;
            switch (player1Choice)
            {
                case 1:
                    Console.WriteLine("Player: Choosed Mage");
                    player = mage1;
                    break;
                case 2:
                    Console.WriteLine("Player: Choosed Archer");
                    player = archer1;
                    break;
                case 3:
                    Console.WriteLine("Player: Choosed Warrior");
                    player = warrior1;
                    break;
            }

            Console.WriteLine();

            Random botChoice = new();
            int botchoice = botChoice.Next(1, 4);
            Hero? bot = null;
            switch (botchoice)
            {
                case 1:
                    Console.WriteLine("Bot: Choosed Mage");
                    bot = mage2;
                    break;
                case 2:
                    Console.WriteLine("Bot: Choosed Archer");
                    bot = archer2;
                    break;
                case 3:
                    Console.WriteLine("Bot: Choosed Warrior");
                    bot = warrior2;
                    break;
            }

            Console.WriteLine();

        repeat1:
            Console.WriteLine("battlefield selection: random - 1 or choose your own - 2");
            if (Int32.TryParse(Console.ReadLine(), out int BattlefieldChoice) == false || BattlefieldChoice == 0 || BattlefieldChoice > 2)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat1;
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
            repeat2:
                PrintManager.printMenuBattlefield();
                Console.WriteLine("Choose map: ");
                if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice == 0 || choice > 3)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                    goto repeat2;
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
            int count = 0;
            int countBot = 0;
            int countShop = 0;
            while (player?.Health > 0 && bot?.Health > 0)
            {
                int action;
                int AttackType;
                Attack selectedAttack;

                if (countShop == 5)
                {
                    PrintManager.ShopMenuBot(player, bot);
                    countShop = 0;
                }

                Console.WriteLine("Current player: " + currentPlayer);

                if (currentPlayer == 2)
                {
                    if (countBot == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicVSPlayer(player, bot);
                    }

                    if (action == 1)
                    {
                        selectedAttack = PrintManager.printAttackTypeBot(bot, mage2, archer2);
                        PrintManager.printActionBot(selectedAttack, bot, player, roundBot);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot);
                        PrintManager.printDefendsBot(bot);
                        Console.WriteLine();
                        countBot++;

                    }
                }

                else
                {
                // Choose the action for the current player
                repeat3:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat3;
                    }

                    Console.WriteLine();



                    if (action == 1) // Attack
                    {
                    repeat4:
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat4;
                        }
                        selectedAttack = PrintManager.printAttackType(AttackType);
                        PrintManager.printActionPlayer(selectedAttack, player, bot, roundPlayer);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the current player
                        if (count == 3)
                        {
                            Console.WriteLine("You have reached the limit");
                            goto repeat3;
                        }

                        PrintManager.printDefend(player);
                        PrintManager.printDefendsPlayer1(player);
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        count++;
                    }
                }
                // Switch to the next player
                currentPlayer = (currentPlayer % 2) + 1;
                countShop++;

                // Declare the winner
                PrintManager.printWinnerWithBot(player, bot, roundPlayer, roundBot);
                Console.WriteLine();
            }
        }
    }
}