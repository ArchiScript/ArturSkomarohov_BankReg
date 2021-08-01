using System;
using System.Collections.Generic;

namespace BankReg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Name = "John Sommers", Acc = 12345 };
            Customer customer2 = new Customer { Id = 2, Name = "Ivan Bubkin", Acc = 43535 };
            Customer customer3 = new Customer { Id = 3, Name = "Artur Skomarohov", Acc = 54546 };
            Customer customer4 = new Customer { Id = 4, Name = "Fedor Chukrov", Acc = 87855 };
            Customer customer5 = new Customer { Id = 5, Name = "Alla Pugacheva", Acc = 58687 };


            List<Customer> customers = new List<Customer>();
            customers.AddRange(new Customer[] { customer1, customer2, customer3, customer4, customer5 });
            //Console.WriteLine(customer5.Acc);
            

           


        }
    }
}
