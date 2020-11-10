using System;
using System.Collections.Generic;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine().Split(";");
            string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> personList = new List<Person>();
            List<Product> productsList = new List<Product>();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                try
                {
                    string[] inputArgs = peopleInput[i].Split("=");
                    string name = inputArgs[0];
                    double money = double.Parse(inputArgs[1]);
                    Person person = new Person(name, money);
                    personList.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            for (int i = 0; i < productsInput.Length; i++)
            {
                try
                {
                    string[] inputArgs = productsInput[i].Split("=");
                    string name = inputArgs[0];
                    double price = double.Parse(inputArgs[1]);
                    Product product = new Product(name, price);
                    productsList.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine())!= "END")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = commandArgs[0];
                string product = commandArgs[1];

                foreach (var person in personList)
                {
                    if (name == person.Name)
                    {
                        foreach (var productName in productsList)
                        {
                            if (product == productName.Name)
                            {
                                if (person.Money >= productName.Price)
                                {
                                    person.Products.Add(product);
                                    Console.WriteLine($"{name} bought {product}");
                                    person.Money -= productName.Price;
                                }
                                else
                                {
                                    Console.WriteLine($"{name} can't afford {product}");
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Products.Count > 0)
                {
                    Console.WriteLine($"{personList[i].Name} - {string.Join(", ", personList[i].Products)}");
                }
                else
                {
                    Console.WriteLine($"{personList[i].Name} - Nothing bought");
                }
            }
        }
    }
}
