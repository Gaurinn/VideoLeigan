using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    public class Movies
    {
        public int movieId;

        public string title;

        public int cost = 500;

        public bool isAvailable = true;

        public int rented = 0;
    }

    public class Customer
    {
        public int userId;

        public string name;

        public string phone;

        public string address;

        public int privatPropCode;

        public List<Movies> history = new List<Movies>();

        public Customer()
        {
            Random random = new Random();
            privatPropCode = random.Next(0, 100);
            Console.WriteLine("New customer Private Property Code is {0}", privatPropCode);
            Console.Clear();
        }
    }
}
