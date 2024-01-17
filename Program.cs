// See https://aka.ms/new-console-template for more information
namespace Myspace;

public enum Attack
{
    Physical,
    Magical
}
public enum Action
{
    Attack,
    Defend
}



class Program
{
    static void Main()
    {
        
        bool exit = true;
        while (exit)
        {
            Console.WriteLine("Make your choice:");
            Console.WriteLine("player vs player - 1");
            Console.WriteLine("player vs bot - 2");
            Console.WriteLine("exit - 3");
            if (Int32.TryParse(Console.ReadLine(), out int playerChoice) == false || playerChoice == 0 || playerChoice > 3)
            {
                Console.WriteLine("Error.You entered an incorrect value");
            }
            else if (playerChoice == 1)
            {
                StartPlayer.startPlayer();
            }
            else if(playerChoice == 2) 
            {
                StartBot.startBot();
            }
            else
            {
                Console.WriteLine("Goodbye!");
                exit = false;
            }
        }
    }
}