using System;
using System.Collections.Generic;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chosenItems = new List<string>();
            List<decimal> prices = new List<decimal>();
            Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>();

            menuItems.Add("apple", 0.99m);
            menuItems.Add("banana", 0.59m);
            menuItems.Add("cauliflower", 1.59m);
            menuItems.Add("dragonfruit", 2.19m);
            menuItems.Add("elderberry", 1.79m);
            menuItems.Add("figs", 2.09m);
            menuItems.Add("grapefruit", 1.99m);
            menuItems.Add("honeydew", 3.49m);

            string orderMore = "";
            do
            {
                Console.WriteLine("Item: $Price");
                Console.WriteLine("===========");
                foreach (var item in menuItems)
                {
                    Console.WriteLine($"{item.Key}: ${item.Value}");
                }
                Console.WriteLine();
                Console.Write("What item would you like to order? ");
                string userChoice = Console.ReadLine().ToLower();
                if (menuItems.ContainsKey(userChoice) == false)
                {
                    Console.WriteLine("\nSorry that was not a valid choice.");
                }
                else
                {
                    chosenItems.Add(userChoice);
                    prices.Add(menuItems[userChoice]);
                }

                Console.Write("\nWould you like to order anything else (y/n)? ");
                orderMore = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (orderMore == "y" || orderMore == "yes");

            Console.WriteLine("Your chosen items: ");
            decimal total = 0;
            for (int i = 0; i < chosenItems.Count; i++)
            {
                Console.WriteLine($"- {chosenItems[i]}: ${prices[i]}");
                total = total + prices[i];
            }
            decimal avg = total / prices.Count;
            Console.WriteLine();
            Console.WriteLine($" Average Cost: ${avg:0.00}");

        }
    }
}
