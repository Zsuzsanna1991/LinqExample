using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkexamples
{
    internal class Program
    {
        public static List<Game> games = new List<Game>
         {
             new Game{Title = "Legend of Zelda", Genre = "Rpg", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
             new Game{Title = "Super Mario Bros", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50 },
             new Game{Title = "Elden Ring", Genre = "Rpg", ReleaseYear = 2022, Rating = 9.8, Price = 70 },
             new Game{Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
             new Game{Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 },
         };
        static void Main(string[] args)
        {
            //Csoportosítsunk műfajonként játékokat
            var groupByGenre = games.GroupBy(x => x.Genre);

            foreach (var group in groupByGenre)
            {
                Console.WriteLine(group.Key + ": ");

                int db = 0;
                foreach (var game in group)
                {
                    db++;
                }

                Console.WriteLine(db);
            }


            //Legdrágább játék adatainak a kiszűrése

            /*var mostExpensiveGamePrice = games.Max(x => x.Price);
            var mostExpensiveGame = games.Where(x => x.Price == mostExpensiveGamePrice);

            foreach (var item in mostExpensiveGame)
            {
                Console.WriteLine(item.Title);
            }*/



            //Játékok átlagárának kiszámítása

            /*var avgPrice = games.Average(x => x.Price);
            Console.WriteLine(avgPrice);*/


            //4. Lista elemeinek rendezése csökkenőbe Descending függvényt is hozzákell adni, a növekvő alapértelmezett.

            /*var sortedByYear = games.OrderByDescending(x => x.ReleaseYear);

            foreach (var game in sortedByYear)
            {
                Console.WriteLine(game.Title + " - " + game.ReleaseYear);
            }*/


            //3. Döntsük el, hogy van-e játék, amit 1984-ben adtak ki
            /*var gameRelease = games.Any(x => x.ReleaseYear == 1984);
            Console.WriteLine(gameRelease);*/


            //2. Összes Rpg műfajú játék

            /*var rpgGames = games.Where(x => x.Genre == "Rpg");

            foreach (var item in rpgGames)
            {
                Console.WriteLine(item.Title + " - " + item.Genre);
            }*/



            //1. Összes Title tulajdonság a listából

            /*var gameTitles = games.Select(x => new {Title = x.Title, Price = x.Price});

            foreach (var item in gameTitles)
            {
                Console.WriteLine(item);
            }*/

        }
    }
}
