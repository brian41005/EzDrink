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
    public class SugarTests
    {
        private const string REGULAR_SUGAR_STRING = "正常";
        private const string HALF_SUGAR_STRING = "半糖";
        private const string QUARTER_SUGAR_STRING = "微糖";
        private const string SUGAR_FREE_STRING = "無糖";
        private const string NO_SELECT = "";
        [TestMethod()]
        public void SugarTest()
        {
            Sugar sugarTest = new Sugar();
            Assert.AreEqual(sugarTest.level,"");
        }

        [TestMethod()]
        public void SetSugarLevelTest()
        {
            Sugar sugarTest = new Sugar();
            sugarTest.SetSugarLevel("半糖");
            Assert.AreEqual(sugarTest.level, "半糖");
            sugarTest.SetSugarLevel("hggg");
            Assert.AreEqual(sugarTest.level, "");
        }

        [TestMethod()]
        public void IsNoneTest()
        {
            Sugar sugarTest = new Sugar();
            Assert.AreEqual(sugarTest.IsNone(), true);
            sugarTest.SetSugarLevel("無糖");
            Assert.AreEqual(sugarTest.IsNone(), false);
        }
    }
}