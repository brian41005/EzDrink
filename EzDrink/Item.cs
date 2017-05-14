using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Item
    {
        protected string _name;
        protected int _price;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //Get Drink Name
        public string name
        {
            get
            {
                return _name;
            }
        }

        //Get Drink Price
        public int price
        {
            get
            {
                return _price;
            }
        }

        //Get Data List
        public List<string> GetDataList()
        {
            List<string> dataList = new List<string>(new string[] { _name, _price.ToString() });
            return dataList;
        }

        //SetName
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(name))
                _name = name;
        }

        //SetPrice
        public void SetPrice(string price)
        {
            int tempPrice = 0;
            if (int.TryParse(price, out tempPrice))
                if (tempPrice >= 0)
                    _price = tempPrice;
        }
    }
}
