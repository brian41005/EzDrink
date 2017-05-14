using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITest.Input;

namespace EzDrinkGUITest
{
    public class Robot
    {
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";
        private const string MSAA_TECHNOLOGY = "MSAA";

        //public static void SetDelayBetweenActions(int millisecond)
        //{
        //    Playback.PlaybackSettings.DelayBetweenActions = millisecond;
        //}

        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }

        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        //public static void ClickDateTimePicker(string[] data)
        //{
        //    WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
        //    dateTimePicker.SetProperty("DateTime", data[1] + "/" + data[2] + "/" + data[3]);
        //}

        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        public static void ClickTabControl(string name)
        {
            Mouse.Click((WinTabPage)Robot.FindWinControl(typeof(WinTabPage), name, _root));
        }

        //public static void SetEdit(string name, string keys)
        //{
        //    WinEdit edit = (WinEdit)FindWinControl(typeof(WinEdit), name, _root);
        //    if (edit.Text != keys)
        //        edit.Text = keys;
        //}

        //public static void AssertOtherFormEdit(string formName, string editName, string assertValue)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
        //    window.WindowTitles.Add(formName);
        //    WinEdit edit = new WinEdit(window);
        //    edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
        //    Assert.AreEqual(edit.Text, assertValue);
        //}

        //public static void SetOtherFormEdit(string formName, string editName, string keys)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
        //    window.WindowTitles.Add(formName);
        //    WinEdit edit = new WinEdit(window);
        //    edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
        //    if (edit.Text != keys)
        //        edit.Text = keys;
        //}

        //public static void ClickOtherFormButton(string formName, string buttonName)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
        //    window.WindowTitles.Add(formName);
        //    WinButton button = new WinButton(window);
        //    button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
        //    Mouse.Click(button);
        //}

        //public static void CloseWindow(string name)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = name;
        //    window.WindowTitles.Add(name);
        //    WinTitleBar bar = new WinTitleBar(window);
        //    WinButton button = new WinButton(bar);
        //    button.SearchProperties[WinButton.PropertyNames.Name] = "Close";
        //    Mouse.Click(button);
        //}

        //public static void AssertOtherFormButtonEnable(string formName, string buttonName, bool assertValue)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
        //    window.WindowTitles.Add(formName);
        //    WinButton button = new WinButton(window);
        //    button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
        //    Assert.AreEqual(button.Enabled, assertValue);
        //}

        //public static void ClickListViewByValue(string name, string data)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = name;
        //    WinList list = new WinList(window);
        //    list.WindowTitles.Add("Task Type");
        //    if (data == string.Empty)
        //    {
        //        Mouse.Click(list);
        //    }
        //    else
        //    {
        //        list.SelectedItemsAsString = data;
        //    }
        //}

        //public static void ClickListViewToEmpty(string name, string data)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = name;
        //    window.WindowTitles.Add("Task Type");
        //    WinList list = new WinList(window);
        //    list.SelectedItemsAsString = null;
        //}

        //public static void SetNumericUpDown(string name, string keys)
        //{
        //    WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
        //    if (spinner.SelectedItem != keys)
        //        spinner.SelectedItem = keys;
        //}

        //public static void SetComboBox(string name, string targetName)
        //{
        //    WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
        //    if (comboBox.SelectedItem != targetName)
        //        comboBox.SelectedItem = targetName;
        //}

        //public static void SetCheckBox(string name, bool isChecked)
        //{
        //    WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
        //    if (checkBox.Checked != isChecked)
        //        checkBox.Checked = isChecked;
        //}

        //public static void AssertEdit(string name, string assertValue)
        //{
        //    WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
        //    Assert.AreEqual(edit.Text, assertValue);
        //}

        //public static void AssertCheckBox(string name, bool isChecked)
        //{
        //    WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
        //    Assert.AreEqual(checkBox.Checked, isChecked);
        //}

        //public static void AssertNumericUpDown(string name, string keys)
        //{
        //    WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
        //    Assert.AreEqual(spinner.SelectedItem, keys);
        //}

