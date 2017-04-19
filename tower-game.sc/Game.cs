using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class Game {
        public static void Main(string[] args) {
            Map map = new Map(8,5);

            int area = map.Width * map.Height;
            Console.WriteLine(area);

            Point point = new Point(12,2);

            try {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);

            Console.ReadKey();
        }
    }
}
