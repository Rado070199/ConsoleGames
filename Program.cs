using System.Data;
using SnakeConsolGame.Snake;
using TictacteoConsoleGame.Tictacteo;
using PokerConsoleGames.Poker;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeScrean();
        }

        static void WelcomeScrean()
        {
            int gameSelection = 0;

            Console.WriteLine("Here is the list of games avaliable on our system:\n");
            Console.WriteLine("1. Snake");
            Console.WriteLine("2. TicTacTeo");
            Console.WriteLine("2. Poker\n");
            Console.Write("Select a Game 1-2: ");
            gameSelection = int.Parse( Console.ReadLine() );
            Console.Clear();

            switch (gameSelection)
                {
                case 1:
                    SnakeGame.Snake();
                    break;
                case 2:
                    TictacteoGame.Tictacteo();
                    break; ;
                case 3:
                    PokerGame.Poker();
                    break;
                    
            }
        }
    }
}