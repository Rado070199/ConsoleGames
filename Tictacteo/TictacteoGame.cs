using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TictacteoConsoleGame.Tictacteo
{
    public class TictacteoGame
    {
        //making array and
        //by default I am providing 0-9 where no use of zero
        static char[] news = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set
        static int choice; //This holds the choice at which position user want to mark
        // The flag variable checks who has won if it's value is 1 then someone has won the match
        //if -1 then Match has Draw if 0 then match is still running
        static int flag = 0;
        public static void Tictacteo()
        {

            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function
                choice = int.Parse(Console.ReadLine());//Taking users choice
                // checking that position where user want to run is marked (with X or O) or not
                if (news[choice] != 'X' && news[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        news[choice] = 'O';
                        player++;
                        Console.ResetColor();
                    }
                    else
                    {
                        news[choice] = 'X';
                        player++;
                    }
                }
                else
                //If there is any possition where user want to run
                //and that is already marked then show message and load board again
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, news[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// calling of check win
            }
            while (flag != 1 && flag != -1);
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board();// getting filled board again
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Board method which creats board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", news[1], news[2], news[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", news[4], news[5], news[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", news[7], news[8], news[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (news[1] == news[2] && news[2] == news[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (news[4] == news[5] && news[5] == news[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (news[6] == news[7] && news[7] == news[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (news[1] == news[4] && news[4] == news[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (news[2] == news[5] && news[5] == news[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (news[3] == news[6] && news[6] == news[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (news[1] == news[5] && news[5] == news[9])
            {
                return 1;
            }
            else if (news[3] == news[5] && news[5] == news[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (news[1] != '1' && news[2] != '2' && news[3] != '3' && news[4] != '4' && news[5] != '5' && news[6] != '6' && news[7] != '7' && news[8] != '8' && news[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}
