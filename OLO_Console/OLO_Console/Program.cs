using System.Collections.Generic;
using OLO_Console.DTO;
using OLO_Console.Domain.Service;
using OLO_Console.Helpers;
using System;
using System.Diagnostics;

namespace OLO_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper();
            PizzaService pizzaService = new PizzaService();

            Console.WriteLine("Please wait, processing ...");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<PizzaTopping> top20Toppings  = pizzaService.GetTop20Toppings(
                fileHelper.GetToppingsList());

            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;

            Console.Clear();
            Console.WriteLine("TOP 20 RANKED MOST POPULAR PIZZA TOPPINGS:\n");
            Console.WriteLine(" RANK | ORDERS | TOPPING");
            Console.WriteLine(" -------------------------------\n");
            var rank = 1;
            foreach (PizzaTopping item in top20Toppings)
            {
                Console.WriteLine($" {(rank++).ToString().PadLeft(2,'0')}     {item.Rank.ToString().PadLeft(5, ' ')}    {item.Toppings.ToDelimitedString()}");
            }
            Console.WriteLine(" -------------------------------\n");
            Console.WriteLine($"Elapsed time: {time.Milliseconds} milliseconds");
            Console.ReadLine();
        }
    }
}
