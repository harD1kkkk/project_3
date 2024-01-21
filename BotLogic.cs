using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System;
using static System.Collections.Specialized.BitVector32;

namespace Myspace
{
    public static class BotLogic
    {
        public static int botLogicVSPlayer(Hero player, Hero bot)
        {
            int action;
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
            else { action = 1; }
            return action;
        }


        public static int botLogicBot1VSBot2(Hero bot1, Hero bot2)
        {
            int action;
            if (bot1.Health >= 200 && bot2.Health < bot1.Health)
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
            else if (bot1.Health <= 100 || bot2.Health > bot1.Health)
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
            else if (bot2.Health <= 50 || bot1.Health <= 50)
            {
                action = 1;
            }
            else { action = 1; }
            return action;
        }

        public static int botLogicBot2VSBot1(Hero bot1, Hero bot2)
        {
            int action;
            if (bot2.Health >= 200 && bot1.Health < bot2.Health)
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
            else if (bot2.Health <= 100 || bot1.Health > bot2.Health)
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
            else if (bot1.Health <= 50 || bot2.Health <= 50)
            {
                action = 1;
            }
            else { action = 1; }
            return action;
        }




        public static Attack botLogicChoiceMage(Hero bot)
        {
            Attack selectedAttack;
            if (bot.Health >= 400)
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
            else
            {
                selectedAttack = Attack.Magical;
            }
            return selectedAttack;
        }

        public static Attack botLogicChoiceArcher(Hero bot)
        {
            Attack selectedAttack;
            if (bot.Health >= 400)
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
            else
            {
                selectedAttack = Attack.Physical;
            }
            return selectedAttack;
        }

        public static Attack botLogicChoiceWarrior(Hero bot)
        {
            Attack selectedAttack;
            if (bot.Health >= 500)
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
            else
            {
                selectedAttack = Attack.Physical;
            }
            return selectedAttack;
        }




        public static void botLogicShop(Hero bot)
        {
            Random botChoiceShop = new();
            int botchoiceshop = botChoiceShop.Next(1, 3);
            if (bot.Health <= 100)
            {
                Console.WriteLine("Bot choosed: +20 health", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
                bot.Health += 20;
            }
            else if (bot.ResistanceToPhysical <= 10)
            {
                Console.WriteLine("Bot choosed: +3 Resistance To Physical", Console.ForegroundColor = ConsoleColor.Cyan); Console.ForegroundColor = ConsoleColor.White;
                bot.ResistanceToPhysical += 3;
            }
            else if (bot.ResistanceToMagical <= 10)
            {
                Console.WriteLine("Bot choosed: +3 Resistance To Magical", Console.ForegroundColor = ConsoleColor.Blue); Console.ForegroundColor = ConsoleColor.White;
                bot.ResistanceToMagical += 3;
            }
            else if (botchoiceshop <= 50)
            {
                Console.WriteLine("Bot choosed: +15 Critical chance", Console.ForegroundColor = ConsoleColor.Yellow); Console.ForegroundColor = ConsoleColor.White;
                bot.CriticalChance += 15;
            }
            else if (botchoiceshop > 50)
            {
                Console.WriteLine("Bot choosed: +10 Attack Power", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
                bot.AttackPower += 10;
            }
        }
    }
}