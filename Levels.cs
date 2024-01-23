using System;
using System.Numerics;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Myspace
{
    static class Levels
    {
        public static void levels()
        {
        repeat0:
            int countLevel = 0;

            // Create the characters
            Mage mage1 = new("Mage", 500, 300, 10, 20, 40);
            Archer archer1 = new("Archer", 450, 45, 15, 10, 50);
            Warrior warrior1 = new("Warrior", 600, 55, 30, 15, 20);

            PrintManager.printMenuPlayer();
            if (Int32.TryParse(Console.ReadLine(), out int playerChoice) == false || playerChoice == 0 || playerChoice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat0;
            }

            Hero? player = null;
            switch (playerChoice)
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
            countLevel = 5;

            while (countLevel <= 6)
            {
                bool levelPassed = level(countLevel, player);
                if (levelPassed)
                {
                    countLevel++;
                }
                else
                {
                    Console.WriteLine("You failed the level. Try again - 1, no - 2(main menu)");
                    if (Int32.TryParse(Console.ReadLine(), out int levelChoose) == false || levelChoose == 0 || levelChoose > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat0;
                    }
                    if (levelChoose == 1)
                    {
                        goto repeat0;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        return;
                    }
                }
            }

            Console.WriteLine("You completed all the levels. Congratulations!");
        }

        private static bool level(int countLevel, Hero? player)
        {

            switch (countLevel)
            {
                case 1:
                    bool nextLevel1 = level1(player);
                    if (nextLevel1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 2:
                    bool nextLevel2 = level2(player);
                    if (nextLevel2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 3:
                    bool nextLevel3 = level3(player);
                    if (nextLevel3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 4:
                    bool nextLevel4 = level4(player);
                    if (nextLevel4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 5:
                    bool nextLevel5 = level5(player);
                    if (nextLevel5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 6:
                    bool nextLevel6 = Boss(player);
                    if (nextLevel6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }

        private static bool level1(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot = new();

            int countBot = 0;
            int count = 0;
            int countShop = 0;

            Mage bot = new("Mage", 500, 35, 10, 20, 40);
            Console.WriteLine("level 1");
            Console.WriteLine("You will fight with Mage");
            Random random = new();
            int currentPlayer = random.Next(1, 3);
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
                        selectedAttack = BotLogic.botLogicChoiceMage(bot);

                        PrintManager.printActionBot(selectedAttack, bot, player, roundBot);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot);
                        PrintManager.printDefendsBot(bot);
                        countBot++;
                        Console.WriteLine();

                    }
                }

                else
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }

                    Console.WriteLine();



                    if (action == 1) // Attack
                    {
                    repeat2:
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat2;
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
                            goto repeat1;
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
            if (player?.Health <= 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        private static bool level2(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot = new();

            int countBot = 0;
            int count = 0;
            int countShop = 0;

            Archer bot = new("Archer", 450, 40, 15, 10, 50);
            Console.WriteLine("level 2");
            Console.WriteLine("You will fight with Archer");
            Random random = new();
            int currentPlayer = random.Next(1, 3);
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
                        selectedAttack = BotLogic.botLogicChoiceArcher(bot);

                        PrintManager.printActionBot(selectedAttack, bot, player, roundBot);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot);
                        PrintManager.printDefendsBot(bot);
                        countBot++;
                        Console.WriteLine();

                    }
                }

                else
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }

                    Console.WriteLine();



                    if (action == 1) // Attack
                    {
                    repeat2:
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat2;
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
                            goto repeat1;
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
            if (player?.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool level3(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot = new();

            int countBot = 0;
            int count = 0;
            int countShop = 0;

            Warrior bot = new("Warrior", 600, 45, 30, 15, 20);
            Console.WriteLine("level 3");
            Console.WriteLine("You will fight with Warrior");
            Random random = new();
            int currentPlayer = random.Next(1, 3);
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
                        selectedAttack = BotLogic.botLogicChoiceWarrior(bot);

                        PrintManager.printActionBot(selectedAttack, bot, player, roundBot);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot);
                        PrintManager.printDefendsBot(bot);
                        countBot++;
                        Console.WriteLine();

                    }
                }

                else
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }

                    Console.WriteLine();



                    if (action == 1) // Attack
                    {
                    repeat2:
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat2;
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
                            goto repeat1;
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

            if (player?.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool level4(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot1 = new();
            Round roundBot2 = new();

            int countBot1 = 0;
            int countBot2 = 0;
            int count = 0;
            int countShop = 0;

            Mage? bot1 = new("Mage", 500, 35, 10, 20, 40);
            Archer? bot2 = new("Archer", 450, 40, 15, 10, 50);
            Console.WriteLine("level 4");
            Console.WriteLine("You will fight with Mage and Archer");
            Random random = new();
            int currentPlayer = random.Next(1, 4);
            while (player?.Health > 0 && bot1?.Health > 0 || bot2?.Health > 0)
            {
                int action;
                int AttackType;
                Attack selectedAttack;
                if (countShop == 5)
                {
                repeatShop:
                    Console.WriteLine("Player: Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
                    if (Int32.TryParse(Console.ReadLine(), out int choiceShop) == false || choiceShop == 0 || choiceShop > 6)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeatShop;
                    }

                    PrintManager.printShop(player, choiceShop);
                    Console.WriteLine();

                    Console.WriteLine("Bot1: statistic");
                    PrintManager.printStatistic(bot1);
                    BotLogic.botLogicShop(bot1);
                    Console.WriteLine();

                    Console.WriteLine("Bot2: statistic");
                    PrintManager.printStatistic(bot2);
                    BotLogic.botLogicShop(bot2);
                    Console.WriteLine();

                    countShop = 0;
                }

                Console.WriteLine("Current player: " + currentPlayer);

                if (currentPlayer == 2)
                {
                    if (countBot1 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicVSPlayer(player, bot1);
                    }

                    if (action == 1)
                    {
                        selectedAttack = BotLogic.botLogicChoiceMage(bot1);

                        PrintManager.printActionBot(selectedAttack, bot1, player, roundBot1);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot1);
                        PrintManager.printDefendsBot(bot1);
                        countBot1++;
                        Console.WriteLine();

                    }
                }

                else if (currentPlayer == 3)
                {

                    if (countBot2 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicVSPlayer(player, bot2);
                    }

                    if (action == 1)
                    {
                        selectedAttack = BotLogic.botLogicChoiceArcher(bot2);

                        PrintManager.printActionBot(selectedAttack, bot2, player, roundBot2);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot2);
                        PrintManager.printDefendsBot(bot2);
                        countBot2++;
                        Console.WriteLine();
                    }
                }

                else if (currentPlayer == 1)
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Choose who you want to attack 1 - bot1, 2 - bot2");
                    Console.WriteLine("Bot1: statistic");
                    PrintManager.printStatistic(bot1);
                    Console.WriteLine();

                    Console.WriteLine("Bot2: statistic");
                    PrintManager.printStatistic(bot2);
                    Console.WriteLine();
                    Console.WriteLine("Make your choice");
                    if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice == 0 || choice > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }
                    if (choice == 1 && bot1.Health <= 0)
                    {
                        Console.WriteLine("Bot1 is already dead");
                        goto repeat1;
                    }
                    else if (choice == 2 && bot2.Health <= 0)
                    {
                        Console.WriteLine("Bot2 is already dead");
                        goto repeat1;
                    }

                    if (choice == 1)
                    {
                        Console.WriteLine("Your statistic");
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat1;
                        }

                        Console.WriteLine();



                        if (action == 1) // Attack
                        {
                        repeat2:
                            // Choose the attack type 
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeat2;
                            }
                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player, bot1, roundPlayer);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeat1;
                            }
                            PrintManager.printDefend(player);
                            PrintManager.printDefendsPlayer1(player);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                            count++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Your statistic");
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat1;
                        }

                        Console.WriteLine();



                        if (action == 1) // Attack
                        {
                        repeat2:
                            // Choose the attack type 
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeat2;
                            }
                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player, bot2, roundPlayer);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeat1;
                            }
                            PrintManager.printDefend(player);
                            PrintManager.printDefendsPlayer1(player);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                            count++;
                        }
                    }
                }

                // Switch to the next player
                if (bot1?.Health > 0 && bot2?.Health > 0)
                {
                    currentPlayer = (currentPlayer % 3) + 1;
                }

                else if ((currentPlayer == 1 && bot1?.Health <= 0) || (currentPlayer == 2 && bot2?.Health <= 0))
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }

                else if (currentPlayer == 3 && bot1?.Health <= 0)
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }
                else if (currentPlayer == 2 && bot1?.Health <= 0)
                {
                    if ((currentPlayer % 2) + 1 == 1)
                    {
                        currentPlayer = 3;
                    }
                }



                else if (currentPlayer == 3 && bot2?.Health <= 0)
                {
                    if ((currentPlayer % 2) + 1 == 2)
                    {
                        currentPlayer = 1;
                    }
                }
                else if (currentPlayer == 2 && bot2?.Health <= 0)
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }
                else if (currentPlayer == 1 && bot2?.Health <= 0)
                {

                    if ((currentPlayer % 2) + 1 == 2)
                    {
                        currentPlayer = 3;
                    }
                }


                // Declare the winner
                PrintManager.printWinnerPlayerWithBotAndBot(player, bot1, bot2, roundPlayer, roundBot1, roundBot2);
                Console.WriteLine();
            }

            if (player?.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool level5(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot1 = new();
            Round roundBot2 = new();

            int countBot1 = 0;
            int countBot2 = 0;
            int count = 0;
            int countShop = 0;

            Archer? bot1 = new("Archer", 450, 40, 15, 10, 50);
            Warrior? bot2 = new("Warrior", 600, 45, 30, 15, 20);
            Console.WriteLine("level 5");
            Console.WriteLine("You will fight with Archer and Warrior");
            Random random = new();
            int currentPlayer = random.Next(1, 4);
            while (player?.Health > 0 && bot1?.Health > 0 || bot2?.Health > 0)
            {
                int action;
                int AttackType;
                Attack selectedAttack;
                if (countShop == 5)
                {
                repeatShop:
                    Console.WriteLine("Player: Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
                    if (Int32.TryParse(Console.ReadLine(), out int choiceShop) == false || choiceShop == 0 || choiceShop > 6)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeatShop;
                    }

                    PrintManager.printShop(player, choiceShop);
                    Console.WriteLine();

                    Console.WriteLine("Bot1: statistic");
                    PrintManager.printStatistic(bot1);
                    BotLogic.botLogicShop(bot1);
                    Console.WriteLine();

                    Console.WriteLine("Bot2: statistic");
                    PrintManager.printStatistic(bot2);
                    BotLogic.botLogicShop(bot2);
                    Console.WriteLine();

                    countShop = 0;
                }

                Console.WriteLine("Current player: " + currentPlayer);

                if (currentPlayer == 1)
                {
                    if (countBot1 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicVSPlayer(player, bot1);
                    }

                    if (action == 1)
                    {
                        selectedAttack = BotLogic.botLogicChoiceMage(bot1);

                        PrintManager.printActionBot(selectedAttack, bot1, player, roundBot1);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot1);
                        PrintManager.printDefendsBot(bot1);
                        countBot1++;
                        Console.WriteLine();

                    }
                }

                else if (currentPlayer == 2)
                {
                    if (countBot2 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicVSPlayer(player, bot2);
                    }

                    if (action == 1)
                    {
                        selectedAttack = BotLogic.botLogicChoiceArcher(bot2);

                        PrintManager.printActionBot(selectedAttack, bot2, player, roundBot2);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot2);
                        PrintManager.printDefendsBot(bot2);
                        countBot2++;
                        Console.WriteLine();
                    }
                }

                else if (currentPlayer == 3) 
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Choose who you want to attack 1 - bot1, 2 - bot2");
                    Console.WriteLine("Bot1: statistic");
                    PrintManager.printStatistic(bot1);
                    Console.WriteLine();

                    Console.WriteLine("Bot2: statistic");
                    PrintManager.printStatistic(bot2);
                    Console.WriteLine();
                    Console.WriteLine("Make your choice");
                    if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice == 0 || choice > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }
                    if (choice == 1 && bot1.Health <= 0)
                    {
                        Console.WriteLine("Bot1 is already dead");
                        goto repeat1;
                    }
                    else if (choice == 2 && bot2.Health <= 0)
                    {
                        Console.WriteLine("Bot2 is already dead");
                        goto repeat1;
                    }

                    if (choice == 1)
                    {
                        Console.WriteLine("Your statistic");
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat1;
                        }

                        Console.WriteLine();



                        if (action == 1) // Attack
                        {
                        repeat2:
                            // Choose the attack type 
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeat2;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player, bot1, roundPlayer);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeat1;
                            }
                            PrintManager.printDefend(player);
                            PrintManager.printDefendsPlayer1(player);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                            count++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Your statistic");
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat1;
                        }

                        Console.WriteLine();



                        if (action == 1) // Attack
                        {
                        repeat2:
                            // Choose the attack type 
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeat2;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player, bot2, roundPlayer);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeat1;
                            }
                            PrintManager.printDefend(player);
                            PrintManager.printDefendsPlayer1(player);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                            count++;
                        }
                    }
                }

                // Switch to the next player
                if (bot1?.Health > 0 && bot2?.Health > 0)
                {
                    currentPlayer = (currentPlayer % 3) + 1;
                }

                else if ((currentPlayer == 1 && bot1?.Health <= 0) || (currentPlayer == 2 && bot2?.Health <= 0))
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }

                else if (currentPlayer == 3 && bot1?.Health <= 0)
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }
                else if (currentPlayer == 2 && bot1?.Health <= 0)
                {
                    if ((currentPlayer % 2) + 1 == 1)
                    {
                        currentPlayer = 3;
                    }
                }

               

                else if (currentPlayer == 3 && bot2?.Health <= 0)
                {
                    if ((currentPlayer % 2) + 1 == 2)
                    {
                        currentPlayer = 1;
                    }
                }
                else if (currentPlayer == 2 && bot2?.Health <= 0)
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }
                else if (currentPlayer == 1 && bot2?.Health <= 0)
                {

                    if ((currentPlayer % 2) + 1 == 2)
                    {
                        currentPlayer = 3;
                    }
                }


                // Declare the winner
                PrintManager.printWinnerPlayerWithBotAndBot(player, bot1, bot2, roundPlayer, roundBot1, roundBot2);
                Console.WriteLine();
            }

            if (player?.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool Boss(Hero? player)
        {
            Round roundPlayer = new();
            Round roundBot = new();

            int countBot = 0;
            int count = 0;
            int countShop = 0;

            Boss bot = new("Boss", 700, 50, 10, 10, 60);
            Console.WriteLine("Final Round");
            Console.WriteLine("You will fight with Boss");
            Random random = new();
            int currentPlayer = random.Next(1, 3);
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
                        selectedAttack = BotLogic.botLogicChoiceBoss();

                        PrintManager.printActionBot(selectedAttack, bot, player, roundBot);
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot);
                        PrintManager.printDefendsBot(bot);
                        countBot++;
                        Console.WriteLine();

                    }
                }

                else
                {
                // Choose the action for the current player
                repeat1:
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine();
                    PrintManager.printMenuAction();

                    if (Int32.TryParse(Console.ReadLine(), out action) == false || action == 0 || action > 2)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeat1;
                    }

                    Console.WriteLine();



                    if (action == 1) // Attack
                    {
                    repeat2:
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat2;
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
                            goto repeat1;
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
            if (player?.Health <= 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}