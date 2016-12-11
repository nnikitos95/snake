﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
           /* Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(2, 5, '#');
            p1.Draw();
            p2.Draw();*/
            HorizontalLine hltop = new HorizontalLine(0,W-1,H-1,'+');
            VerticalLine vlleft = new VerticalLine(0, H-1, 0, '+');
            HorizontalLine hlbottom = new HorizontalLine(0, W - 1, 0, '+');
            VerticalLine vlright = new VerticalLine(0, H - 1, W-1, '+');
            hltop.Draw();
            vlleft.Draw();
            hlbottom.Draw();
            vlright.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            Console.ReadLine();
            
           
        }
       
    }
}
