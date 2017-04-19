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
            Console.WriteLine("Area is " + area);

            Point point = new Point(5,2);

            try {
                Path path = new sc.Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );
                MapLocation location = path.GetLocationAt(2);
                if (location != null) {
                    Console.WriteLine("Location X: " + location.X + "\nLocation Y: " + location.Y);
                }
            }

            catch(OutOfBoundsException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException) {
                Console.WriteLine("The coordinates provided is beyond the game boundaries!");
            }
            catch (Exception ex) {
                Console.WriteLine("Unhandled Exception: " + ex);
            }

            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);

            string[] favoriteThings = { "Hello", "Hi", "Goodday" };
            Console.WriteLine(favoriteThings.Length);
            Console.WriteLine("You said: " + favoriteThings[1]);
            foreach (var i in favoriteThings) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
