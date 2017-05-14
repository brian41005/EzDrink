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
    public class TemperatureTests
    {
        private const string REGULAR_ICE_STRING = "正常";
        private const string WARM_STRING = "溫熱";
        private const string EASY_ICE_STRING = "少冰";
        private const string ICE_FREE_STRING = "去冰";
        private const string NO_SELECT = "";
        [TestMethod()]
        public void TemperatureTest()
        {
            Temperature temperatureTest = new Temperature();
            Assert.AreEqual(temperatureTest.level, "");
        }

        [TestMethod()]
        public void SetTemperatureTest()
        {
            Temperature temperatureTest = new Temperature();
            temperatureTest.SetTemperature("正常");
            Assert.AreEqual(temperatureTest.level, "正常");
            temperatureTest.SetTemperature("haah");
            Assert.AreEqual(temperatureTest.level, "");
        }

        [TestMethod()]
        public void IsNoneTest()
        {
            Temperature temperatureTest = new Temperature();
            Assert.AreEqual(temperatureTest.IsNone(), true);
            temperatureTest.SetTemperature("正常");
            Assert.AreEqual(temperatureTest.IsNone(), false);
        }

    }
}