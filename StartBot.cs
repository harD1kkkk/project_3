using System;

namespace Myspace
{
    static class StartBot
    {
        public static void startBot()
        {
            Round roundPlayer = new Round();
            Round roundBot = new Round();

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
            int countShop = 0;
            while (player?.Health > 0 && bot?.Health > 0)
            {
                int action;
                int AttackType;
                Attack selectedAttack;
                double damageDealt;

                if (countShop == 5)
                {
                repeatShop:
                    Console.WriteLine("Player choose 1 item!");
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player);
                    Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
                    if (Int32.TryParse(Console.ReadLine(), out int choiceShop) == false || choiceShop == 0 || choiceShop > 6)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeatShop;
                    }
                    if (choiceShop == 1)
                    {
                        player.Health += 20;
                        Console.WriteLine("You choosed: +20 health");
                    }
                    else if (choiceShop == 2)
                    {
                        player.ResistanceToPhysical += 3;
                        Console.WriteLine("You choosed: +3 Resistance To Physical");
                    }
                    else if (choiceShop == 3)
                    {
                        player.ResistanceToMagical += 3;
                        Console.WriteLine("You choosed: +3 Resistance To Magical");
                    }
                    else if (choiceShop == 4)
                    {
                        player.CriticalChance += 15;
                        Console.WriteLine("You choosed: +15 Critical chance");
                    }
                    else if (choiceShop == 5)
                    {
                        player.AttackPower += 10;
                        Console.WriteLine("You choosed: +10 Attack Power");
                    }



                    Random botChoiceShop = new();
                    int botchoiceshop = botChoiceShop.Next(1, 3);
                    if (bot.Health <= 100)
                    {
                        bot.Health += 20;
                        Console.WriteLine("Bot choosed: +20 health");
                    }
                    else if (bot.ResistanceToPhysical <= 10)
                    {
                        bot.ResistanceToPhysical += 3;
                        Console.WriteLine("Bot choosed: +3 Resistance To Physical");
                    }
                    else if (bot.ResistanceToMagical <= 10)
                    {
                        bot.ResistanceToMagical += 3;
                        Console.WriteLine("Bot choosed: +3 Resistance To Magical");
                    }
                    else if (botchoiceshop <= 50)
                    {
                        bot.CriticalChance += 15;
                        Console.WriteLine("Bot choosed: +15 Critical chance");
                    }
                    else if (botchoiceshop > 50)
                    {
                        bot.AttackPower += 10;
                        Console.WriteLine("Bot choosed: +10 Attack Power");
                    }
                    countShop = 0;
                }

                Console.WriteLine("Current player: " + currentPlayer);

