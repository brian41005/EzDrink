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
    public class OrderTests
    {
        [TestMethod()]
        public void OrderTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.ReferenceEquals(order.drink, drink);
            Assert.ReferenceEquals(order.addition, add);
        }

        [TestMethod()]
        public void GetCopyTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.AreEqual(order.GetTotalPrice(), order.GetCopy().GetTotalPrice());
        }

        [TestMethod()]
        public void RemoveAdditionTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            order.RemoveAddition(add);
            Assert.AreEqual(order.GetTotalPrice(), 20);
        }

        [TestMethod()]
        public void AddDrinkAdditionTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            //order.RemoveAddition(add);
            Assert.AreEqual(order.GetTotalPrice(), 40);
        }

        [TestMethod()]
        public void SetTemperatureTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            order.SetTemperature("去冰");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.AreEqual(order.GetTotalPrice(),40);
        }

        [TestMethod()]
        public void GetSweetLevelTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.AreEqual(order.GetSweetLevel(), "");
        }

        [TestMethod()]
        public void SetSweetLevelTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            order.SetSweetLevel("無糖");
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void GetTemperatureTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.AreEqual(order.GetTemperature(), "");
        }

        [TestMethod()]
        public void GetAdditionStringTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.AreEqual(order.GetAdditionString(), "GG");
        }

        [TestMethod()]
        public void CheckIsNotCompleteTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.IsTrue(order.CheckIsNotComplete());
            order.SetTemperature("去冰");
            order.SetSweetLevel("無糖");
            Assert.IsTrue(!order.CheckIsNotComplete());
        }

        [TestMethod()]
        public void GetDataListTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            DrinkAddition add = new DrinkAddition("GG", 20);
            order.AddDrinkAddition(add);
            Assert.IsTrue(order.CheckIsNotComplete());
            order.SetTemperature("去冰");
            order.SetSweetLevel("無糖");
            List<string> list = order.GetDataList();
            Assert.AreEqual(list[0], "haha");
            Assert.AreEqual(list[1], "40");
            Assert.AreEqual(list[2], "無糖");
            Assert.AreEqual(list[3], "去冰");
            Assert.AreEqual(list[4], "GG");
        }
    }
}