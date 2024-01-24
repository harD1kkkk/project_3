using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Myspace
{
    public class Multplayer
    {
        public static void multplayer()
        {
            Round roundPlayer1 = new();
            Round roundPlayer2 = new();

            Round roundBot1 = new();
            Round roundBot2 = new();

            Hero? bot1 = null;
            Mage Botmage1 = new("Mage", 500, 35, 10, 20, 40);
            Archer Botarcher1 = new("Archer", 450, 40, 15, 10, 50);
            Warrior Botwarrior1 = new("Warrior", 600, 45, 30, 15, 20);

            Hero? bot2 = null;
            Mage Botmage2 = new("Mage", 500, 35, 10, 20, 40);
            Archer Botarcher2 = new("Archer", 450, 40, 15, 10, 50);
            Warrior Botwarrior2 = new("Warrior", 600, 45, 30, 15, 20);

            // Create the characters
            Mage mage1 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer1 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior1 = new("Warrior", 600, 45, 30, 15, 20);

            Mage mage2 = new("Mage", 500, 35, 10, 20, 40);
            Archer archer2 = new("Archer", 450, 40, 15, 10, 50);
            Warrior warrior2 = new("Warrior", 600, 45, 30, 15, 20);

        repeat1:
            PrintManager.printMenuPlayer1();

            if (Int32.TryParse(Console.ReadLine(), out int player1Choice) == false || player1Choice == 0 || player1Choice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat1;
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

        repeat2:
            PrintManager.printMenuPlayer2();
            if (Int32.TryParse(Console.ReadLine(), out int player2Choice) == false || player2Choice == 0 || player2Choice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeat2;
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


        repeatChoiceBot:
            Console.WriteLine("Chose bot: random - 1 or choose your own - 2");
            if (Int32.TryParse(Console.ReadLine(), out int BotChoice) == false || BotChoice == 0 || BotChoice > 2)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeatChoiceBot;
            }
            if (BotChoice == 1)
            {
                Random botChoice = new();
                int botchoice = botChoice.Next(1, 4);
                switch (botchoice)
                {
                    case 1:
                        Console.WriteLine("Bot1: Choosed Mage");
                        bot1 = Botmage1;
                        break;
                    case 2:
                        Console.WriteLine("Bot1: Choosed Archer");
                        bot1 = Botarcher1;
                        break;
                    case 3:
                        Console.WriteLine("Bot1: Choosed Warrior");
                        bot1 = Botwarrior1;
                        break;
                }
                Random botChoice1 = new();
                int botchoice1 = botChoice1.Next(1, 4);
                switch (botchoice1)
                {
                    case 1:
                        Console.WriteLine("Bot: Choosed Mage");
                        bot2 = Botmage2;
                        break;
                    case 2:
                        Console.WriteLine("Bot: Choosed Archer");
                        bot2 = Botarcher2;
                        break;
                    case 3:
                        Console.WriteLine("Bot: Choosed Warrior");
                        bot2 = Botwarrior2;
                        break;
                }
            }
            else
            {

            repeat3:
                PrintManager.printChoseBot1();
                if (Int32.TryParse(Console.ReadLine(), out int playerChoice1) == false || playerChoice1 == 0 || playerChoice1 > 3)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                    goto repeat3;
                }
                switch (playerChoice1)
                {
                    case 1:
                        Console.WriteLine("Choosed mage");
                        bot1 = Botmage1;
                        break;
                    case 2:
                        Console.WriteLine("Choosed Archer");
                        bot1 = Botarcher1;
                        break;
                    case 3:
                        Console.WriteLine("Choosed Warrior");
                        bot1 = Botwarrior1;
                        break;
                }

            repeat4:
                PrintManager.printChoseBot2();
                if (Int32.TryParse(Console.ReadLine(), out int playerChoice2) == false || playerChoice2 == 0 || playerChoice2 > 3)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                    goto repeat4;
                }

                switch (playerChoice2)
                {
                    case 1:
                        Console.WriteLine("Choosed mage");
                        bot2 = Botmage2;
                        break;
                    case 2:
                        Console.WriteLine("Choosed Archer");
                        bot2 = Botarcher2;
                        break;
                    case 3:
                        Console.WriteLine("Choosed Warrior");
                        bot2 = Botwarrior2;
                        break;
                }
            }


        // Let the players choose the battlefield
        repeatChoiceBattlefield:
            Console.WriteLine("battlefield selection: random - 1 or choose your own - 2");
            if (Int32.TryParse(Console.ReadLine(), out int BattlefieldChoice) == false || BattlefieldChoice == 0 || BattlefieldChoice > 2)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeatChoiceBattlefield;
            }

            if (BattlefieldChoice == 1)
            {
                Random Battlefield = new();
                int battlefield = Battlefield.Next(1, 4);
                if (battlefield == 1)
                {
                    Console.WriteLine("Randomly choosed Storm");
                    Location.Storm2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);

                }
                else if (battlefield == 2)
                {
                    Console.WriteLine("Randomly choosed Forest");
                    Location.Forest2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);
                }
                else
                {
                    Console.WriteLine("Randomly choose Desert");
                    Location.Desert2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);
                }
            }

            else
            {
            repeatBattlefield:
                PrintManager.printMenuBattlefield();
                Console.WriteLine("Choose map: ");
                if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice == 0 || choice > 3)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                    goto repeatBattlefield;
                }


                // Apply the battlefield modifiers to the characters
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choosed Storm");
                        Location.Storm2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);
                        break;
                    case 2:
                        Console.WriteLine("Choosed Forest");
                        Location.Forest2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);
                        break;
                    case 3:
                        Console.WriteLine("Choosed Desert");
                        Location.Desert2VS2(mage1, mage2, archer1, archer2, warrior1, warrior2, Botmage1, Botmage2, Botarcher1, Botarcher2, Botwarrior1, Botwarrior2);
                        break;
                }
            }


            // Choose the first player randomly
            Random random = new();
            int currentPlayer = random.Next(1, 5);
            int countShop = 0;
            int countBot1 = 0;
            int countBot2 = 0;
            int count1 = 0;
            int count2 = 0;

            while (player1?.Health >= 0 || player2?.Health >= 0 && bot1?.Health >= 0 || bot2?.Health >= 0)
            {
                int actionBot;
                Attack selectedAttack;
                if (countShop == 5)
                {
                repeatShop1:
                    Console.WriteLine("Player1: Your statistic");
                    PrintManager.printStatistic(player1);
                    Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
                    if (Int32.TryParse(Console.ReadLine(), out int choiceShop1) == false || choiceShop1 == 0 || choiceShop1 > 6)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeatShop1;
                    }

                    PrintManager.printShop(player1, choiceShop1);
                    Console.WriteLine();


                repeatShop2:
                    Console.WriteLine("Player2: Your statistic");
                    PrintManager.printStatistic(player2);
                    Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
                    if (Int32.TryParse(Console.ReadLine(), out int choiceShop2) == false || choiceShop2 == 0 || choiceShop2 > 6)
                    {
                        Console.WriteLine("Error.You entered an incorrect value");
                        goto repeatShop2;
                    }

                    PrintManager.printShop(player2, choiceShop2);
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
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player1);
                    Console.WriteLine();

                repeat5:
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
                        goto repeat5;
                    }
                    if (choice == 1 && bot1.Health <= 0)
                    {
                        Console.WriteLine("Bot1 is already dead");
                        goto repeat5;
                    }
                    else if (choice == 2 && bot2.Health <= 0)
                    {
                        Console.WriteLine("Bot2 is already dead");
                        goto repeat5;
                    }

                    if (choice == 1)
                    {
                    repeatAction:
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeatAction;
                        }

                        Console.WriteLine();


                        if (action == 1)
                        {
                        repeatAttackType:
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeatAttackType;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player1, bot1, roundPlayer1);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count1 == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeatAction;
                            }
                            PrintManager.printDefend(player1);
                            PrintManager.printDefendsPlayer1(player1);
                            count1++;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                    repeatAction:
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeatAction;
                        }

                        Console.WriteLine();


                        if (action == 1)
                        {
                        repeatAttackType:
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeatAttackType;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player1, bot2, roundPlayer1);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count1 == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeatAction;
                            }
                            PrintManager.printDefend(player1);
                            PrintManager.printDefendsPlayer1(player1);
                            count1++;
                            Console.WriteLine();
                        }
                    }
                }


                else if (currentPlayer == 2)
                {
                    Console.WriteLine("Your statistic");
                    PrintManager.printStatistic(player2);
                    Console.WriteLine();

                repeat5:
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
                        goto repeat5;
                    }
                    if (choice == 1 && bot1.Health <= 0)
                    {
                        Console.WriteLine("Bot1 is already dead");
                        goto repeat5;
                    }
                    else if (choice == 2 && bot2.Health <= 0)
                    {
                        Console.WriteLine("Bot2 is already dead");
                        goto repeat5;
                    }

                    if (choice == 1)
                    {
                    repeatAction:
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeatAction;
                        }

                        Console.WriteLine();


                        if (action == 1)
                        {
                        repeatAttackType:
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeatAttackType;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player2, bot1, roundPlayer2);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count2 == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeatAction;
                            }
                            PrintManager.printDefend(player2);
                            PrintManager.printDefendsPlayer1(player2);
                            count2++;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                    repeatAction:
                        PrintManager.printMenuAction();

                        if (Int32.TryParse(Console.ReadLine(), out int action) == false || action == 0 || action > 2)
                        {
                            Console.WriteLine("Error.You entered an incorrect value");
                            goto repeatAction;
                        }

                        Console.WriteLine();


                        if (action == 1)
                        {
                        repeatAttackType:
                            PrintManager.printMenuAttackType();

                            if (Int32.TryParse(Console.ReadLine(), out int AttackType) == false || AttackType == 0 || AttackType > 2)
                            {
                                Console.WriteLine("Error.You entered an incorrect value");
                                goto repeatAttackType;
                            }

                            selectedAttack = PrintManager.printAttackType(AttackType);
                            PrintManager.printActionPlayer(selectedAttack, player2, bot2, roundPlayer2);
                        }

                        else if (action == 2) // Defend
                        {
                            // Increase the resistance of the current player
                            if (count2 == 3)
                            {
                                Console.WriteLine("You have reached the limit");
                                goto repeatAction;
                            }
                            PrintManager.printDefend(player2);
                            PrintManager.printDefendsPlayer1(player2);
                            count2++;
                            Console.WriteLine();
                        }
                    }
                }


                else if (currentPlayer == 3)
                {
                    int choicePlayer;

                    if (countBot1 == 3)
                    {
                        actionBot = 1;
                    }

                    else
                    {
                        actionBot = BotLogic.botLogicBotVSPlayerVsPlayer(player1, player2, bot1);
                    }

                        choicePlayer = BotLogic.choosePlayer(player1, player2, bot1);
                    
              

                    if (choicePlayer == 1)
                    {
                        if (actionBot == 1)
                        {
                            selectedAttack = PrintManager.printAttackTypeBot(bot1, Botmage1, Botarcher1);
                            PrintManager.printActionBot(selectedAttack, bot1, player1, roundBot1);
                        }

                        else if (actionBot == 2) // Defend
                        {
                            // Increase the resistance of the Bot
                            PrintManager.printDefend(bot1);
                            PrintManager.printDefendsBot(bot1);
                            countBot1++;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (actionBot == 1)
                        {
                            selectedAttack = PrintManager.printAttackTypeBot(bot1, Botmage1, Botarcher1);
                            PrintManager.printActionBot(selectedAttack, bot1, player2, roundBot1);
                        }

                        else if (actionBot == 2) // Defend
                        {
                            // Increase the resistance of the Bot
                            PrintManager.printDefend(bot1);
                            PrintManager.printDefendsBot(bot1);
                            countBot2++;
                            Console.WriteLine();
                        }
                    }
                }


                else if (currentPlayer == 4)
                {
                    int choicePlayer;

                    if (countBot2 == 3)
                    {
                        actionBot = 1;
                    }

                    else
                    {
                        actionBot = BotLogic.botLogicBotVSPlayerVsPlayer(player1, player2, bot2);
                    }

                    choicePlayer = BotLogic.choosePlayer(player1, player2, bot2);



                    if (choicePlayer == 1)
                    {
                        if (actionBot == 1)
                        {
                            selectedAttack = PrintManager.printAttackTypeBot(bot2, Botmage2, Botarcher2);
                            PrintManager.printActionBot(selectedAttack, bot2, player1, roundBot2);
                        }

                        else if (actionBot == 2) // Defend
                        {
                            // Increase the resistance of the Bot
                            PrintManager.printDefend(bot2);
                            PrintManager.printDefendsBot(bot2);
                            countBot2++;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (actionBot == 1)
                        {
                            selectedAttack = PrintManager.printAttackTypeBot(bot2, Botmage2, Botarcher2);
                            PrintManager.printActionBot(selectedAttack, bot2, player2, roundBot2);
                        }

                        else if (actionBot == 2) // Defend
                        {
                            // Increase the resistance of the Bot
                            PrintManager.printDefend(bot2);
                            PrintManager.printDefendsBot(bot2);
                            countBot2++;
                            Console.WriteLine();
                        }
                    }
                }


                // Switch to the next player
                if (player1?.Health > 0 && player2?.Health > 0 && bot1?.Health > 0 && bot2?.Health > 0)
                {
                    currentPlayer = (currentPlayer % 4) + 1;
                }

                else if ((currentPlayer == 1 && player1?.Health <= 0) || (currentPlayer == 2 && player2?.Health <= 0) || (currentPlayer == 3 && bot1?.Health <= 0) || (currentPlayer == 4 && bot2?.Health <= 0))
                {
                    currentPlayer = (currentPlayer % 3) + 1;
                }

                else if ((currentPlayer == 1 && player1?.Health <= 0 && player2?.Health <= 0) || (currentPlayer == 2 && player1?.Health <= 0 && player2?.Health <= 0) || (currentPlayer == 3 && bot1?.Health <= 0 && bot2?.Health <= 0) || (currentPlayer == 4 && bot1?.Health <= 0 && bot2?.Health <= 0))
                {
                    currentPlayer = (currentPlayer % 2) + 1;
                }

                else if (currentPlayer == 1 && player1?.Health <= 0 && player2?.Health <= 0 && bot1?.Health <= 0)
                {
                    currentPlayer = 4;
                }

                else if (currentPlayer == 2 && player1?.Health <= 0 && player2?.Health <= 0 && bot2?.Health <= 0)
                {
                    currentPlayer = 3;
                }

                else if (currentPlayer == 3 && player1?.Health <= 0 && bot1?.Health <= 0 && bot2?.Health <= 0)
                {
                    currentPlayer = 2;
                }

                else if (currentPlayer == 4 && player2?.Health <= 0 && bot1?.Health <= 0 && bot2?.Health <= 0)
                {
                    currentPlayer = 1;
                }


                // Declare the winner
                PrintManager.printWinnerPlayerWithPlayerVSBotAndBot(player1, player2, bot1, bot2, roundPlayer1, roundPlayer2, roundBot1, roundBot2);
                Console.WriteLine();
            }
        }
    }
}
