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
    public class ItemTests
    {
        [TestMethod()]
        public void ItemTest()
        {
            Item item = new Item("haha", 10);
            Assert.AreEqual(item.name,"haha");
            Assert.AreEqual(item.price, 10);
        }

        [TestMethod()]
        public void GetDataListTest()
        {
            Item item = new Item("haha", 10);
            List<string> list = item.GetDataList();
            Assert.AreEqual(list[0], "haha");
            Assert.AreEqual(list[1], "10");
        }

        [TestMethod()]
        public void SetNameTest()
        {
            Item item = new Item("haha", 10);
            item.SetName("");
            item.SetName("haha2");
            Assert.AreEqual(item.name, "haha2");
        }

        [TestMethod()]
        public void SetPriceTest()
        {
            Item item = new Item("haha", 10);
            item.SetPrice(" ");
            Assert.AreEqual(item.price, 10);
            item.SetPrice("-1");
            Assert.AreEqual(item.price, 10);
            item.SetPrice("20");
            Assert.AreEqual(item.price, 20);
        }
    }
}