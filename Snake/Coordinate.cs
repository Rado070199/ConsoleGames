using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsolGame.Snake
{
    public class Coordinate
    {
        public Coordinate()
        {
            Y = 0;
            X = 0;
        }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
