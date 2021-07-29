using System;
using System.Collections.Generic;

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
            //Console.WriteLine(customer5.Acc);


            Console.WriteLine("Здравствуйте, Вас приветствует БанК, Введите ваше имя и фамилию..");
            string inputName = Console.ReadLine().Trim();
            Console.WriteLine("Теперь введите ваш номер счета");
            int inputAcc = Convert.ToInt32(Console.ReadLine());
            Customer inputCustomer = new Customer { Name = inputName, Acc = inputAcc };
            foreach (Customer person in customers)
            {
                if (person.Equals(inputCustomer))
                {
                    Console.WriteLine("Вы " + inputName + "уже присутсвуете в базе");
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Вас не было в базе, теперь Вы наш новый клиент.");
                } 
            }
            customers.Add(inputCustomer);
            /*if (customers.Contains(new Customer { Name = inputName, Acc = inputAcc }))
            //if ((new Customer { Name = inputName, Acc = inputAcc }))
            {
                Console.WriteLine("Вы " + inputName + "уже присутсвуете в базе");
            }
            else { Console.WriteLine("Вас нет в базе!"); }*/

            //customers.Add(new Customer { Name = "Friedrich Bocom", Acc = 37082 });

            //bool status = customers.Equals(customer5);
            //Console.WriteLine(status);
            foreach (Customer person1 in customers)
            {

                Console.WriteLine((customers.IndexOf(person1) + 1) + " " + person1.Name + person1.Acc);

            }
            //while (Console.ReadLine() != "x")
            // {

            //string Name = Console.ReadLine();



            /*foreach (var person in customers)
                                {
                bool status = customers.Contains(customer1);
                if (person.Name == Name) 
                {
                    status = true;
                    Console.WriteLine("Вы уже зарегистрированы");
                }
                else { Console.WriteLine("Вы не зарегисрированы, введите ваши данные..");

                    int NewId = customers.Add(new Customer { Id = customers.IndexOf, }) ;
                    string NewName = Console.ReadLine();

                        Console.WriteLine("Введите ");
                }

            }*/




            //}





        }
    }
}
