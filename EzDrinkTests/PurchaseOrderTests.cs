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
    public class PurchaseOrderTests
    {
        [TestMethod()]
        public void PurchaseOrderTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            List<Order> orders = new List<Order> { order };
            PurchaseOrder purchaseOrderTest = new PurchaseOrder(orders);
            Assert.AreEqual(purchaseOrderTest.GetPurchaseOrderTotalPrice(), 20);
        }

        [TestMethod()]
        public void GetPurchaseOrderTotalPriceTest()
        {
            List<Order> orders = new List<Order>();
            PurchaseOrder purchaseOrderTest = new PurchaseOrder(orders);
            Assert.AreEqual(purchaseOrderTest.GetPurchaseOrderTotalPrice(), 0);
        }


        [TestMethod()]
        public void GetTitleTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            List<Order> orders = new List<Order> { order };
            PurchaseOrder purchaseOrderTest = new PurchaseOrder(orders);
            Assert.AreEqual(purchaseOrderTest.GetTitle()[1], "20");
        }

        [TestMethod()]
        public void GetDetailTest()
        {
            Drink drink = new Drink("haha", 20);
            Order order = new Order(drink);
            List<Order> orders = new List<Order> { order };
            PurchaseOrder purchaseOrderTest = new PurchaseOrder(orders);
            Assert.AreEqual(purchaseOrderTest.GetDetail()[0][0], "haha");
            Assert.AreEqual(purchaseOrderTest.GetDetail()[0][1], "20");
        }

    }
}