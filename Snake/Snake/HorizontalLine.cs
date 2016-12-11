using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xL,int xR,int y,char sym)
        {
            pList = new List<Point>();
            for(int x = xL; x < xR; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }
    }
}
