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
