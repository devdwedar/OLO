using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLO_Console.Helpers;
using OLO_Console.Domain.Service;
using OLO_Console.DTO;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void VerifyToppingOrdersCount()
        {
            FileHelper fileHelper = new FileHelper();

            List<PizzaTopping> list = fileHelper.GetToppingsList();

            Assert.AreEqual(4616, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pepperon"));
            Assert.AreEqual(1014, (int)list.Count(c => c.Toppings.ToDelimitedString() == "mozzarella chees"));
            Assert.AreEqual(956, (int)list.Count(c => c.Toppings.ToDelimitedString() == "four chees"));
            Assert.AreEqual(732, (int)list.Count(c => c.Toppings.ToDelimitedString() == "baco"));
            Assert.AreEqual(623, (int)list.Count(c => c.Toppings.ToDelimitedString() == "bee"));

            Assert.AreEqual(402, (int)list.Count(c => c.Toppings.ToDelimitedString() == "sausag"));
            Assert.AreEqual(361, (int)list.Count(c => c.Toppings.ToDelimitedString() == "italian sausag"));
            Assert.AreEqual(229, (int)list.Count(c => c.Toppings.ToDelimitedString() == "chicke"));
            Assert.AreEqual(165, (int)list.Count(c => c.Toppings.ToDelimitedString() == "ha"));
            Assert.AreEqual(159, (int)list.Count(c => c.Toppings.ToDelimitedString() == "mushroom"));

            Assert.AreEqual(117, (int)list.Count(c => c.Toppings.ToDelimitedString() == "black olive"));
            Assert.AreEqual(103, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pepperoni,four cheese"));
            Assert.AreEqual(101, (int)list.Count(c => c.Toppings.ToDelimitedString() == "alredo sauc"));
            Assert.AreEqual(100, (int)list.Count(c => c.Toppings.ToDelimitedString() == "four cheese,pepperoni"));
            Assert.AreEqual(96, (int)list.Count(c => c.Toppings.ToDelimitedString() == "mozzarella cheese,pepperoni"));

            Assert.AreEqual(95, (int)list.Count(c => c.Toppings.ToDelimitedString() == "cheddar chees"));
            Assert.AreEqual(79, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pineappl"));
            Assert.AreEqual(67, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pepperoni,beef"));
            Assert.AreEqual(63, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pepperoni,bacon"));
            Assert.AreEqual(59, (int)list.Count(c => c.Toppings.ToDelimitedString() == "pepperoni,mozzarella cheese"));
        }
    }
}
