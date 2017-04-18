using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class Point {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y) {
            // Using the Cartesian Distance formula to detect how 
            // far away two points on a map are from each other
            int xDiff = X - x;
            int yDiff = Y - Y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }
    }
}
