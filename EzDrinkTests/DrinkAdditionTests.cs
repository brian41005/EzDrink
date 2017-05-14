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
    public class DrinkAdditionTests
    {
        [TestMethod()]
        public void DrinkAdditionTest()
        {
            DrinkAddition addition = new DrinkAddition("haha", 20);
            Assert.AreEqual(addition.name, "haha");
            Assert.AreEqual(addition.price, 20);
        }

        [TestMethod()]
        public void GetCopyTest()
        {
            Drink addition = new Drink("haha", 20);
            Drink addition2 = addition.GetCopy();
            Assert.AreEqual(addition.name, addition2.name);
            Assert.AreEqual(addition.price, addition2.price);
            addition.SetPrice("0");
            Assert.AreNotEqual(addition.price, addition2.price);
        }
    }
}