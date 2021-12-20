using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    class Program
    {
        static void Main(string[] args)
        {

           // var accounts = new List<Customer>();
            var display = new Display();
            var operations = new Operations();

            //var movies = new List<Movies>();

            var movies = Init.CreateListOfMovies();

            var accounts = Customerss.CreateListOfCustomers();


            int operation = 0;

            while (operation != 9)
            {
                display.Menu();
                operation = Convert.ToInt32(Console.ReadLine());

                if (operation == 1) // Register a new user
                {
                    Console.Clear();

                    var cust = operations.CreateAccount(accounts.Count + 1);
                    accounts.Add(cust);
                }
                if (operation == 2) // Create a new movie
                {
                    Console.Clear();

                    var mov = operations.CreateMovie(movies.Count + 1);
                    movies.Add(mov);
                }
                if (operation == 3) // Display all movies
                {
                    Console.Clear();

                    foreach (var m in movies)
                    {
                        Console.WriteLine("MovieId:{0} Title:{1}\tCost:{2}\tIs Available:{3}", m.movieId, m.title, m.cost, m.isAvailable, movies.IndexOf(m));
                    }
                }
                if (operation == 4) // Rent a movie
                {
                    Console.Clear();

                    foreach (var m in movies)
                    {
                        if (m.isAvailable)
                        { 
                        Console.WriteLine("MovieId:{0} Title:{1}\tCost:{2}\tIs Available:{3}", m.movieId, m.title, m.cost, m.isAvailable, movies.IndexOf(m));
                        }
                    }

                    bool available = false;
                    Console.WriteLine("Enter MovieId to rent movie");
                    Movies movie = null;
                    var selectedMovie = Convert.ToInt32(Console.ReadLine());
                    foreach (var m in movies)
                    {
                        if (m.movieId == selectedMovie)
                        {
                            if(m.isAvailable == false)
                            {
                                available = false;
                            }
                            else
                            {
                                m.isAvailable = false;
                                m.rented++;
                                movie = m;
                                available = true;
                            }
                        }
                    }
                    
                    if (available)
                    {   
                        Console.WriteLine("Enter UserId to rent movie");

                        foreach (var c in accounts)
                        {
                            Console.WriteLine("UserId:{0} Name:{1}\tPhone:{2}\tAddress:{3}", c.userId, c.name, c.phone, c.address);                        
                        }

                        Customer selectedUser = null;
                        var inputNr = Convert.ToInt32(Console.ReadLine());

                        foreach (var c in accounts)
                        {
                            if(c.userId == inputNr)
                            {
                                selectedUser = c;
                            }
                        }
                        selectedUser.history.Add(movie);
                    }
                    else
                    {
                        Console.WriteLine("Selected movie is not available");
                    }
                }

                if (operation == 5) // Return a movie
                {
                    Console.Clear();

                    foreach (var m in movies)
                    {
                        if (m.isAvailable == false)
                        {
                            Console.WriteLine("MovieId:{0} Title:{1}\tCost:{2}\tIs Available:{3}", m.movieId, m.title, m.cost, m.isAvailable, movies.IndexOf(m));
                        }
                    }

                    bool available = false;
                    Console.WriteLine("Enter MovieId to return movie");
                    Movies movie = null;
                    var selectedMovie = Convert.ToInt32(Console.ReadLine());
                    foreach (var m in movies)
                    {
                        if (m.movieId == selectedMovie)
                        {
                            if (m.isAvailable == true)
                            {
                                available = false;
                            }
                            else
                            {
                                m.isAvailable = true;
                                movie = m;
                                available = true;
                            }
                        }
                    }

                    if (available)
                    {
                        Console.WriteLine("Enter UserId to return movie");

                        foreach (var c in accounts)
                        {
                            Console.WriteLine("UserId:{0} Name:{1}\tPhone:{2}\tAddress:{3}", c.userId, c.name, c.phone, c.address);
                        }

                        Customer selectedUser = null;
                        var inputNr = Convert.ToInt32(Console.ReadLine());

                        foreach (var c in accounts)
                        {
                            if (c.userId == inputNr)
                            {
                                selectedUser = c;
                            }
                        }
                        selectedUser.history.Add(movie);
                    }
                    else
                    {
                        Console.WriteLine("Selected movie is not available");
                    }
                }

                if (operation == 6) // List of movies that are rented out (marked as isAvailable = false)
                {
                    Console.Clear();

                    foreach (var m in movies)
                    {
                        if (m.isAvailable == false)
                        { 
                        Console.WriteLine("MovieId:{0} Title:{1}\tCost:{2}\tIs Available:{3}", m.movieId, m.title, m.cost, m.isAvailable, movies.IndexOf(m));
                        }
                    }
                }

                if (operation == 7) // List of Customer rental History
                {
                    Console.Clear();

                    foreach (var c in accounts)
                    {
                        Console.WriteLine("UserId:{0} Name:{1}\tPhone:{2}\tAddress:{3}", c.userId, c.name, c.phone, c.address, accounts.IndexOf(c));
                    }

                    Console.WriteLine("Enter UserId to view customer rental history");
                    //enter account number to select account
                    Customer selectedAccounts = null;
                    var inputNr = Convert.ToInt32(Console.ReadLine());

                    foreach (var c in accounts)
                    {
                        if (c.userId == inputNr)
                        {
                            selectedAccounts = c;
                        }
                    }
                    foreach (var m in selectedAccounts.history)
                    {
                        Console.WriteLine("Title: {0}", m.title);
                    }
                    Console.ReadKey();
                }

                if (operation == 8) // List all Movies, enter movieId to select a movie, print number of time movie has been rented
                {
                    Console.Clear();

                    foreach (var m in movies)
                    {
                        Console.WriteLine("MovieId:{0} Title:{1}\tCost:{2}\tIs Available:{3}", m.movieId, m.title, m.cost, m.isAvailable, movies.IndexOf(m));
                    }

                    Console.WriteLine("Enter MovieId to view number of times movie has been rented");

                    Movies movie = null;
                    var selectedMovie = Convert.ToInt32(Console.ReadLine());
                    foreach (var m in movies)
                    {
                        if (m.movieId == selectedMovie)
                        {
                            Console.WriteLine("{0} has been rented {1} times", m.title, m.rented);
                        }
                    }
                }
            }
        }
    }
}