                if (currentPlayer == 2)
                {
                    if (bot.Health >= 200 && player.Health < bot.Health)
                    {
                        Random botChoiceAction = new();
                        int botchoiceaction = botChoiceAction.Next(1, 3);

                        if (botchoiceaction == 1)
                        {
                            action = 1;
                        }

                        else
                        {
                            action = 2;
                        }
                    }
                    else if (bot.Health <= 100 || player.Health > bot.Health)
                    {
                        Random botChoiceAction2 = new();
                        int botchoiceaction2 = botChoiceAction2.Next(1, 101);
                        if (botchoiceaction2 <= 80)
                        {
                            action = 1;
                        }
                        else
                        {
                            action = 2;
                        }
                    }
                    else if (player.Health <= 50 || bot.Health <= 50)
                    {
                        action = 1;
                    }
                    else { action = 2; }


                    if (action == 1)
                    {
                        if (bot == mage2)
                        {
                            Random botChoiceAttack = new();
                            int botchoiceattack = botChoiceAttack.Next(1, 101);
                            if (botchoiceattack <= 90)
                            {
                                selectedAttack = Attack.Magical;
                            }
                            else
                            {
                                selectedAttack = Attack.Physical;
                            }
                        }
                        else if (bot == archer2)
                        {
                            Random botChoiceAttack = new();
                            int botchoiceattack = botChoiceAttack.Next(1, 101);
                            if (botchoiceattack <= 70)
                            {
                                selectedAttack = Attack.Physical;
                            }
                            else
                            {
                                selectedAttack = Attack.Magical;
                            }

                        }
                        else if (bot == warrior2)
                        {
                            Random botChoiceAttack = new();
                            int botchoiceattack = botChoiceAttack.Next(1, 101);
                            if (botchoiceattack <= 90)
                            {
                                selectedAttack = Attack.Physical;
                            }
                            else
                            {
                                selectedAttack = Attack.Magical;
                            }
                        }
                        else { selectedAttack = Attack.Physical; }


                        if (selectedAttack == Attack.Physical)
                        {
                            damageDealt = bot.AttackPow(selectedAttack, bot.AttackPower);
                            if (damageDealt <= 0)
                            {
                                player.Health -= damageDealt;
                            }
                            else if (damageDealt > 0)
                            {
                                damageDealt -= player.ResistanceToPhysical;
                                roundBot.PhysicalDamage += damageDealt;
                                player.Health -= damageDealt;
                            }

                            //Result
                            PrintManager.printAttackBot(player, bot, damageDealt);
                            Console.WriteLine();
                        }


                        else if (selectedAttack == Attack.Magical)
                        {
                            damageDealt = bot.AttackPow(selectedAttack, bot.AttackPower);
                            if (damageDealt <= 0)
                            {
                                player.Health -= damageDealt;
                            }
                            else if (damageDealt > 0)
                            {
                                damageDealt -= player.ResistanceToMagical;
                                roundBot.MagicDamage += damageDealt;
                                player.Health -= damageDealt;
                            }

                            //Result
                            PrintManager.printAttackBot(player, bot, damageDealt);
                            Console.WriteLine();
                        }
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot

                        bot.ResistanceToPhysical += 5;
                        bot.ResistanceToMagical += 5;
                        PrintManager.printDefendsBot(bot);
                        Console.WriteLine();

                    }
                    currentPlayer = (currentPlayer % 2) + 1;
                    countShop++;
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
                        // Choose the attack type 
                        PrintManager.printMenuAttackType();

                    repeat4:
                        if (Int32.TryParse(Console.ReadLine(), out AttackType) == false || AttackType == 0 || AttackType > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeat4;
                        }

                        if (AttackType == 1)
                        {
                            selectedAttack = Attack.Physical;
                        }
                        else
                        {
                            selectedAttack = Attack.Magical;
                        }

                        // Calculate the damage dealt by the current player

                        if (selectedAttack == Attack.Physical)
                        {
                            damageDealt = player.AttackPow(selectedAttack, player.AttackPower);
                            if (damageDealt <= 0)
                            {
                                bot.Health -= damageDealt;
                            }
                            else if (damageDealt > 0)
                            {
                                damageDealt -= bot.ResistanceToPhysical;
                                roundPlayer.PhysicalDamage += damageDealt;
                                bot.Health -= damageDealt;
                            }

                            //Result
                            PrintManager.printAttackPlayer1(player, bot, damageDealt);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                        }


                        else if (selectedAttack == Attack.Magical)
                        {
                            damageDealt = player.AttackPow(selectedAttack, player.AttackPower);
                            if (damageDealt <= 0)
                            {
                                bot.Health -= damageDealt;
                            }
                            else if (damageDealt > 0)
                            {
                                damageDealt -= bot.ResistanceToMagical;
                                roundPlayer.MagicDamage += damageDealt;
                                bot.Health -= damageDealt;
                            }

                            //Result
                            PrintManager.printAttackPlayer1(player, bot, damageDealt);
                            PrintManager.printStatistic(player);
                            Console.WriteLine();
                        }
                    }

                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the current player
                        if (count > 3)
                        {
                            Console.WriteLine("You have reached the limit");
                            goto repeat3;
                        }

                        player.ResistanceToPhysical += 5;
                        player.ResistanceToMagical += 5;
                        PrintManager.printDefendsPlayer1(player);
                        PrintManager.printStatistic(player);
                        Console.WriteLine();
                        count++;
                    }

                    // Switch to the next player
                    currentPlayer = (currentPlayer % 2) + 1;
                    countShop++;
                }
                // Declare the winner
                PrintManager.printWinnerWithBot(player, bot, roundPlayer, roundBot);
                Console.WriteLine();
            }
        }
    }
}