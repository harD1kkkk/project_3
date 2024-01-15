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
            PrintManager.printMenuPlayer1();

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

                }
                else if (battlefield == 2)
                {
                    Console.WriteLine("Randomly choosed Forest");
                }
                else
                {
                    Console.WriteLine("Randomly choose Desert");
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
                        Console.WriteLine();
                        count++;
                    }

                    // Switch to the next player
                    currentPlayer = (currentPlayer % 2) + 1;
                    countShop++;

                    // Declare the winner
                    PrintManager.printWinnerWithBot(player, bot, roundPlayer, roundBot);
                }

            }
        }
    }
}