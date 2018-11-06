using System;
using System.Collections.Generic;
using System.Linq;
using OLO_Console.DTO;
using OLO_Console.Helpers;

namespace OLO_Console.Domain.Service
{
    public class PizzaService
    {
        /// <summary>
        /// Remove dupplications and rank toppings.
        /// </summary>
        /// <param name="pizzaToppings"></param>
        private void RankingToppings(List<PizzaTopping> pizzaToppings)
        {
            string[] topping = null;

            for (int i = 0; i < pizzaToppings.Count(); i++)
            {
                if (pizzaToppings[i].Rank == 0)
                {
                    List<PizzaTopping> list = pizzaToppings.Where(t => t.Toppings.ToDelimitedString() ==
                    pizzaToppings[i].Toppings.ToDelimitedString()).ToList();

                    topping = pizzaToppings[i].Toppings;

                    pizzaToppings.RemoveAll(t => list.Exists(c => c.Toppings == t.Toppings));

                    pizzaToppings.Add(new PizzaTopping { Rank = list.Count(), Toppings = topping });

                    RankingToppings(pizzaToppings);
                }
            }
        }
        public List<PizzaTopping> GetTop20Toppings(List<PizzaTopping> pizzaToppings)
        {
            RankingToppings(pizzaToppings);
            return pizzaToppings.OrderByDescending(o => o.Rank).Take(20).ToList();
        }
    }
}
