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
    public class PresentationModelTests
    {
        [TestMethod()]
        public void PresentationModelTest()
        {
            DrinkModel model = new DrinkModel();
            PresentationModel pmodel = new PresentationModel(ref model);
            Assert.IsFalse(pmodel.isInNewAdditionState);
            Assert.IsFalse(pmodel.isInNewDrinkState);
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            DrinkModel model = new DrinkModel();
            PresentationModel pmodel = new PresentationModel(ref model);
            model.AddDrinkToCurrentOrders(0);
            Assert.AreEqual(pmodel.GetTotalPrice(),  30);
        }

        [TestMethod()]
        public void GetIntoOrGetOutNewDrinkStateTest()
        {
            DrinkModel model = new DrinkModel();
            PresentationModel pmodel = new PresentationModel(ref model);
            List<string> list = pmodel.GetIntoOrGetOutNewDrinkState();
            Assert.AreEqual(list[0], "確認");
            List<string> list2 = pmodel.GetIntoOrGetOutNewDrinkState();
            Assert.AreEqual(list2[0], "新增");
        }

        [TestMethod()]
        public void GetIntoOrGetOutNewAdditionStateTest()
        {
            DrinkModel model = new DrinkModel();
            PresentationModel pmodel = new PresentationModel(ref model);
            List<string> list = pmodel.GetIntoOrGetOutNewAdditionState();
            Assert.AreEqual(list[0], "確認");
            List<string> list2 = pmodel.GetIntoOrGetOutNewAdditionState();
            Assert.AreEqual(list2[0], "新增");
        }

        [TestMethod()]
        public void IsNewDrinkOrAdditionTest()
        {
            DrinkModel model = new DrinkModel();
            PresentationModel pmodel = new PresentationModel(ref model);
            
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("","",true), false);
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("", "", false), false);
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("haha","abc", true), false);
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("haha", "abc", false), false);
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("haha", "10", true), true);
            Assert.AreEqual(pmodel.IsNewDrinkOrAddition("haha", "10", false), true);
        }
    }
}