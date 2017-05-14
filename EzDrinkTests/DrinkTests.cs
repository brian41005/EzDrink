using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink.Tests
{
    [TestClass()]
    public class DrinkTests
    {
        [TestMethod()]
        public void DrinkTest()
        {
            Drink drink = new Drink("haha", 20 );
            Assert.AreEqual(drink.name, "haha");
            Assert.AreEqual(drink.price, 20);
        }

        [TestMethod()]
        public void GetCopyTest()
        {
            Drink drink = new Drink("haha", 20);
            Drink drink2 = drink.GetCopy();
            Assert.AreEqual(drink.name, drink2.name);
            Assert.AreEqual(drink.price, drink2.price);
            drink.SetPrice("0");
            Assert.AreNotEqual(drink.price, drink2.price);
        }
    }
}