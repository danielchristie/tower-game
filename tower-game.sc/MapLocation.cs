﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class MapLocation : Point {
        public MapLocation(int x, int y, Map map) : base(x, y) {
            if (!map.OnMap(this)) {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundary of the game map!");
            }
        }
    }
}
