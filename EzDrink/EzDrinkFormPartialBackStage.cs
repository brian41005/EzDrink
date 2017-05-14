using System;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        //Back Stage Drink List DataGridView Cell Content Click
        private void BackStageDrinkListDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickBackStageCellContent(sender, e, true);
        }

        //Back Stage DrinkAddition List DataGrid View CellContentClick
        private void BackStageDrinkAdditionListDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickBackStageCellContent(sender, e, false);
        }

        //Back Stage Drink List DataGridView Cell Content Changed
        private void BackStageDrinkListDataGridViewCellContentChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeBackStageCellContent(sender, e, true);
        }

        //BackStage Drink Addition DataGridView CellContent Changed
        private void BackStageDrinkAdditionDataGridViewCellContentChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeBackStageCellContent(sender, e, false);
        }

        //Drink Price TextBox KeyPress
        private void DrinkPriceTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Drink Addition Price TextBox KeyPress
        private void DrinkAdditionPriceTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //
        //drink 
        //

        //DrinkList Operation Button Click
        private void DrinkListOperationButtonClick(object sender, EventArgs e)
        {
            if (_ezDrinkPresentationModel.isInNewDrinkState)
            {
                if (!_ezDrinkPresentationModel.IsNewDrinkOrAddition(_drinkNameTextBox.Text, _drinkPriceTextBox.Text, true))
                    _ezDrinkFormToolBox.GetNewItemError();
                else
                {
                    RefreshDrinkReceptionAndBackStageAndOrdersDataGridView();
                    RefreshDrinkGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewDrinkState(), false, true);
                }
            }
            else
                RefreshDrinkGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewDrinkState(), true, true);       
        }

        //Open Drink List File Button Click
        private void OpenDrinkListFileButtonClick(object sender, EventArgs e)
        {
            if (_ezDrinkPresentationModel.isInNewDrinkState)
                RefreshDrinkGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewDrinkState(), false, true);
            else
            {
                string fileName = _ezDrinkFormToolBox.GetFileName();
                if (_ezDrinkFormToolBox.IsLoadingWarning(fileName))
                {
                    if (!_ezDrinkModel.IsSuccessReloadFile(fileName, true))
                        _ezDrinkFormToolBox.LoadError();
                    else
                        RefreshDrinkReceptionAndBackStageAndOrdersDataGridView();
                }
            }
        }

        //
        //Addition
        //

        //Drink Addition List Operation Button Click
        private void DrinkAdditionListOperationButtonClick(object sender, EventArgs e)
        {
            if (_ezDrinkPresentationModel.isInNewAdditionState)
            {
                if (!_ezDrinkPresentationModel.IsNewDrinkOrAddition(_drinkAdditionNameTextBox.Text, _drinkAdditionPriceTextBox.Text, false))
                    _ezDrinkFormToolBox.GetNewItemError();
                else
                {
                    RefreshAdditionReceptionAndBackStageAndOrdersDataGridView();
                    RefreshAdditionGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewAdditionState(), false, true);
                }
            }
            else
                RefreshAdditionGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewAdditionState(), true, true);

        }

        //Open Drink Addition List Button Click
        private void OpenDrinkAdditionListButtonClick(object sender, EventArgs e)
        {
            if (_ezDrinkPresentationModel.isInNewAdditionState)
                RefreshAdditionGroupBoxTextBoxAndButtonText(_ezDrinkPresentationModel.GetIntoOrGetOutNewAdditionState(), false, true);
            else
            {
                string fileName = _ezDrinkFormToolBox.GetFileName();
                if (_ezDrinkFormToolBox.IsLoadingWarning(fileName))
                {
                    if (!_ezDrinkModel.IsSuccessReloadFile(fileName, false))
                        _ezDrinkFormToolBox.LoadError();
                    else
                        RefreshAdditionReceptionAndBackStageAndOrdersDataGridView();
                }
            }

        }
    }
}