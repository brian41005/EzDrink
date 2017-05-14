using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace EzDrink
{

    public partial class EzDrinkForm : Form
    {
        private DrinkModel _ezDrinkModel;
        private PresentationModel _ezDrinkPresentationModel;
        private EzDrinkFormToolBox _ezDrinkFormToolBox;
        private const int NAME_INDEX = 0;
        private const int PRICE_INDEX = 1;
        private const string DELETE_BUTTON_TEXT = "刪除";
        private const string SELECT_BUTTON_TEXT = "選擇";
        private const string PRICE_WORD = "總價:";
        private const string PRICE_UNIT = " 元";        
        private const int DELETE_BUTTON_INDEX = 5;
        private const int NEGATIVE_ONE = -1;        

        //intialize
        public EzDrinkForm(ref DrinkModel ezDrinkModel, ref PresentationModel ezDrinkPresentationModel)
        {
            _ezDrinkModel = ezDrinkModel;
            _ezDrinkPresentationModel = ezDrinkPresentationModel;
            _ezDrinkFormToolBox = new EzDrinkFormToolBox();
            InitializeComponent();
            InitializeAdditionAndDrinkGridView();
            _ezDrinkModel._historyChange += UpdateHistory;
        }

        //Update History
        private void UpdateHistory()
        {
            _historyDataGridView.Rows.Clear();
            foreach (List<string> eachTitle in _ezDrinkModel.GetHistoryTitle())
                _historyDataGridView.Rows.Add(eachTitle.ToArray());
        }

        //Exit Tool Strip Menu Item Click
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            _ezDrinkModel.ExitEzDrink();
        }

        //Drink GridView Cell Content Click
        private void DrinkGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < _ezDrinkModel.GetDrinkMenuSize())
            {
                _ezDrinkModel.AddDrinkToCurrentOrders(e.RowIndex);
                RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
                RefreshCheckOutButton();
            }
        }

        //Order Display Grid View Cell Content Click
        private void OrderDisplayGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _ezDrinkModel.GetOrdersSize() && e.ColumnIndex == DELETE_BUTTON_INDEX)
            {
                _ezDrinkModel.DeleteDrinkFromCurrentOrders(e.RowIndex);
                RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
                RefreshCheckOutButton();
            }
        }

        //Drink Addition Grid View Cell Content Click
        private void DrinkAdditionGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < _ezDrinkModel.GetAdditionMenuSize() && _ezDrinkModel.GetOrdersSize() != 0)
            {
                if ((_drinkAdditionGridView.Rows[e.RowIndex].Cells[0] as DataGridViewDisableButtonCell).Enabled)
                {
                    _ezDrinkModel.AddAdditionToCurrentOrders(GetCurrentOrderDisplayGridViewIndex(), e.RowIndex);
                    RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
                }
            }
        }

        //Order Display Grid View Selection Changed
        private void OrderDisplayGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (_orderDisplayGridView.CurrentCell.ColumnIndex != DELETE_BUTTON_INDEX)
                RefreshDrinkAdditionGridViewButton();
        }

        //Sugar Button Click
        private void ClickSweetButton(object sender, EventArgs e)
        {
            HandleTemperatureAndSweetButtonEvent(sender, false);
        }

        //Temperature Button Click
        private void ClickTemperatureButton(object sender, EventArgs e)
        {
            HandleTemperatureAndSweetButtonEvent(sender);
        }

        //Check Out Button Click
        private void CheckOutButtonClick(object sender, EventArgs e)
        {
            _ezDrinkModel.CheckOut();
            RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
            RefreshCheckOutButton();
        }

        //Click About ToolStrip Menu Item
        private void ClickAboutToolStripMenuItem(object sender, EventArgs e)
        {
            _ezDrinkFormToolBox.ShowAbout();
        }

        //
        private void ChangeHistoryDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            int index = _historyDataGridView.CurrentCell.RowIndex;
            _historyDetailDataGridView.Rows.Clear();
            foreach (List<string> eachItem in _ezDrinkModel.GetHistoryDetail(index))
                _historyDetailDataGridView.Rows.Add(eachItem.ToArray());
            _historyPriceLabel.Text = PRICE_WORD + _ezDrinkModel.GetHistoryDetailPrice(index).ToString() + PRICE_UNIT;
        }
    }
}