namespace Myspace
{
    static class PrintManager
    {
        public static void printMenuPlayer1()
        {
            Console.WriteLine("Player 1, choose your character:", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.WriteLine("1. Mage", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("2. Archer", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("3. Warrior", Console.ForegroundColor = ConsoleColor.DarkRed); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printMenuPlayer2()
        {
            Console.WriteLine("Player 2, choose your character:", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("1. Mage", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("2. Archer", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("3. Warrior", Console.ForegroundColor = ConsoleColor.DarkRed); Console.ForegroundColor = ConsoleColor.White;
        }


        public static void printMenuBattlefield()
        {
            Console.WriteLine("Choose the battlefield:", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("1. Storm", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.WriteLine("2. Forest", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("3. Desert", Console.ForegroundColor = ConsoleColor.DarkYellow); Console.ForegroundColor = ConsoleColor.White;
        }


        public static void printMenuAction()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("2. Defend", Console.ForegroundColor = ConsoleColor.DarkBlue); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printMenuAttackType()
        {
            Console.WriteLine("Choose the attack type: 1 - Physical, 2 - Magical", Console.ForegroundColor = ConsoleColor.Yellow); Console.ForegroundColor = ConsoleColor.White;
        }


        public static void printAttackPlayer1(Hero player1, Hero player2, double damageDealt)
        {
            Console.WriteLine($"{player1.Name} attacks {player2.Name} for {damageDealt} damage.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"{player2.Name} Health {player2.Health}", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printAttackPlayer2(Hero player1, Hero player2, double damageDealt)
        {
            Console.WriteLine($"{player2.Name} attacks {player1.Name} for {damageDealt} damage.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"{player1.Name} Health {player1.Health}", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
        }


        public static void printDefendsPlayer1(Hero player1)
        {
            Console.WriteLine($"{player1.Name} defends and increases resistance.", Console.ForegroundColor = ConsoleColor.Cyan); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printDefendsPlayer2(Hero player2)
        {
            Console.WriteLine($"{player2.Name} defends and increases resistance.", Console.ForegroundColor = ConsoleColor.Cyan); Console.ForegroundColor = ConsoleColor.White;
        }




        public static void printWinner(Hero player1, Hero player2, Round round1, Round round2)
        {
            if (player1.Health <= 0)
            {
                Console.WriteLine($"Player 2: has won the battle! with character {player2.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"Player 2: All Physical Damage: {round2.PhysicalDamage} All Magical Damage {round2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Player 1: All Physical Damage: {round1.PhysicalDamage} All Magical Damage {round1.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (player2.Health <= 0)
            {
                Console.WriteLine($"Palyer 1: has won the battle! with character {player1.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"Player 1: All Physical Damage: {round1.PhysicalDamage} All Magical Damage {round1.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Player 2: All Physical Damage: {round2.PhysicalDamage} All Magical Damage {round2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
        }






        public static void printAttackBot(Hero player, Hero bot, double damageDealt)
        {
            Console.WriteLine($"Bot {bot.Name} attacks {player.Name} for {damageDealt} damage.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"{player.Name} Health {player.Health}", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printDefendsBot(Hero bot)
        {
            Console.WriteLine($"Bot {bot.Name} defends and increases resistance.", Console.ForegroundColor = ConsoleColor.Cyan); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printWinnerWithBot(Hero player, Hero bot, Round roundPlayer, Round roundBot)
        {
            if (player.Health <= 0)
            {
                Console.WriteLine($"Bot: has won the battle! with character {bot.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage: {roundBot.PhysicalDamage} All Magical Damage {roundBot.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Player: All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (bot.Health <= 0)
            {
                Console.WriteLine($"Player: has won the battle! with character {player.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Bot: All Physical Damage: {roundBot.PhysicalDamage} All Magical Damage {roundBot.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void printStatistic(Hero player)
        {
            Console.WriteLine($"Health: {player.Health}", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine($"Attack Power: {player.AttackPower}", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"Critical chance: {player.CriticalChance}", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine($"Resistance To Physical: {player.ResistanceToPhysical}", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine($"Resistance To Magical: {player.ResistanceToMagical}", Console.ForegroundColor = ConsoleColor.Blue); Console.ForegroundColor = ConsoleColor.White;
        }


        public static void printShop(Hero player, int choiceShop)
        {
            if (choiceShop == 1)
            {
                player.Health += 20;
                Console.WriteLine("You choosed: +20 health", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choiceShop == 2)
            {
                player.ResistanceToPhysical += 3;
                Console.WriteLine("You choosed: +3 Resistance To Physical", Console.ForegroundColor = ConsoleColor.Cyan); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choiceShop == 3)
            {
                player.ResistanceToMagical += 3;
                Console.WriteLine("You choosed: +3 Resistance To Magical", Console.ForegroundColor = ConsoleColor.Blue); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choiceShop == 4)
            {
                player.CriticalChance += 15;
                Console.WriteLine("You choosed: +15 Critical chance", Console.ForegroundColor = ConsoleColor.Yellow); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choiceShop == 5)
            {
                player.AttackPower += 10;
                Console.WriteLine("You choosed: +10 Attack Power", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
        }


        public static void ShopMenuBot(Hero player, Hero bot)
        {
        repeatShop:
            Console.WriteLine("Player: Your statistic");
            printStatistic(player);
            Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
            if (Int32.TryParse(Console.ReadLine(), out int choiceShop) == false || choiceShop == 0 || choiceShop > 6)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeatShop;
            }

            printShop(player, choiceShop);
            Console.WriteLine();

            Console.WriteLine("Bot: statistic");
            printStatistic(bot);
            BotLogic.botLogicShop(bot);
            Console.WriteLine();
        }


        public static void ShopMenuPlayervsPlayer(Hero player1, Hero player2)
        {
            Console.WriteLine("Player 1: Your statistic");
            printStatistic(player1);
            Console.WriteLine();

        repeatShop1:
            Console.WriteLine("Player 1 choose 1 item!");
            Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
            if (Int32.TryParse(Console.ReadLine(), out int choiceShop1) == false || choiceShop1 == 0 || choiceShop1 > 6)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeatShop1;
            }

            PrintManager.printShop(player1, choiceShop1);
            Console.WriteLine();


            Console.WriteLine("Player 2: Your statistic");
            printStatistic(player2);
            Console.WriteLine();

        repeatShop2:
            Console.WriteLine("Player 2 choose 1 item!");
            Console.WriteLine("Choose 1 item: 1 - health, 2 - Resistance To Physical, 3 - Resistance To Magical, 4 - Critical chance, 5 - Attack Power");
            if (Int32.TryParse(Console.ReadLine(), out int choiceShop2) == false || choiceShop2 == 0 || choiceShop2 > 6)
            {
                Console.WriteLine("Error.You entered an incorrect value");
                goto repeatShop2;
            }

            printShop(player2, choiceShop2);
            Console.WriteLine();
        }




        public static void printMenuPlayer()
        {
            Console.WriteLine("Player, choose your character:", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.WriteLine("1. Mage", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("2. Archer", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("3. Warrior", Console.ForegroundColor = ConsoleColor.DarkRed); Console.ForegroundColor = ConsoleColor.White;
        }





        public static void printAttackBot1(Hero bot1, Hero bot2, double damageDealt)
        {
            Console.WriteLine($"Bot1 {bot1.Name} attacks {bot2.Name} for {damageDealt} damage.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"{bot2.Name} Health {bot2.Health}", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printAttackBot2(Hero bot1, Hero bot2, double damageDealt)
        {
            Console.WriteLine($"Bot2 {bot2.Name} attacks {bot1.Name} for {damageDealt} damage.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"{bot1.Name} Health {bot1.Health}", Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printWinnerBotvsBot(Hero bot1, Hero bot2, Round roundBot1, Round roundBot2)
        {
            if (bot2.Health <= 0)
            {
                Console.WriteLine($"Bot1: has won the battle! with character {bot1.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage: {roundBot1.PhysicalDamage} All Magical Damage {roundBot1.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Bot2: All Physical Damage: {roundBot2.PhysicalDamage} All Magical Damage {roundBot2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (bot1.Health <= 0)
            {
                Console.WriteLine($"Bot2: has won the battle! with character {bot2.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage: {roundBot2.PhysicalDamage} All Magical Damage {roundBot2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Bot1: All Physical Damage: {roundBot1.PhysicalDamage} All Magical Damage {roundBot1.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void printWinnerPlayerWithBotAndBot(Hero player, Hero bot1, Hero bot2, Round roundPlayer, Round roundBot1, Round roundBot2)
        {
            if (player.Health <= 0)
            {
                Console.WriteLine($"Bots: have won the battle! with characters:Bot1: {bot1.Name}, Bot2: {bot2.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage Bot1: {roundBot1.PhysicalDamage} All Magical Damage Bot1: {roundBot1.MagicDamage}, All Physical Damage Bot2: {roundBot2.PhysicalDamage} All Magical Damage Bot2: {roundBot2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"Player: All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
            else if (bot1.Health <= 0 && bot2.Health <= 0)
            {
                Console.WriteLine($"Player: has won the battle! with character {player.Name}", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine($"All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red);

                Console.WriteLine($"All Physical Damage Bot1: {roundBot1.PhysicalDamage} All Magical Damage Bot1: {roundBot1.MagicDamage}, All Physical Damage Bot2: {roundBot2.PhysicalDamage} All Magical Damage Bot2: {roundBot2.MagicDamage}", Console.ForegroundColor = ConsoleColor.Red); Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
