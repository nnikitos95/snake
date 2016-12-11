using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walls;
        public Walls(int W,int H)
        {
            walls = new List<Figure>();
            HorizontalLine hltop = new HorizontalLine(0, W - 1, H - 1, '+');
            VerticalLine vlleft = new VerticalLine(0, H - 1, 0, '+');
            HorizontalLine hlbottom = new HorizontalLine(0, W - 1, 0, '+');
            VerticalLine vlright = new VerticalLine(0, H - 1, W - 1, '+');
            walls.Add(hltop);
            walls.Add(vlleft);
            walls.Add(hlbottom);
            walls.Add(vlright);
        }
        public void Draw()
        {
            foreach (var wall in walls) wall.Draw();
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in walls)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }
    }
}
