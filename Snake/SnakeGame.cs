using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsolGame.Snake
{
    public class SnakeGame
    {
        public static void Snake()
        {
            Console.CursorVisible = false;
            bool exit = false;
            double frameRate = 1000 / 4.0;
            DateTime lastDate = DateTime.Now;
            Meal meal = new Meal();
            Snake snake = new Snake();

            //game loop
            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                    switch (input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.Direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snake.Direction = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            snake.Direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            snake.Direction = Direction.Down;
                            break;
                    }
                }

                if ((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    //game action
                    snake.Move();

                    if (meal.CurrentTarget.X == snake.HeadPosition.X && meal.CurrentTarget.Y == snake.HeadPosition.Y)
                    {
                        snake.EatMeal();
                        meal = new Meal();
                        frameRate /= 1.1;
                    }

                    if (snake.GameOver)
                    {
                        Console.Clear();
                        Console.WriteLine($"GAME OVER. YOUR SCORE:{snake.Lenght - 5}");
                        exit = true;
                        Console.ReadLine();
                    }

                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
