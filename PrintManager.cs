using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
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


        public static void printWinner(Hero player1, Hero player2)
        {
            if (player1.Health <= 0)
            {
                Console.WriteLine($"player 2 has won the battle! with character {player2.Name}");
            }
            else if (player2.Health <= 0)
            {
                Console.WriteLine($"palyer 1 has won the battle! with character {player1.Name}");
            }
        }


    }
}
