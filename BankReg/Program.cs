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


            Console.WriteLine("Здравствуйте, Вас приветствует БанК.. \n для продолжения нажмите Enter, для выхода x");
            while (Console.ReadLine() != "x")
            {
                Console.WriteLine("Введите ваше Имя и Фамилию..\n");


                string NamePattern = "^[a-zA-Zа-яА-ЯёЁ'][a-zA-Zа-яА-Я-ёЁ' ]+[a-zA-Zа-яА-ЯёЁ']?$";
                string AccPattern = "^[0-9]{5}$";

                string inputName;
                do
                {
                    inputName = Console.ReadLine();
                    bool isNameValid = Regex.Match(inputName, NamePattern).Success;

                    if (!isNameValid)
                    {
                        Console.WriteLine("Неверный формат ввода, проверьте на ошибки.\n");
                    }
                    else
                    {
                        Console.WriteLine("Теперь введите ваш номер счета в формате ХХХХХ\n");
                    }
                }
                while (!Regex.Match(inputName, NamePattern).Success);


                string inputAcc;
                do
                {
                    inputAcc = Console.ReadLine();
                    bool isAccValid = Regex.Match(inputAcc, AccPattern).Success;
                    if (!isAccValid)
                    {
                        Console.WriteLine("Неверный формат ввода, проверьте на ошибки.\n");
                    }
                    else
                    {
                        Console.WriteLine("Данные проверены...\n");
                    }
                }
                while (!Regex.Match(inputAcc, AccPattern).Success);
                int inputAccInt = Convert.ToInt32(inputAcc);

                Customer inputCustomer = new Customer { Name = inputName, Acc = inputAccInt };


                //contains вызывает equals который мы уже переопределили
                if (customers.Contains(inputCustomer))
                {
                    Console.WriteLine($"Здравствуйте {inputName},  Вы уже есть в базе \n");
                }
                else
                {
                    Console.WriteLine("Вас нет в базе! Добавить Вас в клиенты? да / нет");
                    if (Console.ReadLine() == "да")
                    {
                        customers.Add(inputCustomer);
                        Console.WriteLine("Поздравляем, Вы добавлены в Клиенты \n");
                    }
                    else { Console.WriteLine("До свидания. \n"); }

                }


                foreach (Customer person1 in customers)
                {
                    Console.WriteLine((customers.IndexOf(person1) + 1) + $" {person1.Name} {person1.Acc}");
                }
            }

        }
    }
}
