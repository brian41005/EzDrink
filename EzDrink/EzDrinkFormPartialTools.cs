using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {        
        //back Stag eCell Content Click
        private void ClickBackStageCellContent(object sender, DataGridViewCellEventArgs e, bool isDrink)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (_ezDrinkFormToolBox.GetDeleteDialog() == DialogResult.Yes)
                {
                    _ezDrinkModel.DeleteList(e.RowIndex, isDrink);
                    if (isDrink)
                        RefreshDrinkReceptionAndBackStageAndOrdersDataGridView();
                    else
                        RefreshAdditionReceptionAndBackStageAndOrdersDataGridView();
                    RefreshCheckOutButton();
                }
            }
        }

        //Cell Content Changed
        private void ChangeBackStageCellContent(object sender, DataGridViewCellEventArgs e, bool isDrink)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                try
                {
                    _ezDrinkModel.ModifyDrinkOrAdditionList(e.RowIndex, e.ColumnIndex, isDrink, ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch (Exception)
                {
                }
                if (isDrink)
                    RefreshDrinkReceptionAndBackStageAndOrdersDataGridView();
                else
                    RefreshAdditionReceptionAndBackStageAndOrdersDataGridView();
                RefreshCheckOutButton();
            }
        }

        //Refresh Drink Forward And Back Stage DataGridView
        private void RefreshDrinkReceptionAndBackStageAndOrdersDataGridView()
        {
            RefreshGridView(_ezDrinkModel.GetDrinkMenuString(), _backStageDrinkListDataGridView, DELETE_BUTTON_TEXT);
            RefreshGridView(_ezDrinkModel.GetDrinkMenuString(), _drinkGridView, SELECT_BUTTON_TEXT);
            RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
        }

        //Refresh Addition Forward And Back Stage DataGridView
        private void RefreshAdditionReceptionAndBackStageAndOrdersDataGridView()
        {
            RefreshGridView(_ezDrinkModel.GetAdditionMenuString(), _backStageDrinkAdditionListDataGridView, DELETE_BUTTON_TEXT);
            RefreshGridView(_ezDrinkModel.GetAdditionMenuString(), _drinkAdditionGridView, SELECT_BUTTON_TEXT);
            RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
        }

        //Refresh DrinkGroupBox TextBox And ButtonText
        private void RefreshDrinkGroupBoxTextBoxAndButtonText(List<string> text, bool enable, bool clear)
        {
            _drinkListOperationButton.Text = text[0];
            _openDrinkListFileButton.Text = text[1];
            DealWithTextBox(_drinkNameTextBox, _drinkPriceTextBox, enable, clear);
        }

        //RefreshAdditionGroupBoxTextBoxAndButtonText
        private void RefreshAdditionGroupBoxTextBoxAndButtonText(List<string> text, bool enable, bool clear)
        {
            _drinkAdditionListOperationButton.Text = text[0];
            _openDrinkAdditionListButton.Text = text[1];
            DealWithTextBox(_drinkAdditionNameTextBox, _drinkAdditionPriceTextBox, enable, clear);
        }

        //Deal With TextBox
        private void DealWithTextBox(TextBox nameTextBox, TextBox priceTextBox, bool enable, bool clear)
        {
            nameTextBox.Enabled = enable;
            priceTextBox.Enabled = enable;
            if (clear)
            {
                nameTextBox.Text = string.Empty;
                priceTextBox.Text = string.Empty;
            }
        }

        //Refresh Drink Addition Grid View Button
        private void RefreshDrinkAdditionGridViewButton()
        {
            int currentOrderRowIndex = GetCurrentOrderDisplayGridViewIndex();
            //MessageBox.Show(currentOrderRowIndex.ToString());
            List<int> state = _ezDrinkModel.GetRecordState(currentOrderRowIndex);

            for (int i = 0; i < _ezDrinkModel.GetAdditionMenuSize(); i++)
                (_drinkAdditionGridView.Rows[i].Cells[0] as DataGridViewDisableButtonCell).Enabled = !state.Contains(i);

            _drinkAdditionGridView.Refresh();
        }

        //Up date Order Display Grid View
        private void RefreshOrderDisplayGridView(List<List<string>> listString)
        {
            int selectionIndex = GetCurrentOrderDisplayGridViewIndex();
            RefreshGridView(listString, _orderDisplayGridView, DELETE_BUTTON_TEXT, false);

            if (selectionIndex != NEGATIVE_ONE && selectionIndex < _ezDrinkModel.GetOrdersSize() && _ezDrinkModel.GetOrdersSize() > 1)
                _orderDisplayGridView.CurrentCell = _orderDisplayGridView.Rows[selectionIndex].Cells[0];

            RefreshDrinkAdditionGridViewButton();
            RefreshCheckOutLabel();
        }

        //RrfreshyGridView
        private void RefreshGridView(List<List<string>> listString, DataGridView gridView, string buttonString, bool buttonIndexFirst = true)
        {
            gridView.Rows.Clear();
            foreach (List<string> eachRow in listString)
            {
                if (!buttonIndexFirst)
                    eachRow.Add(DELETE_BUTTON_TEXT);
                else
                    eachRow.Insert(0, buttonString);
                gridView.Rows.Add(eachRow.ToArray());
            }                

        }

        //Handle Temperature And Sweet Button Event
        private void HandleTemperatureAndSweetButtonEvent(object sender, bool isTemperatureButton = true)
        {
            int selectedDrinkIndex = GetCurrentOrderDisplayGridViewIndex();

            if (selectedDrinkIndex != NEGATIVE_ONE)
            {
                if (isTemperatureButton)
                    _ezDrinkModel.SetTemperature(selectedDrinkIndex, (sender as Button).Text);

                else
                    _ezDrinkModel.SetSweetLevel(selectedDrinkIndex, (sender as Button).Text);

                RefreshOrderDisplayGridView(_ezDrinkModel.GetCurrentOrderDrinkListString());
                RefreshCheckOutButton();
            }
        }

        //Update CheckOut Label
        private void RefreshCheckOutLabel()
        {
            _checkOutLabel.Text = PRICE_WORD + _ezDrinkPresentationModel.GetTotalPrice() + PRICE_UNIT;
        }

        //Refresh CheckOut Button
        private void RefreshCheckOutButton()
        {
            _checkOutButton.Enabled = _ezDrinkModel.IsOrdersCompleted();
        }

        //Get index for setting temp or sweetness
        private int GetCurrentOrderDisplayGridViewIndex()
        {
            if (_orderDisplayGridView.CurrentCell != null)
                return _orderDisplayGridView.CurrentCell.RowIndex;
            else
                return NEGATIVE_ONE;
        }

        //Initialize Addition An dDrink GridView
        private void InitializeAdditionAndDrinkGridView()
        {
            foreach (List<string> eachDrink in _ezDrinkModel.GetDrinkMenuString())
            {    
                _drinkGridView.Rows.Add(SELECT_BUTTON_TEXT, eachDrink[NAME_INDEX], eachDrink[PRICE_INDEX]);
                _backStageDrinkListDataGridView.Rows.Add(DELETE_BUTTON_TEXT, eachDrink[NAME_INDEX], eachDrink[PRICE_INDEX]);
            }

            foreach (List<string> eachAddition in _ezDrinkModel.GetAdditionMenuString())
            {
                _drinkAdditionGridView.Rows.Add(SELECT_BUTTON_TEXT, eachAddition[NAME_INDEX], eachAddition[PRICE_INDEX]);
                _backStageDrinkAdditionListDataGridView.Rows.Add(DELETE_BUTTON_TEXT, eachAddition[NAME_INDEX], eachAddition[PRICE_INDEX]);
            }  
        }

    }
}