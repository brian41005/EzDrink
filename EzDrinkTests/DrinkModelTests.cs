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
    public class DrinkModelTests
    {
        [TestMethod()]
        public void GetDrinkMenuSizeTest()
        {
            DrinkModel model = new DrinkModel();

            Assert.AreEqual(model.GetDrinkMenuSize(), 5);
        }

        [TestMethod()]
        public void GetAdditionMenuSizeTest()
        {
            DrinkModel model = new DrinkModel();
            Assert.AreEqual(model.GetAdditionMenuSize(), 4);
        }

        [TestMethod()]
        public void GetOrdersSizeTest()
        {
            DrinkModel model = new DrinkModel();
            Assert.AreEqual(model.GetOrdersSize(), 0);
        }

        [TestMethod()]
        public void ExitEzDrinkTest()
        {
            DrinkModel model = new DrinkModel();
            model.ExitEzDrink();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void DrinkModelTest()
        {
            DrinkModel model = new DrinkModel();
            Assert.AreEqual(model.GetDrinkMenuSize(), 5);
        }

        [TestMethod()]
        public void SetSweetLevelTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            Assert.AreEqual(model.GetOrdersSize(), 5);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
        }

        [TestMethod()]
        public void SetTemperatureTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            Assert.AreEqual(model.GetOrdersSize(), 5);
            Assert.AreEqual(model.IsOrdersCompleted(), true);
        }

        [TestMethod()]
        public void AddDrinkToCurrentOrdersTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            Assert.AreEqual(model.GetOrdersSize(), 5);
            Assert.AreEqual(model.IsOrdersCompleted(), true);
        }

        [TestMethod()]
        public void CheckOutTest()
        {
            DrinkModel model = new DrinkModel();
            model.CheckOut();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "正常");
            Assert.AreEqual(model.GetOrdersSize(), 5);
            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.CheckOut();
            Assert.AreEqual(model.GetOrdersSize(), 0);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
        }

        [TestMethod()]
        public void DeleteDrinkFromCurrentOrdersTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "無糖");
            for (int i = 0; i < 2; i++)
                model.DeleteDrinkFromCurrentOrders(i);

            Assert.AreEqual(model.IsOrdersCompleted(), false);
            model.DeleteDrinkFromCurrentOrders(-1);
            model.DeleteDrinkFromCurrentOrders(10);
            model.DeleteDrinkFromCurrentOrders(1);
            model.DeleteDrinkFromCurrentOrders(2);
            Assert.AreEqual(model.GetOrdersSize(), 2);
            model.AddDrinkToCurrentOrders(4);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
        }

        [TestMethod()]
        public void IsOrdersCompletedTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            model.DeleteDrinkFromCurrentOrders(-1);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "微糖");
            
            Assert.AreEqual(model.IsOrdersCompleted(), false);
            model.DeleteDrinkFromCurrentOrders(-1);
            model.DeleteDrinkFromCurrentOrders(11);
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.DeleteDrinkFromCurrentOrders(0);
            model.DeleteDrinkFromCurrentOrders(2);
            Assert.AreEqual(model.GetOrdersSize(), 3);
            model.AddDrinkToCurrentOrders(4);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
            model.DeleteDrinkFromCurrentOrders(3);
            Assert.AreEqual(model.IsOrdersCompleted(), true);
        }

        [TestMethod()]
        public void GetRecordStateTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "正常");
            for (int i = 0; i < 7; i++)
                model.SetTemperature(i, "少冰");

            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.DeleteDrinkFromCurrentOrders(-1);
            model.DeleteDrinkFromCurrentOrders(10);

            model.DeleteDrinkFromCurrentOrders(0);
            model.DeleteDrinkFromCurrentOrders(2);
            Assert.AreEqual(model.GetOrdersSize(), 3);
            model.AddDrinkToCurrentOrders(4);
            model.AddAdditionToCurrentOrders(0, 0);
            model.AddAdditionToCurrentOrders(0, 0);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
            model.DeleteDrinkFromCurrentOrders(3);
            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.AddAdditionToCurrentOrders(0, 0);
            model.AddAdditionToCurrentOrders(0, 1);
            List<int> list = model.GetRecordState(0);
            foreach (int i in list)
                Assert.AreEqual(list[i], i);
            List<int> list2 = model.GetRecordState(10);
            Assert.AreEqual(list2.Count, 0);
            List<int> list3 = model.GetRecordState(-1);
            Assert.AreEqual(list3.Count, 0);
        }

        [TestMethod()]
        public void AddAdditionToCurrentOrdersTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
            {
                model.SetSweetLevel(i, "半糖");
                model.SetTemperature(i, "正常");
            }
            for (int i = 0; i < 7; i++)
                model.SetTemperature(i, "去冰");
            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.DeleteDrinkFromCurrentOrders(-2);
            model.DeleteDrinkFromCurrentOrders(10);
            for (int k =0;k<3;k++)
                model.DeleteDrinkFromCurrentOrders(k);
            Assert.AreEqual(model.GetOrdersSize(), 2);
            model.AddDrinkToCurrentOrders(1);
            Assert.AreEqual(model.IsOrdersCompleted(), false);
            model.DeleteDrinkFromCurrentOrders(3);
            model.SetTemperature(2, "少冰");
            model.SetSweetLevel(2, "半糖");
            Assert.AreEqual(model.IsOrdersCompleted(), true);
            model.AddAdditionToCurrentOrders(0, 0);
            model.AddAdditionToCurrentOrders(0, 1);
            List<int> list = model.GetRecordState(0);
            foreach (int i in list)
                Assert.AreEqual(list[i], i);
            List<int> list2 = model.GetRecordState(10);
            Assert.AreEqual(list2.Count, 0);
        }

        [TestMethod()]
        public void GetCurrentOrderDrinkListStringTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            //for (int i = 0; i < 5; i++)
            //    model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "正常");
            Assert.AreEqual(model.IsOrdersCompleted(), false);
            List<string> name = new List<string> { "茉莉綠茶", "阿薩姆紅茶", "高山青茶", "鐵觀音", "烏龍青茶" };
            List<string> price = new List<string> { "30", "25", "40", "50", "30" };
            List<List<string>> list2 = model.GetCurrentOrderDrinkListString();
            int j = 0;
            foreach (List<string> eachItem in list2)
            {
                Assert.AreEqual(eachItem[0], name[j]);
                Assert.AreEqual(eachItem[1], price[j]);
                j++;
            }

        }

        [TestMethod()]
        public void GetDrinkMenuStringTest()
        {
            DrinkModel model = new DrinkModel();
            List<string> name = new List<string> { "茉莉綠茶", "阿薩姆紅茶", "高山青茶", "鐵觀音", "烏龍青茶" };
            List<string> price = new List<string> { "30", "25", "40", "50", "30" };
            List<List<string>> list2 = model.GetDrinkMenuString();
            int j = 0;
            foreach (List<string> eachItem in list2)
            {
                Assert.AreEqual(eachItem[0], name[j]);
                Assert.AreEqual(eachItem[1], price[j]);
                j++;
            }
        }
        [TestMethod()]
        public void GetAdditionMenuStringTest()
        {
            DrinkModel model = new DrinkModel();
            List<string> name = new List<string> { "珍珠", "椰果", "仙草", "布丁" };
            List<string> price = new List<string> { "5", "5", "10", "10" };
            List<List<string>> list2 = model.GetAdditionMenuString();
            int j = 0;
            foreach (List<string> eachItem in list2)
            {
                Assert.AreEqual(eachItem[0], name[j]);
                Assert.AreEqual(eachItem[1], price[j]);
                j++;
            }
        }

        [TestMethod()]
        public void DeleteListTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            List<string> name = new List<string> { "珍珠", "椰果", "仙草", "布丁" };
            List<string> price = new List<string> { "5", "5", "10", "10" };
            List<List<string>> list2 = model.GetAdditionMenuString();
            int j = 0;
            foreach (List<string> eachItem in list2)
            {
                Assert.AreEqual(eachItem[0], name[j]);
                Assert.AreEqual(eachItem[1], price[j]);
                j++;
            }
            model.DeleteList(-1, false);
            model.DeleteList(10, false);
            model.DeleteList(0, false);
            List<List<string>> list3 = model.GetAdditionMenuString();
            int k = 1;
            foreach (List<string> eachItem in list3)
            {
                Assert.AreEqual(eachItem[0], name[k]);
                Assert.AreEqual(eachItem[1], price[k]);
                k++;
            }
            List<string> drinkMame = new List<string> { "茉莉綠茶", "阿薩姆紅茶", "高山青茶", "鐵觀音", "烏龍青茶" };
            List<string> drinkPrice = new List<string> { "30", "25", "40", "50", "30" };
            List<List<string>> list4 = model.GetAdditionMenuString();
            model.DeleteList(-1, true);
            model.DeleteList(10, true);
            model.DeleteList(0, true);
            int y = 1;
            foreach (List<string> eachItem in list4)
            {
                Assert.AreEqual(eachItem[0], name[y]);
                Assert.AreEqual(eachItem[1], price[y]);
                y++;
            }
            model.DeleteList(10, true);
            model.DeleteList(10, false);
        }

        [TestMethod()]
        public void ModifyDrinkOrAdditionListTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");

            model.ModifyDrinkOrAdditionList(0, 0, true, "haha");
            Assert.AreEqual(model.GetDrinkMenuString()[0][0], "茉莉綠茶");

            model.ModifyDrinkOrAdditionList(0, 1, true, "haha");
            Assert.AreEqual(model.GetDrinkMenuString()[0][0], "haha");

            model.ModifyDrinkOrAdditionList(0, 1, true, "鐵觀音");
            Assert.AreEqual(model.GetDrinkMenuString()[0][0], "haha");

            model.ModifyDrinkOrAdditionList(0, 2, true, "haha");
            Assert.AreEqual(model.GetDrinkMenuString()[0][1], "30");

            model.ModifyDrinkOrAdditionList(0, 2, true, "20");
            Assert.AreEqual(model.GetDrinkMenuString()[0][1], "20");
            //-----------------------------------------------------------
            model.ModifyDrinkOrAdditionList(0, 0, false, "haha");
            Assert.AreEqual(model.GetAdditionMenuString()[0][0], "珍珠");

            model.ModifyDrinkOrAdditionList(0, 1, false, "haha");
            Assert.AreEqual(model.GetAdditionMenuString()[0][0], "haha");

            model.ModifyDrinkOrAdditionList(0, 1, false, "布丁");
            Assert.AreEqual(model.GetAdditionMenuString()[0][0], "haha");

            model.ModifyDrinkOrAdditionList(0, 2, false, "haha");
            Assert.AreEqual(model.GetAdditionMenuString()[0][1], "5");

            model.ModifyDrinkOrAdditionList(0, 2, false, "20");
            Assert.AreEqual(model.GetAdditionMenuString()[0][1], "20");
            //--------------------------------------------------------
            model.ModifyDrinkOrAdditionList(0, 2, false);
            Assert.AreEqual(model.GetAdditionMenuString()[0][1], "20");
            Assert.AreEqual(model.GetCurrentOrderDrinkListString()[0][0], "haha");
        }

        [TestMethod()]
        public void IsNewDrinkOrAdditionTest()
        {
            DrinkModel model = new DrinkModel();
            model.IsNewDrinkOrAddition("鐵觀音", 10, true);
            Assert.AreEqual(model.GetDrinkMenuSize(), 5);

            model.IsNewDrinkOrAddition("haha", 10, true);
            Assert.AreEqual(model.GetDrinkMenuSize(), 6);

            model.IsNewDrinkOrAddition("珍珠", 10, false);
            Assert.AreEqual(model.GetAdditionMenuSize(), 4);

            model.IsNewDrinkOrAddition("GG", 10, false);
            Assert.AreEqual(model.GetAdditionMenuSize(), 5);

        }

        [TestMethod()]
        public void IsSuccessReloadFileTest()
        {
            const string ADDITION_FILE_PATH = "..\\..\\DrinkAddition.txt";
            const string MENU_FILE_PATH = "..\\..\\DrinkMenu.txt";
            DrinkModel model = new DrinkModel();
            Assert.IsFalse(model.IsSuccessReloadFile("", true));
            Assert.IsFalse(model.IsSuccessReloadFile("", false));
            Assert.IsTrue(model.IsSuccessReloadFile(MENU_FILE_PATH, true));
            Assert.IsTrue(model.IsSuccessReloadFile(ADDITION_FILE_PATH, false));

        }

        [TestMethod()]
        public void GetHistoryTitleTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
            {
                model.AddDrinkToCurrentOrders(i);
                model.SetSweetLevel(i, "半糖");
            }
                
            for (int i = 0; i < 7; i++)
                model.SetSweetLevel(i, "正常");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            model.CheckOut();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            model.CheckOut();
            List<List<string>> list = model.GetHistoryTitle();
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod()]
        public void GetHistoryDetailTest()
        {
            DrinkModel model = new DrinkModel();
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
            {
                model.SetSweetLevel(i, "正常");
                model.SetTemperature(i, "正常");
            }
               
            model.CheckOut();
            model.GetHistoryDetail(-3);
            model.GetHistoryDetail(10);
            List<List<string>> list = model.GetHistoryDetail(0);
            Assert.AreEqual("茉莉綠茶", list[0][0]);
        }

        [TestMethod()]
        public void GetHistoryDetailPriceTest()
        {
            DrinkModel model = new DrinkModel();
            model._historyChange += func;
            for (int i = 0; i < 5; i++)
                model.AddDrinkToCurrentOrders(i);
            for (int i = 0; i < 6; i++)
                model.SetSweetLevel(i, "半糖");
            for (int i = 0; i < 6; i++)
                model.SetTemperature(i, "少冰");
            model.CheckOut();
            Assert.AreEqual(175, model.GetHistoryDetailPrice(0));
            Assert.AreEqual(0, model.GetHistoryDetailPrice(-1));
            Assert.AreEqual(0, model.GetHistoryDetailPrice(100));
        }

        private void func()
        {
        }
    }
}