using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace EzDrinkGUITest
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]
    public class EzDrinkUITest
    {
        private const string FILE_PATH = "..\\..\\..\\EzDrink\\bin\\Debug\\EzDrink.exe";
        private const string CALCULATOR_TITLE = "EzDrink";
        private const string EXPECTED_VALUE = "444. ";
        private string[] sweetButton = { "regularSugarButton", "halfSugarButton", "quarterSugarButton", "sugarFreeButton" };
        private string[] sweet = { "正常", "半糖", "微糖", "無糖" };
        private string[] temperatureButton = { "regularIceButton", "warmTemperatureButton", "easyIceButton", "iceFreeButton"};
        private string[] temperature = { "正常", "溫熱", "少冰", "去冰" };

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, CALCULATOR_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        private void RunScriptAdd()
        {

            for (int i = 1; i <= 5; i++)
            {
                Robot.ClickDataGridView("drinkGridView", i.ToString());
            }
            Robot.AssertDataItemsInDataGridView("orderDisplay", 5);
            for (int i = 1; i <= 5; i++)
            {
                Robot.ClickDataGridView("orderDisplay", i.ToString());
                if (i > 3)
                {
                    Robot.ClickButton(sweetButton[0]);
                    Robot.ClickButton(temperatureButton[0]);
                }
                else
                {
                    Robot.ClickButton(sweetButton[i]);
                    Robot.ClickButton(temperatureButton[i]);
                }

            }
            for (int i = 1; i <= 2; i++)
            {
                Robot.ClickDataGridView("orderDisplay", i.ToString());
                Robot.DeleteOrderDataGridView("orderDisplay", i.ToString());
            }
            Robot.AssertDataItemsInDataGridView("orderDisplay", 3);

            for (int i = 0; i < 2; i++)
            { 
                int k = 4;
                for (int j = 1; j <= 3; j++)
                {
                    
                    Robot.ClickDataGridView("orderDisplay", j.ToString());
                    for (int g = 1; g <= k; g++)
                        Robot.ClickDataGridView("drinkAddition", g.ToString());
                    k--;
                }
            }
            Robot.ClickButton("checkOutButton");
            Robot.ClickTabControl("後台管理");
            Robot.ClickTabControl("歷史紀錄");

        }

        [TestMethod]
        public void TestAdd()
        {
            RunScriptAdd();
            //TestDrinkGridView();
            Robot.AssertWindow("EzDrink");
        }

        [TestMethod]
        public void TestMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "help", "about" });
            Robot.AssertWindow("About");
            Robot.ClickMenuItem(new string[] { "file", "exit" });
           
        }

        [TestMethod]
        public void TestDrinkGridView()
        {
            Robot.ClickDataGridView("orderDisplay", "1");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("orderDisplay", "2");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("orderDisplay", "3");
            Robot.ClickDataGridView("drinkGridView", "10");
            Robot.ClickDataGridView("drinkGridView", "0");
            Robot.ClickDataGridView("drinkGridView", "10", 1);
            Robot.ClickDataGridView("drinkGridView", "1", 1);
            Robot.AssertDataItemsInDataGridView("orderDisplay", 4);
        }

        [TestMethod]
        public void TestDrinkAddition()
        {

            Robot.ClickDataGridView("drinkAddition", "1", 1);
            Robot.ClickDataGridView("drinkAddition", "6", 1);
            Robot.ClickDataGridView("drinkAddition", "1");
            Robot.ClickDataGridView("drinkAddition", "6");

            Robot.ClickDataGridView("drinkGridView", "1");

            Robot.ClickDataGridView("drinkAddition", "1", 1);
            Robot.ClickDataGridView("drinkAddition", "6", 1);
            Robot.ClickDataGridView("drinkAddition", "1");
            Robot.ClickDataGridView("drinkAddition", "6");

            Robot.ClickDataGridView("drinkAddition", "1", 1);
            Robot.ClickDataGridView("drinkAddition", "6", 1);
            Robot.ClickDataGridView("drinkAddition", "1");
            Robot.ClickDataGridView("drinkAddition", "6");


            Robot.ClickButton(sweetButton[0]);
            Robot.ClickButton(temperatureButton[0]);
            Robot.AssertDataItemsInDataGridView("orderDisplay", 1);
            Robot.AssertDataGridViewByIndex("orderDisplay", "1", new string[] { "茉莉綠茶", "35", "正常", "正常", "珍珠", "刪除"});
        }

        [TestMethod]
        public void TestCheckoutButton()
        {
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkAddition", "1");
            Robot.ClickButton("checkOutButton");
            Robot.AssertButtonEnable("checkOutButton", false);
            Robot.ClickButton(sweetButton[0]);
            Robot.ClickButton(temperatureButton[0]);
            Robot.AssertButtonEnable("checkOutButton", true);
            Robot.ClickButton("checkOutButton");
            Robot.AssertButtonEnable("checkOutButton", false);
        }

        [TestMethod]
        public void TestOrderDisplay()
        {
            Robot.ClickDataGridView("orderDisplay", "1");
            Robot.ClickDataGridView("orderDisplay", "1", 5);

            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkAddition", "1");
            Robot.ClickButton(sweetButton[0]);
            Robot.ClickButton(temperatureButton[0]);        
            Robot.AssertDataGridViewByIndex("orderDisplay", "1", new string[] { "茉莉綠茶", "35", "正常", "正常", "珍珠", "刪除" });
            Robot.ClickDataGridView("orderDisplay", "10");
            Robot.ClickDataGridView("orderDisplay", "5");
            Robot.DeleteOrderDataGridView("orderDisplay", "5");
            Robot.ClickDataGridView("orderDisplay", "3");
            Robot.DeleteOrderDataGridView("orderDisplay", "1");
            Robot.DeleteOrderDataGridView("orderDisplay", "1");

            Robot.ClickDataGridView("orderDisplay", "10", 1);
            Robot.ClickDataGridView("orderDisplay", "1");
            Robot.ClickDataGridView("orderDisplay", "10");
            Robot.ClickDataGridView("orderDisplay", "1", 5);
        }

        [TestMethod]
        public void TestSweetLevelAndTemperatureButton()
        {
            Robot.ClickDataGridView("drinkGridView", "1");
            Robot.ClickDataGridView("drinkAddition", "1");
            for(int i = 0; i < 4; i++)
            {
                Robot.ClickButton(sweetButton[i]);
                Robot.ClickButton(temperatureButton[i]);
                Robot.AssertDataGridViewByIndex("orderDisplay", "1", new string[] { "茉莉綠茶", "35", sweet[i], temperature[i], "珍珠", "刪除" });
            }
            
        }

        [TestMethod]
        public void TestBackStageDrinkListDataGridView()
        {
            int numberOfItem = 5;
            string[] option = { "Y", "N" }; 
            for(int i = 0; i < 2; i++)
            {
                Robot.AssertDataItemsInDataGridView("drinkGridView", numberOfItem);
                Robot.ClickTabControl("後台管理");
                Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", numberOfItem);
                Robot.ClickDataGridView("backStageDrinkListDataGridView", "2");
                Robot.ClickMessageBox("Important Question", option[i]);
                Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", numberOfItem-1+i);
                Robot.ClickTabControl("點餐系統");
                Robot.AssertDataItemsInDataGridView("drinkGridView", numberOfItem-1+i);
                numberOfItem--;
            }
        }

        [TestMethod]
        public void TestBackStageDrinkAdditionListDataGridView()
        {
            int numberOfItem = 4;
            string[] option = { "Y", "N" };
            for (int i = 0; i < 2; i++)
            {
                Robot.AssertDataItemsInDataGridView("drinkAddition", numberOfItem);
                Robot.ClickTabControl("後台管理");
                Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", numberOfItem);
                Robot.ClickDataGridView("backStageDrinkAdditionListDataGridView", "2");
                Robot.ClickMessageBox("Important Question", option[i]);
                Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", numberOfItem - 1 + i);
                Robot.ClickTabControl("點餐系統");
                Robot.AssertDataItemsInDataGridView("drinkAddition", numberOfItem - 1 + i);
                numberOfItem--;
            }
        }

        [TestMethod]
        public void TestDrinkListOperationButton()
        {
            Robot.ClickTabControl("後台管理");
            Robot.ClickButton("drinkListOperationButton");
            Robot.ClickButton("drinkListOperationButton");
            Robot.ClickMessageBox("Warning", "\n");
            Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 5);
        }

        [TestMethod]
        public void TestDrinkNameTextBoxAndDrinkPriceTextBox()
        {
            string[] drink = { "1", "", "3", "", "5", " " };
            string[] price = { " ", "20", "haha", "", "", " " };

            Robot.ClickTabControl("後台管理");
            Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 5);
            Robot.AssertTextBoxEnable("drinkNameTextBox", false);
            Robot.AssertTextBoxEnable("drinkPriceTextBox", false);
            Robot.ClickButton("drinkListOperationButton");
            Robot.AssertTextBoxEnable("drinkNameTextBox", true);
            Robot.AssertTextBoxEnable("drinkPriceTextBox", true);
            for (int i = 0; i < drink.Length; i++)
            {
                Robot.SetTextBox("drinkNameTextBox", drink[i]);
                Robot.SetTextBox("drinkPriceTextBox", price[i]);
                Robot.ClickButton("drinkListOperationButton");
                Robot.ClickMessageBox("Warning", "\n");
                Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 5);
            }
            Robot.SetTextBox("drinkNameTextBox", "123");
            Robot.SetTextBox("drinkPriceTextBox", "10");
            Robot.ClickButton("drinkListOperationButton");
            Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 6);
            Robot.ClickButton("drinkListOperationButton");
            Robot.ClickButton("openDrinkListFileButton");
            Robot.AssertTextBoxEnable("drinkNameTextBox", false);
            Robot.AssertTextBoxEnable("drinkPriceTextBox", false);

        }

        [TestMethod]
        public void TestDrinkAdditionNameTextBoxAndDrinkAdditionPriceTextBox()
        {
            string[] drink = { "1", ""  ,   "3",  "", "5"," "};
            string[] price = { " ", "20", "haha", "", "", " "};

            Robot.ClickTabControl("後台管理");
            Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", 4);
            Robot.AssertTextBoxEnable("drinkAdditionNameTextBox", false);
            Robot.AssertTextBoxEnable("drinkAdditionPriceTextBox", false);
            Robot.ClickButton("drinkAdditionListOperationButton");
            Robot.AssertTextBoxEnable("drinkAdditionNameTextBox", true);
            Robot.AssertTextBoxEnable("drinkAdditionPriceTextBox", true);
            for (int i = 0; i < drink.Length; i++)
            {
                Robot.SetTextBox("drinkAdditionNameTextBox", drink[i]);
                Robot.SetTextBox("drinkAdditionPriceTextBox", price[i]);
                Robot.ClickButton("drinkAdditionListOperationButton");
                Robot.ClickMessageBox("Warning", "\n");
                Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", 4);
            }
            Robot.SetTextBox("drinkAdditionNameTextBox", "123");
            Robot.SetTextBox("drinkAdditionPriceTextBox", "10");
            Robot.ClickButton("drinkAdditionListOperationButton");
            Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", 5);
            Robot.ClickButton("drinkAdditionListOperationButton");
            Robot.ClickButton("openDrinkAdditionListButton");
            Robot.AssertTextBoxEnable("drinkAdditionNameTextBox", false);
            Robot.AssertTextBoxEnable("drinkAdditionPriceTextBox", false);

        }

        [TestMethod]
        public void TestOpenDrinkListFileButton()
        {
            Robot.ClickTabControl("後台管理");
            for(int j = 0; j < 9; j++)
            {
                Robot.ClickButton("openDrinkListFileButton");
                for (int i = 0; i < 9; i++)
                    Keyboard.SendKeys("{Tab}");
                for (int i = 0; i < 5+j; i++)
                    Keyboard.SendKeys("{DOWN}");
                Keyboard.SendKeys("{ENTER}");
                Robot.ClickMessageBox("Warning", "Y");
                Robot.ClickMessageBox("Warning", "\n");
                Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 5);
            }
            Robot.ClickButton("openDrinkListFileButton");
            for (int i = 0; i < 9; i++)
                Keyboard.SendKeys("{Tab}");
            for (int i = 0; i < 4; i++)
                Keyboard.SendKeys("{DOWN}");
            Keyboard.SendKeys("{ENTER}");
            Keyboard.SendKeys("Y");
            Robot.AssertDataItemsInDataGridView("backStageDrinkListDataGridView", 5);
            Robot.ClickButton("openDrinkListFileButton");
            Keyboard.SendKeys("{ESC}");

        }

        [TestMethod]
        public void TestOpenDrinkAdditionListButton()
        {
            Robot.ClickTabControl("後台管理");
            for (int j = 0; j < 9; j++)
            {
                Robot.ClickButton("openDrinkAdditionListButton");
                for (int i = 0; i < 9; i++)
                    Keyboard.SendKeys("{Tab}");
                for (int i = 0; i < 5 + j; i++)
                    Keyboard.SendKeys("{DOWN}");
                Keyboard.SendKeys("{ENTER}");
                Robot.ClickMessageBox("Warning", "Y");
                Robot.ClickMessageBox("Warning", "\n");
                Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", 4);
            }
            Robot.ClickButton("openDrinkAdditionListButton");
            for (int i = 0; i < 9; i++)
                Keyboard.SendKeys("{Tab}");
            for (int i = 0; i < 3; i++)
                Keyboard.SendKeys("{DOWN}");
            Keyboard.SendKeys("{ENTER}");
            Keyboard.SendKeys("Y");
            Robot.AssertDataItemsInDataGridView("backStageDrinkAdditionListDataGridView", 4);
            Robot.ClickButton("openDrinkAdditionListButton");
            Keyboard.SendKeys("{ESC}");

        }

        [TestMethod]
        public void TestHistoryDetail()
        {
            for(int i = 0; i < 2; i++)
            {
                Robot.ClickDataGridView("drinkGridView", "1");
                Robot.ClickDataGridView("drinkAddition", "1");
                Robot.ClickButton(sweetButton[0]);
                Robot.ClickButton(temperatureButton[0]);
                Robot.ClickButton("checkOutButton");
            }
            
            Robot.ClickTabControl("歷史紀錄");
            Robot.ClickDataGridView("historyDataGridView", "1");
            Robot.AssertLabel("historyPriceLabel", "總價:35 元");
            Robot.ClickDataGridView("historyDataGridView", "2");
            Robot.AssertLabel("historyPriceLabel", "總價:35 元");
        }

        [TestMethod]
        public void TestDataGridViewSet()
        {
            string[] dataGridView = { "backStageDrinkListDataGridView", "backStageDrinkAdditionListDataGridView" };
            Robot.ClickTabControl("後台管理");
            for(int j = 0; j < dataGridView.Length; j++)
            {
                string[] testSet = { "" };
                for (int i = 0; i < testSet.Length; i++)
                {
                    Robot.SetDataGridViewValue(dataGridView[j], "1", "1", testSet[i]);
                    if(j==0)
                        Robot.AssertDataGridViewValue(dataGridView[j], "1", "1", "茉莉綠茶");
                    else
                        Robot.AssertDataGridViewValue(dataGridView[j], "1", "1", "珍珠");
                }
                string[] testvalueSet = { "", "d", "d5", "5f", "-1" };
                for (int i = 0; i < testSet.Length; i++)
                {
                    Robot.SetDataGridViewValue(dataGridView[j], "1", "2", testvalueSet[i]);
                    if(j==0)
                        Robot.AssertDataGridViewValue(dataGridView[j], "1", "2", "30");
                    else
                        Robot.AssertDataGridViewValue(dataGridView[j], "1", "2", "5");
                }
                Robot.SetDataGridViewValue(dataGridView[j], "1", "0", "GG");
                Robot.ClickMessageBox("Important Question", "N");
                Robot.SetDataGridViewValue(dataGridView[j], "0", "2", "GG");
                Robot.SetDataGridViewValue(dataGridView[j], "10", "2", "GG");

            }

        }
        [TestMethod]
        public void TesTTab()
        {
            Robot.ClickTabControl("點餐系統");
            Robot.ClickTabControl("後台管理");
            Robot.ClickTabControl("歷史紀錄");
            Robot.ClickTabControl("後台管理");
            Robot.ClickTabControl("點餐系統");
        }
    }
}
