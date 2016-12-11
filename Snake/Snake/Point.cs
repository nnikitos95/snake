using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x, y;
        private char sym;

        public Point(int x,int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int v, Direction direction)
        {
            switch (direction)
            {
                case Direction.DOWN: y += v; break;
                case Direction.UP: y -= v; break;
                case Direction.LEFT:x -= v; break;
                case Direction.RIGHT:x += v; break;
            }
        }

        public Point(Point tail)
        {
            this.x = tail.x;
            this.y = tail.y;
            this.sym = tail.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
