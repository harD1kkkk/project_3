namespace Myspace
{
    static class PrintManager
    {
        public static void printMenuPlayer1()
        {
            Console.WriteLine("Player 1, choose your character:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Archer");
            Console.WriteLine("3. Warrior");
        }

        public static void printMenuPlayer2()
        {
            Console.WriteLine("Player 2, choose your character:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Archer");
            Console.WriteLine("3. Warrior");
        }


        public static void printMenuBattlefield()
        {
            Console.WriteLine("Choose the battlefield:");
            Console.WriteLine("1. Storm");
            Console.WriteLine("2. Forest");
            Console.WriteLine("3. Desert");
        }


        public static void printMenuAction()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("2. Defend", Console.ForegroundColor = ConsoleColor.DarkBlue);Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printMenuAttackType()
        {
            Console.WriteLine("Choose the attack type: 1 - Physical, 2 - Magical");
        }


        public static void printAttackPlayer1(Hero player1, Hero player2, double damageDealt)
        {
            Console.WriteLine($"{player1.Name} attacks {player2.Name} for {damageDealt} damage.");
            Console.WriteLine($"{player2.Name} Health {player2.Health}");
        }

        public static void printAttackPlayer2(Hero player1, Hero player2, double damageDealt)
        {
            Console.WriteLine($"{player2.Name} attacks {player1.Name} for {damageDealt} damage.");
            Console.WriteLine($"{player1.Name} Health {player1.Health}");
        }


        public static void printDefendsPlayer1(Hero player1)
        {
            Console.WriteLine($"{player1.Name} defends and increases resistance.");
        }

        public static void printDefendsPlayer2(Hero player2)
        {
            Console.WriteLine($"{player2.Name} defends and increases resistance.");
        }


        public static void printWinner(Hero player1, Hero player2, Round round1, Round round2)
        {
            if (player1.Health <= 0)
            {
                Console.WriteLine($"Player 2: has won the battle! with character {player2.Name}");
                Console.WriteLine($"Player 2: All Physical Damage: {round2.PhysicalDamage} All Magical Damage {round2.MagicDamage}");

                Console.WriteLine($"Player 1: All Physical Damage: {round1.PhysicalDamage} All Magical Damage {round1.MagicDamage}");
            }
            else if (player2.Health <= 0)
            {
                Console.WriteLine($"Palyer 1: has won the battle! with character {player1.Name}");
                Console.WriteLine($"Player 1: All Physical Damage: {round1.PhysicalDamage} All Magical Damage {round1.MagicDamage}");

                Console.WriteLine($"Player 2: All Physical Damage: {round2.PhysicalDamage} All Magical Damage {round2.MagicDamage}");
            }
        }






        public static void printAttackBot(Hero player, Hero bot, double damageDealt)
        {
            Console.WriteLine($"Bot {bot.Name} attacks {player.Name} for {damageDealt} damage.");
            Console.WriteLine($"{player.Name} Health {player.Health}");
        }

        public static void printDefendsBot(Hero bot)
        {
            Console.WriteLine($"Bot {bot.Name} defends and increases resistance.");
        }

        public static void printWinnerWithBot(Hero player, Hero bot, Round roundPlayer, Round roundBot)
        {
            if (player.Health <= 0)
            {
                Console.WriteLine($"Bot has won the battle! with character {bot.Name}");
                Console.WriteLine($"All Physical Damage: {roundBot.PhysicalDamage} All Magical Damage {roundBot.MagicDamage}");

                Console.WriteLine($"Player: All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}");
            }
            else if (bot.Health <= 0)
            {
                Console.WriteLine($"player has won the battle! with character {player.Name}");
                Console.WriteLine($"All Physical Damage: {roundPlayer.PhysicalDamage} All Magical Damage {roundPlayer.MagicDamage}");

                Console.WriteLine($"Bot: All Physical Damage: {roundBot.PhysicalDamage} All Magical Damage {roundBot.MagicDamage}");
            }
        }

        public static void printStatistic(Hero player)
        {
            Console.WriteLine($"Health: {player.Health}", Console.ForegroundColor=ConsoleColor.Green);
            Console.WriteLine($"Attack Power: {player.AttackPower}", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($"Critical chance: {player.CriticalChance}", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine($"Resistance To Physical: {player.ResistanceToPhysical}", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine($"Resistance To Magical: {player.ResistanceToMagical}", Console.ForegroundColor = ConsoleColor.Blue);Console.ForegroundColor = ConsoleColor.White;
        }

        public static void printMenuPlayer()
        {
            Console.WriteLine("Player, choose your character:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Archer");
            Console.WriteLine("3. Warrior");
        }

    }
}
