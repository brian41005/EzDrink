using System;
using System.Collections.Generic;
using System.Linq;
namespace EzDrink
{
    public partial class DrinkModel
    {
        public delegate void ModelChangeEventHandler();
        public event ModelChangeEventHandler _historyChange;
        private List<Drink> _drinkList;
        private List<Order> _currentOrders;
        private List<DrinkAddition> _drinkAddition;
        private List<PurchaseOrder> _historyPurchaseOrder;
        private EzDrinkModelToolBox _ezDrinkModelToolBox;
        private const int NAME_INDEX = 1;
        private const int PRICE_INDEX = 2;
        private const string ADDITION_FILE_PATH = "..\\..\\DrinkAddition.txt";
        private const string MENU_FILE_PATH = "..\\..\\DrinkMenu.txt";        

        //intialize
        public DrinkModel()
        {
            _ezDrinkModelToolBox = new EzDrinkModelToolBox();
            _currentOrders = new List<Order>();
            _drinkList = new List<Drink>();
            _drinkAddition = new List<DrinkAddition>();
            _historyPurchaseOrder = new List<PurchaseOrder>();
            _ezDrinkModelToolBox.IsSuccessLoadList(ref _drinkList, MENU_FILE_PATH);
            _ezDrinkModelToolBox.IsSuccessLoadList(ref _drinkAddition, ADDITION_FILE_PATH);
        }

        //
        private void NotifyObserver()
        {
            if (_historyChange != null)
                _historyChange();
        }

        //Set Sweetness
        public void SetSweetLevel(int drinkIndex, string sugar)
        {
            if (drinkIndex < _currentOrders.Count)
                _currentOrders[drinkIndex].SetSweetLevel(sugar);
        }

        //Set Temperature
        public void SetTemperature(int drinkIndex, string temperatureLevel)
        {
            if (drinkIndex < _currentOrders.Count)
                _currentOrders[drinkIndex].SetTemperature(temperatureLevel);
        }

        //Add Drink To Current Order
        public void AddDrinkToCurrentOrders(int drinkIndex)
        {
            _currentOrders.Add(new Order(_drinkList[drinkIndex]));
        }

        //Check Out
        public void CheckOut()
        {
            if (_currentOrders.Count() != 0)
            {
                _historyPurchaseOrder.Add(new PurchaseOrder(_currentOrders));
                _currentOrders.Clear();
                NotifyObserver();
            }
        }

        //Get History Title
        public List<List<string>> GetHistoryTitle()
        {
            List<List<string>> titleList = new List<List<string>>();
            foreach (PurchaseOrder eachHistory in _historyPurchaseOrder)
                titleList.Add(eachHistory.GetTitle());
            return titleList;
        }

        //Add Drink To Current Orders
        public void DeleteDrinkFromCurrentOrders(int drinkIndex)
        {
            if (drinkIndex >= 0 && drinkIndex < _currentOrders.Count)
                _currentOrders.RemoveAt(drinkIndex);
        }

        //Is Order Completed
        public bool IsOrdersCompleted()
        {
            bool isDataAllFilled = true;
            foreach (Order eachOrder in _currentOrders)
                if (eachOrder.CheckIsNotComplete())
                    isDataAllFilled = false;
            return isDataAllFilled && !(_currentOrders.Count() == 0);
        }

        //Get Record State
        public List<int> GetRecordState(int drinkIndex)
        {
            List<int> recordState = new List<int>();

            if (_currentOrders.Count() > 0 && drinkIndex >= 0 && drinkIndex < _currentOrders.Count())
            {
                int count = 0;
                List<DrinkAddition> additionList = _currentOrders[drinkIndex].addition;

                foreach (DrinkAddition eachAddition in _drinkAddition)
                {
                    if (additionList.Exists(item => item.name == eachAddition.name && item.price == eachAddition.price))
                        recordState.Add(count);

                    count++;
                }
            }

            return recordState;
        }

        //Add Drink To Current Order
        public void AddAdditionToCurrentOrders(int drinkIndex, int additionIndex)
        {
            _currentOrders[drinkIndex].AddDrinkAddition(_drinkAddition[additionIndex]);
        }

        //Get history Detail
        public List<List<string>> GetHistoryDetail(int index)
        {
            if (_historyPurchaseOrder.Count > 0 && index < _historyPurchaseOrder.Count && index >= 0)
                return _historyPurchaseOrder[index].GetDetail();
            else
                return new List<List<string>>();
        }

        //Get history DrinkList
        public int GetHistoryDetailPrice(int index)
        {
            if (_historyPurchaseOrder.Count > 0 && index < _historyPurchaseOrder.Count && index >= 0)
                return _historyPurchaseOrder[index].GetPurchaseOrderTotalPrice();
            else
                return 0;
        }

        //Get Current Order DrinkList
        public List<List<string>> GetCurrentOrderDrinkListString()
        {
            return _ezDrinkModelToolBox.GetListString<Order>(_currentOrders);
        }

        //Get Drink List
        public List<List<string>> GetDrinkMenuString()
        {
            return _ezDrinkModelToolBox.GetListString<Drink>(_drinkList);
        }

        //Get Addition Menu String
        public List<List<string>> GetAdditionMenuString()
        {
            return _ezDrinkModelToolBox.GetListString<DrinkAddition>(_drinkAddition);
        }

        //Delete Drink List Drink
        public void DeleteList(int index, bool isDrinkList = true)
        {
            if (index >= 0 && index < _drinkList.Count && isDrinkList)
            {
                _currentOrders.RemoveAll(item => ReferenceEquals(item.drink, _drinkList[index]));
                _drinkList.RemoveAt(index);
            }
            else if (index >= 0 && index < _drinkAddition.Count && !isDrinkList)
            {
                foreach (Order eachOrder in _currentOrders)
                    eachOrder.RemoveAddition(_drinkAddition[index]);
                _drinkAddition.RemoveAt(index);
            }
        }

        //Modify Drink List Drink
        public void ModifyDrinkOrAdditionList(int rowIndex, int columnIndex, bool isDrinkList, string data = null)
        {
            if (data != null)
            {
                if (isDrinkList)
                {
                    if (columnIndex == NAME_INDEX && !_drinkList.Exists(item => item.name == data))
                        _drinkList[rowIndex].SetName(data);
                    else if (columnIndex == PRICE_INDEX)
                        _drinkList[rowIndex].SetPrice(data);
                }
                else
                {
                    if (columnIndex == NAME_INDEX && !_drinkAddition.Exists(item => item.name == data))
                        _drinkAddition[rowIndex].SetName(data);
                    else if (columnIndex == PRICE_INDEX)
                        _drinkAddition[rowIndex].SetPrice(data);
                }
            }
        }

        //Is New Drink Or Addition
        public bool IsNewDrinkOrAddition(string name, int price, bool isDrink)
        {
            if (isDrink && !_drinkList.Exists(drink => drink.name == name))
            {
                _drinkList.Add(new Drink(name, price));
                return true;
            }
            else if (!isDrink && !_drinkAddition.Exists(addition => addition.name == name))
            {
                _drinkAddition.Add(new DrinkAddition(name, price));
                return true;
            }
            else
                return false;
        }

        //Is Success ReloadFile
        public bool IsSuccessReloadFile(string fileName, bool isDrinkList)
        {
            if (fileName == string.Empty)
                return false;
            if (isDrinkList)
                return _ezDrinkModelToolBox.IsSuccessLoadList(ref _drinkList, fileName);
            else
                return _ezDrinkModelToolBox.IsSuccessLoadList(ref _drinkAddition, fileName);
        }

    }
}
