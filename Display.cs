using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    class Display
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Video Leigan\n");
            Console.WriteLine("1. Register a new customer");
            Console.WriteLine("2. Register a new movie");
            Console.WriteLine("3. Display all movies");
            Console.WriteLine("4. Rent a movie");
            Console.WriteLine("5. Return a movie");
            Console.WriteLine("6. List of rented movies");
            Console.WriteLine("7. List of customer rentals");
            Console.WriteLine("8. Movie rental history");
            Console.WriteLine("9. Quit");
        }
    }
}