using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Sugar
    {
        private const string REGULAR_SUGAR_STRING = "正常";
        private const string HALF_SUGAR_STRING = "半糖";
        private const string QUARTER_SUGAR_STRING = "微糖";
        private const string SUGAR_FREE_STRING = "無糖";
        private const string NO_SELECT = "";
        private string _sugarLevel;

        //intialize
        public Sugar()
        {
            _sugarLevel = NO_SELECT;
        }

        //get 
        public string level
        {
            get
            {
                return _sugarLevel;
            }
        }

        //set
        public void SetSugarLevel(string sugar)
        {
            if (sugar != REGULAR_SUGAR_STRING && sugar != HALF_SUGAR_STRING && sugar != QUARTER_SUGAR_STRING && sugar != SUGAR_FREE_STRING)
                _sugarLevel = NO_SELECT;
            else
                _sugarLevel = sugar;
        }

        //
        public bool IsNone()
        {
            if (_sugarLevel == NO_SELECT)
                return true;
            else
                return false;
        }
    }

}
