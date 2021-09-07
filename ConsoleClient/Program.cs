using StrategyPattern;
using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Strategy Pattern");

            var context = new StrategyContext();

            context.Order = new Models.Order
            {
                Id = 1,
                Items = new System.Collections.Generic.List<Models.Item>
            {
                new Models.Item{ Id = 1, Name = "Item One", Price = 1.00M },
                new Models.Item{ Id = 2, Name = "Item Two", Price = 2.00M },
                new Models.Item{ Id = 3, Name = "Item Three", Price = 3.00M }
            }};

            Console.WriteLine("Select which format to use:");
            Console.WriteLine("For Json enter a");
            Console.WriteLine("For XML enter b");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    context.OrderToFile = new JsonOrderStrategy();
                    break;
                default:
                    context.OrderToFile = new XmlOrderStrategy();
                    break;
            }

            context.SaveFile();

        }
    }
}
