using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Temperature
    {
        private const string REGULAR_ICE_STRING = "正常";
        private const string WARM_STRING = "溫熱";
        private const string EASY_ICE_STRING = "少冰";
        private const string ICE_FREE_STRING = "去冰";
        private const string NO_SELECT = "";
        private string _temperatureLevel;

        //intialize
        public Temperature()
        {
            _temperatureLevel = NO_SELECT;
        }

        //get 
        public string level
        {
            get
            {
                return _temperatureLevel;
            }
        }

        //set
        public void SetTemperature(string temperature)
        {
            if (temperature != REGULAR_ICE_STRING && temperature != WARM_STRING && temperature != EASY_ICE_STRING && temperature != ICE_FREE_STRING)
                _temperatureLevel = NO_SELECT;
            else
                _temperatureLevel = temperature;
        }

        //Is None
        public bool IsNone()
        {
            if (_temperatureLevel == NO_SELECT)
                return true;
            else
                return false;
        }
    }
}
