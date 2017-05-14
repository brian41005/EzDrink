using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class Drink : Item
    {
        //intialize
        public Drink(string name, int price) : base(name, price)
        {
        }

        //Get Copy
        public Drink GetCopy()
        {
            return new Drink(_name, _price);
        }
    }
}
