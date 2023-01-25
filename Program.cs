using System.Data;
using SnakeConsolGame.Snake;

namespace SnakeConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeScrean();
        }

        static void WelcomeScrean()
        {
            Console.BackgroundColor =ConsoleColor.DarkYellow;
            int gameSelection = 0;
            Console.WriteLine("Here is the list of games avaliable on our system:\n");
            Console.WriteLine("1. Snake");
            Console.WriteLine("2. Tic-Tac-Teo\n");
            Console.Write("Select a Game 1-2: ");
            gameSelection = int.Parse( Console.ReadLine() );
            Console.Clear();

            switch (gameSelection)
                {
                case 1:
                    SnakeGame.Snake();
                    break;
                case 2:
                    Console.WriteLine("Tic-Tac-Teo");
                    break;
                    
            }
        }
    }
}