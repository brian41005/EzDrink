using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class DrinkAddition : Item
    {
        //intialize
        public DrinkAddition(string name, int price) : base(name, price)
        {
        }

        //Get Copy
        public DrinkAddition GetCopy()
        {
            return new DrinkAddition(_name, _price);
        }
    }
}
