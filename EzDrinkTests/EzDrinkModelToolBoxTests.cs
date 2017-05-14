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
    public class EzDrinkModelToolBoxTests
    {
        private const string ADDITION_FILE_PATH = "..\\..\\DrinkAddition.txt";
        private const string MENU_FILE_PATH = "..\\..\\DrinkMenu.txt";
        [TestMethod()]
        public void GetListStringTest()
        {
            DrinkModel model = new DrinkModel();
            List<List<string>> list = model.GetAdditionMenuString();
            Assert.AreEqual(list.Count, 4);
            List<List<string>> list2 = model.GetCurrentOrderDrinkListString();
            Assert.AreEqual(list2.Count, 0);
            List<List<string>> list3 = model.GetDrinkMenuString();
            Assert.AreEqual(list3.Count, 5);
        }

        [TestMethod()]
        public void IsSuccessLoadListTest()
        {
            DrinkModel model = new DrinkModel();
            Assert.IsTrue(model.IsSuccessReloadFile("..\\..\\DrinkAddition.txt", false));
            Assert.IsTrue(model.IsSuccessReloadFile("..\\..\\DrinkAddition.txt", true));
            Assert.IsTrue(model.IsSuccessReloadFile("..\\..\\DrinkMenu.txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (2).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (3).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (4).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (5).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (6).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (7).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (8).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件 (9).txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件.txt", true));
            Assert.IsFalse(model.IsSuccessReloadFile("..\\..\\新文字文件", true));
        }
    }
}