using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int h;
        private char v;
        private int w;
        Random random = new Random();

        public FoodCreator(int w, int h, char v)
        {
            this.w = w;
            this.h = h;
            this.v = v;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, w - 2);
            int y = random.Next(2, h - 2);
            return new Point(x, y, v);
        }
    }
}
