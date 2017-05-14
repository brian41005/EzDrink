using System;
using System.Collections.Generic;
namespace EzDrink
{
    public class Order
    {
        private int _totalPrice;
        private Drink _drink;
        private Sugar _sugar;
        private Temperature _temperature;
        private List<DrinkAddition> _drinkAddition;
        private const string COMMA_AND_SPACE = ", ";

        //intialize
        public Order(Drink drink)
        {
            _drink = drink;
            _totalPrice = _drink.price;
            _drinkAddition = new List<DrinkAddition>();
            _sugar = new Sugar();
            _temperature = new Temperature();
        }

        //get
        public Drink drink
        {
            get
            {
                return _drink;
            }
        }

        //get addition
        public List<DrinkAddition> addition
        {
            get
            {
                return _drinkAddition;
            } 
        }

        //Get Copy
        public Order GetCopy()
        {
            Order orders = new Order(_drink.GetCopy());
            foreach (DrinkAddition eachAddition in _drinkAddition)
                orders.AddDrinkAddition(eachAddition.GetCopy());
            orders.SetSweetLevel(_sugar.level);
            orders.SetTemperature(_temperature.level);
            orders.GetTotalPrice();
            return orders;
        }

        //Remove Addition
        public void RemoveAddition(DrinkAddition addition)
        {
            _drinkAddition.RemoveAll(item => object.ReferenceEquals(item, addition));
        }

        //Add Drink
        public void AddDrinkAddition(DrinkAddition addition)
        {
            _drinkAddition.Add(addition);
            _totalPrice += addition.price;
        }

        //Set Temperature
        public void SetTemperature(string temperatureLevel)
        {
            _temperature.SetTemperature(temperatureLevel);
        }

        //Get total price
        public int GetTotalPrice()
        {
            _totalPrice = _drink.price;
            foreach (DrinkAddition eachAddition in _drinkAddition)
                _totalPrice += eachAddition.price;
            return _totalPrice;
        }

        //Get Sweetness
        public string GetSweetLevel()
        {
            return _sugar.level;
        }

        //Set Sweetness
        public void SetSweetLevel(string sugar)
        {
            _sugar.SetSugarLevel(sugar);
        }

        //Get Temperature
        public string GetTemperature()
        {
            return _temperature.level;
        }

        //Get Addition String
        public string GetAdditionString()
        {
            List<string> allAddition = new List<string>();

            foreach (DrinkAddition eachAddition in _drinkAddition)
                allAddition.Add(eachAddition.name);

            return String.Join(COMMA_AND_SPACE, allAddition);
        }

        //Check Is Complete
        public bool CheckIsNotComplete()
        {
            if ( _temperature.IsNone() || _sugar.IsNone())
                return true;
            else
                return false;
        }

        //Get Data List
        public List<string> GetDataList()
        {
            List<string> dataList = new List<string>();
            dataList.Add(_drink.name);
            GetTotalPrice();
            dataList.Add(_totalPrice.ToString());
            dataList.Add(_sugar.level);
            dataList.Add(_temperature.level);
            dataList.Add(GetAdditionString());
            return dataList;
        }

    }
}