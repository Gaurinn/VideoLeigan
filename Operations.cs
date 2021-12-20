using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    class Operations
    {
        public void AccountOperations(Customer cust)
        {
            const int QUIT = 5;
            int operation = 0;
            while (operation != QUIT)
            {
                operation = Convert.ToInt32(Console.ReadLine());

                if (operation == 1)
                {
                    Console.WriteLine("Account name: {0}", cust.name);
                }
            }
        }

        public Customer CreateAccount(int nr)
        {
            var cust = new Customer();

            Console.WriteLine("Enter new customer name");
            cust.name = Console.ReadLine();

            Console.WriteLine("Address:");
            cust.address = Console.ReadLine();

            Console.WriteLine("Phone number:");
            cust.phone = Console.ReadLine();

            //Console.WriteLine("Use this code to rent movies: {0}", cust.privatePropCode());

            cust.userId = nr;

            return cust;
        }
        public Movies CreateMovie(int nr2)

        {
            var mov = new Movies();
            Console.WriteLine("Enter new movie title:");
            mov.title = Console.ReadLine();
            Console.WriteLine("Cost:");
            mov.cost = Convert.ToInt32(Console.ReadLine());

            mov.movieId = nr2;

            return mov;
        }
    }
}