        //public static void AssertDateTimePicker(string[] data)
        //{
        //    WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
        //    Assert.AreEqual(dateTimePicker.DateTime.Year, int.Parse(data[1]));
        //    Assert.AreEqual(dateTimePicker.DateTime.Month, int.Parse(data[2]));
        //    Assert.AreEqual(dateTimePicker.DateTime.Day, int.Parse(data[3]));
        //}

        //public static void AssertComboBox(string name, string assertValue)
        //{
        //    WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
        //    Assert.AreEqual(comboBox.SelectedItem, assertValue);
        //}

        //public static void AssertListViewByValue(string name, string[] data)
        //{
        //    WinWindow window = new WinWindow();
        //    window.SearchProperties[WinWindow.PropertyNames.Name] = name;
        //    WinList list = new WinList(window);
        //    list.WindowTitles.Add("Task Type");
        //    UITestControlCollection collection = list.Items;
        //    for (int i = 0; i < collection.Count; i++)
        //    {
        //        Assert.AreEqual(data[i], collection[i].Name);
        //    }
        //}

        public static void AssertDataGridViewByIndex(string name, string index, string[] data)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow _Winrow = new WinRow(table);
            _Winrow.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
            _Winrow.Find();
            UITestControlCollection collection = _Winrow.GetChildren();
            for (int i = 0; i < collection.Count; i++)
            {
                WinCell cell = collection[i] as WinCell;
                Assert.AreEqual(data[i], cell.Value);
            }
        }

        public static void AssertDataItemsInDataGridView(string name, int items)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            Assert.AreEqual(table.Rows.Count, items);
        }

        public static void AssertButtonEnable(string name, bool state)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Assert.AreEqual(button.Enabled, state);
        }

        public static void AssertWindow(string name)
        {
            const string KEY_TEXT = "\n";
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, KEY_TEXT);
        }

        

        public static void DeleteOrderDataGridView(string name, string index)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow row = new WinRow(table);
            row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
            UITestControlCollection collection = row.GetChildren();
            Mouse.Click(collection[5]);
        }

        //public static void DeleteDataGridView(string name, string index)
        //{
        //    WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
        //    WinRow row = new WinRow(table);
        //    row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
        //    UITestControlCollection collection = row.GetChildren();
        //    Mouse.Click(collection[0]);
        //}

        public static void ClickDataGridView(string name, string index, int col = 0)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow row = new WinRow(table);
            row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
            UITestControlCollection collection = row.GetChildren();
            Mouse.Click(collection[col]);
        }

        //---我與黃麟傑一起加的
        public static void ClickMessageBox(string name, string key)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, key);
        }

        public static void AssertTextBoxEnable(string name, bool state)
        {
            WinEdit TextBox = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(TextBox.Enabled, state);
        }

        public static void AssertLabel(string name, string key)
        {
            WinText Label = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(Label.DisplayText, key);
        }

        public static void SetTextBox(string name, string text)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if(edit.Text != text)
            {
                edit.Text = "";
                Keyboard.SendKeys(edit, text + "\n");
            }
        }

        public static void SetDataGridViewValue(string name, string row, string col, string text)
        {
            WinTable dataGridView = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow dataGridRow = new WinRow(dataGridView);
            dataGridRow.SearchProperties.Add(WinRow.PropertyNames.RowIndex, row);
            UITestControlCollection collection = dataGridRow.GetChildren();
            Mouse.Click(collection[int.Parse(col)]);
            Keyboard.SendKeys(collection[int.Parse(col)], text + "\r\n");
        }

        public static void AssertDataGridViewValue(string name, string row, string col, string key)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow _Winrow = new WinRow(table);
            _Winrow.SearchProperties.Add(WinRow.PropertyNames.RowIndex, row);
            _Winrow.Find();
            UITestControlCollection collection = _Winrow.GetChildren();
            WinCell cell = collection[int.Parse(col)] as WinCell;
            Assert.AreEqual(key, cell.Value);
        }
    }
}
