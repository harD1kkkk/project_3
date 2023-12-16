// See https://aka.ms/new-console-template for more information


namespace Myspace;

enum Attack
{
    Physical,
    Magical
}
enum Action
{
    Attack,
    Defend
}



class Program
{
    static void Main(string[] args)
    {
        // Create the characters
        Mage mage1 = new Mage("Mage", 100, 25, 12, 15, 40);
        Archer archer1 = new Archer("Archer", 150, 20, 14, 20, 50);
        Warrior warrior1 = new Warrior("Warrior", 200, 30, 12, 15, 20);

        Mage mage2 = new Mage("Mage", 100, 25, 12, 15, 40);
        Archer archer2 = new Archer("Archer", 150, 20, 14, 20, 50);
        Warrior warrior2 = new Warrior("Warrior", 200, 30, 12, 15, 20);

        // Let the players choose their characters
        Console.WriteLine("Player 1, choose your character:");
        Console.WriteLine("1. Mage");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Warrior");
        int player1Choice = Int32.Parse(Console.ReadLine());
        Hero player1 = null;
        switch (player1Choice)
        {
            case 1:
                Console.WriteLine("Choosed Mage");
                player1 = mage1;
                break;
            case 2:
                Console.WriteLine("Choosed Archer");
                player1 = archer1;
                break;
            case 3:
                Console.WriteLine("Choosed Warrior");
                player1 = warrior1;
                break;
        }

        Console.WriteLine();

        Console.WriteLine("Player 2, choose your character:");
        Console.WriteLine("1. Mage");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Warrior");
        int player2Choice = Int32.Parse(Console.ReadLine());
        Hero player2 = null;
        switch (player2Choice)
        {
            case 1:
                Console.WriteLine("Choosed Mage");
                player2 = mage2;
                break;
            case 2:
                Console.WriteLine("Choosed Archer");
                player2 = archer2;
                break;
            case 3:
                Console.WriteLine("Choosed Warrior");
                player2 = warrior2;
                break;
        }

        Console.WriteLine();

        // Let the players choose the battlefield
        Console.WriteLine("Choose the battlefield:");
        Console.WriteLine("1. Storm");
        Console.WriteLine("2. Forest");
        Console.WriteLine("3. Desert");

        int choice = Int32.Parse(Console.ReadLine());
        // Apply the battlefield modifiers to the characters
        switch (choice)
        {
            case 1:
                Console.WriteLine("Choosed Storm");
                mage1.AttackPower += 10; // Mage gets extra damage in storm
                mage2.AttackPower += 10; // Mage gets extra damage in storm

                archer1.AttackPower -= 10; // Archer gets reduced damage in storm
                archer2.AttackPower -= 10; // Archer gets reduced damage in storm
                break;
            case 2:
                Console.WriteLine("Choosed Forest");
                archer1.CriticalChance += 10; // Archer gets extra critical chance in forest
                archer2.CriticalChance += 10; // Archer gets extra critical chance in forest 

                warrior1.ResistanceToPhysical += 10; // Warrior gets reduced dodge chance in forest
                warrior2.ResistanceToPhysical += 10; // Warrior gets reduced dodge chance in forest
                break;
            case 3:
                Console.WriteLine("Choosed Desert");
                warrior1.AttackPower += 10; // Warrior gets extra damage in desert
                warrior2.AttackPower += 10; // Warrior gets extra damage in desert

                mage1.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in desert
                mage2.ResistanceToMagical -= 10; // Mage gets reduced resistance to magical in desert
                break;
        }

        Console.WriteLine();

        // Start the battle
        Random random = new Random();

        // Choose the first player randomly
        int currentPlayer = random.Next(1, 3);

        while (player1.Health > 0 && player2.Health > 0)
        {
            Console.WriteLine("Current player: " + currentPlayer);
            Console.WriteLine();

            // Choose the action for the current player
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            int action = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            if (action == 1) // Attack
            {
                // Choose the attack type 
                Console.WriteLine("Choose the attack type: 1 - Physical, 2 - Magical");
                int AttackType = Int32.Parse(Console.ReadLine());
                Attack selectedAttack; 
                if (AttackType == 1)
                {
                    selectedAttack = Attack.Physical; 
                }
                else if (AttackType == 2)
                {
                    selectedAttack = Attack.Magical; 
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    return; 
                }

                // Calculate the damage dealt by the current player
                double damageDealt = 0;
                if (currentPlayer == 1)
                {
                    damageDealt = player1.AttackPow(selectedAttack, player1.AttackPower);
                    player2.Health -= damageDealt;
                    Console.WriteLine($"{player1.Name} attacks {player2.Name} for {damageDealt} damage.");
                    Console.WriteLine($"{player2.Name} Health {player2.Health}");
                    Console.WriteLine();
                }
                else if (currentPlayer == 2)
                {
                    damageDealt = player2.AttackPow(selectedAttack, player2.AttackPower);
                    player1.Health -= damageDealt;
                    Console.WriteLine($"{player2.Name} attacks {player1.Name} for {damageDealt} damage.");
                    Console.WriteLine($"{player1.Name} Health {player1.Health}");
                    Console.WriteLine();
                }
            }
            else if (action == 2) // Defend
            {
                // Increase the resistance of the current player
                if (currentPlayer == 1)
                {
                    player1.ResistanceToPhysical += 5;
                    player1.ResistanceToMagical += 5;
                    Console.WriteLine($"{player1.Name} defends and increases resistance.");
                }
                else if (currentPlayer == 2)
                {
                    player2.ResistanceToPhysical += 5;
                    player2.ResistanceToMagical += 5;
                    Console.WriteLine($"{player2.Name} defends and increases resistance.");
                }
            }

            // Switch to the next player
            currentPlayer = (currentPlayer % 2) + 1;


            // Declare the winner
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