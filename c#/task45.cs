using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Web_Task45

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Game game1 = new Game("Halo", "Bungie", 4.5, 2001);

            Game game2 = new Game("Super Mario", "Nintendo", 4.0, 1983);

            Console.WriteLine(game1.title + " was made by " + game1.studio + " in " + game1.year);

            game2.rating = 4.3;

            Console.WriteLine(game2.title + " has a rating of " + game2.rating);

            Console.ReadLine();

        }

    }

}



namespace Web_Task45

{

    class Game

    {

        public string title;

        public string studio;

        public double rating;

        public int year;

        public Game(string argTitle, string argStudio, double argRating, int argYear)

        {

            title = argTitle;

            studio = argStudio;

            rating = argRating;

            year = argYear;

            Console.WriteLine("Storing Data for " + title + "\n");

        }

    }

}