using System.Linq;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class DrinkModel
    {

        //Get Drink Menu Size
        public int GetDrinkMenuSize()
        {
            return _drinkList.Count();
        }

        //Get Addition Menu Size
        public int GetAdditionMenuSize()
        {
            return _drinkAddition.Count();
        }

        //Get Orders Size
        public int GetOrdersSize()
        {
            return _currentOrders.Count();
        }

        //Exit
        public void ExitEzDrink()
        {
            Application.Exit();
        }

    }
}
