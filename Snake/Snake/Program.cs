using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = Console.WindowHeight;
            int W = Console.WindowWidth;
            Console.SetBufferSize(W,H);
            Walls walls = new Walls(W, H);
            walls.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(W, H,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {

                    snake.clear();
                    food.Clear();
                    Console.SetCursorPosition(W/2-10, H / 2);
                    Console.WriteLine("Игра закончена");
                    Console.ReadLine();
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ChangeDirection(key);
                }
            }
           
        }
       
    }
}
