using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class PresentationModel
    {
        private DrinkModel _ezDrinkModel;
        private const int PRICE_INDEX = 1;
        private const string CONFIRM = "確認";
        private const string CANCEL = "取消";
        private const string NEW = "新增";
        private const string OPEN_FILE = "從檔案匯入";
        private bool _isDrinkOperationButtonPress = false;
        private bool _isDrinkAdditionOperationButtonPress = false;

        //intialize
        public PresentationModel(ref DrinkModel ezDrinkModel)
        {
            _ezDrinkModel = ezDrinkModel;
        }

        //isDrinkButtonPress
        public bool isInNewDrinkState
        {
            get
            {
                return _isDrinkOperationButtonPress;
            }
        }

        //isAdditionButtonPress
        public bool isInNewAdditionState
        {
            get
            {
                return _isDrinkAdditionOperationButtonPress;
            }
        }

        //Get Total Price
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (List<string> eachOrder in _ezDrinkModel.GetCurrentOrderDrinkListString())
                totalPrice += Int32.Parse(eachOrder[PRICE_INDEX]);
            return totalPrice;
        }

        //Press Drink Operation Button
        public List<string> GetIntoOrGetOutNewDrinkState()
        {
            _isDrinkOperationButtonPress = !_isDrinkOperationButtonPress;
            if (_isDrinkOperationButtonPress)
                return new List<string>
                {
                    CONFIRM,
                    CANCEL
                };
            else
                return new List<string>
                {
                    NEW,
                    OPEN_FILE
                };  
        }

        //Press Drink Addition Operation Button
        public List<string> GetIntoOrGetOutNewAdditionState()
        {
            _isDrinkAdditionOperationButtonPress = !_isDrinkAdditionOperationButtonPress;
            if (_isDrinkAdditionOperationButtonPress)
                return new List<string>
                {
                    CONFIRM,
                    CANCEL
                };
            else
                return new List<string>
                {
                    NEW,
                    OPEN_FILE
                };
        }

        //Is New Drink Or Addition
        public bool IsNewDrinkOrAddition(string name, string priceString, bool isDrink)
        {
            int price = 0;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceString) || string.IsNullOrWhiteSpace(name))
                return false; 
            if (int.TryParse(priceString, out price))
                return _ezDrinkModel.IsNewDrinkOrAddition(name, price, isDrink);
            return false;

        }

    }
}
