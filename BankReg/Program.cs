using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BankReg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer { Name = "John Sommers", Acc = 12345 };
            Customer customer2 = new Customer { Name = "Ivan Bubkin", Acc = 43535 };
            Customer customer3 = new Customer { Name = "Artur Skomarohov", Acc = 54546 };
            Customer customer4 = new Customer { Name = "Fedor Chukrov", Acc = 87855 };
            Customer customer5 = new Customer { Name = "Alla Pugacheva", Acc = 58687 };


            List<Customer> customers = new List<Customer>();
            customers.AddRange(new Customer[] { customer1, customer2, customer3, customer4, customer5 });



            Console.WriteLine("Здравствуйте, Вас приветствует БанК, Введите ваше имя и фамилию..");
            //while (Console.ReadLine() != "x")
            // {



            // string inputName = Console.ReadLine();
            string NamePattern = "^[a-zA-Zа-яА-ЯёЁ'][a-zA-Zа-яА-Я-ёЁ' ]+[a-zA-Zа-яА-ЯёЁ']?$";
            string AccPattern = "^[0-9]{5}$";
            string inputName = Console.ReadLine();
            while (!Regex.Match(inputName, NamePattern).Success)
            {
                if(!Regex.Match(inputName, NamePattern).Success) { 
                    Console.WriteLine("Неверный формат ввода, проверьте на ошибки.");
                }
                else
                {
                    Console.WriteLine("Теперь введите ваш номер счета");
                }
               
                
            }
            
            /*if (!Regex.Match(inputName, NamePattern).Success)
            {
                Console.WriteLine("Неверный формат ввода, проверьте на ошибки.");
            }
            else { Console.WriteLine("Теперь введите ваш номер счета"); }*/

            Console.WriteLine("Теперь введите ваш номер счета");

            int inputAcc = Convert.ToInt32(Console.ReadLine());
            Customer inputCustomer = new Customer { Name = inputName, Acc = inputAcc };


            //contains вызывает equals который мы уже переопределили

            if (customers.Contains(new Customer { Name = inputName, Acc = inputAcc }))

            {
                Console.WriteLine("Вы " + inputName + "уже присутсвуете в базе");
            }
            else
            {
                Console.WriteLine("Вас нет в базе!");
                customers.Add(inputCustomer);
            }


            foreach (Customer person1 in customers)
            {
                Console.WriteLine((customers.IndexOf(person1) + 1) + " " + person1.Name + person1.Acc);
            }

            // }







        }

        public static Customer CustomerExists(Customer customer, Customer inputCustomer)
        {
            if (customer.Equals(inputCustomer))
            { return null; }
            else { return customer; }

        }



    }
}
