using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLeigan
{
    class Customerss
    {
        public static List<Customer> CreateListOfCustomers()
        {
            var customer = new List<Customer>();

            var john = new Customer();
            john.userId = 1;
            john.name = "John Frankson";
            john.phone = "5505684";
            john.address = "Laugavegur 2";
          //  john.privatPropCode = 0;
            customer.Add(john);

            var henry = new Customer();
            henry.userId = 2;
            henry.name = "Henry Derduts";
            henry.phone = "6848594";
            henry.address = "Hverfisgata 100";
           // henry.privatPropCode = 2;
            customer.Add(henry);

            var benny = new Customer();
            benny.userId = 3;
            benny.name = "Benny Hill";
            benny.phone = "6987448";
            benny.address = "Bankastræti 99";
            //benny.privatPropCode = 3;
            customer.Add(benny);

            return customer;
        }
    }
}