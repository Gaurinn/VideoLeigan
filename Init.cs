using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    class Init
    {
        public static List<Movies> CreateListOfMovies()
        {
            var movies = new List<Movies>();

            var titanic = new Movies();
            titanic.movieId = 1;
            titanic.title = " The Titanic";
            titanic.cost = 550;
            titanic.isAvailable = true;
            movies.Add(titanic);

            var shawshank = new Movies();
            shawshank.movieId = 2;
            shawshank.title = "Shawshank";
            shawshank.cost = 550;
            shawshank.isAvailable = false;
            movies.Add(shawshank);

            var godfather2 = new Movies();
            godfather2.movieId = 3;
            godfather2.title = "The Godfather 2";
            godfather2.cost = 550;
            godfather2.isAvailable = true;
            movies.Add(godfather2);

            var pulpf = new Movies();
            pulpf.movieId = 4;
            pulpf.title = "Pulp Fiction";
            pulpf.cost = 550;
            pulpf.isAvailable = true;
            movies.Add(pulpf);

            var angrym12 = new Movies();
            angrym12.movieId = 5;
            angrym12.title = "12 Angry Men";
            angrym12.cost = 550;
            angrym12.isAvailable = true;
            movies.Add(angrym12);

            var tgbu = new Movies();
            tgbu.movieId = 6;
            tgbu.title = "The Good One";
            tgbu.cost = 550;
            tgbu.isAvailable = true;
            movies.Add(tgbu);

            var godfather = new Movies();
            godfather.movieId = 7;
            godfather.title = "The Godfather";
            godfather.cost = 550;
            godfather.isAvailable = true;
            movies.Add(godfather);

            var batman = new Movies();
            batman.movieId = 8;
            batman.title = "The Dark Knight";
            batman.cost = 550;
            batman.isAvailable = true;
            movies.Add(batman);

            var schindler = new Movies();
            schindler.movieId = 9;
            schindler.title = "Schindlers List";
            schindler.cost = 550;
            schindler.isAvailable = true;
            movies.Add(schindler);

            var fight = new Movies();
            fight.movieId = 10;
            fight.title = "Fight Club";
            fight.cost = 550;
            fight.isAvailable = true;
            movies.Add(fight);

            return movies;
        }
    }
}