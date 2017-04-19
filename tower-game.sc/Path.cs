using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class Path {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path) {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep) {
            // using a Ternary statement inplace of an if/else
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
