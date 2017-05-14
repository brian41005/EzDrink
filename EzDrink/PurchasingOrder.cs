using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace EzDrink
{
    public class PurchaseOrder
    {
        private List<Order> _purchasingOrder;
        private int _purchasingOrderTotalPrice;
        private string _id;
        private const string DATE_TIME_FORMAT = "yyyy/MM/dd tt hh:mm:ss";

        //intialize
        public PurchaseOrder(List<Order> purchasingOrder)
        {
            _id = DateTime.Now.ToString(DATE_TIME_FORMAT);
            _purchasingOrder = new List<Order>();
            foreach (Order eachOrder in purchasingOrder)
                _purchasingOrder.Add(eachOrder.GetCopy());
            _purchasingOrderTotalPrice = 0;
            foreach (Order eachOrder in purchasingOrder)
                _purchasingOrderTotalPrice += eachOrder.GetTotalPrice();
        }

        //
        public List<string> GetTitle()
        {
            return new List<string>
            {
                _id,
                _purchasingOrderTotalPrice.ToString()
            };
        }

        //Get Order List
        public List<List<string>> GetDetail()
        {
            List<List<string>> orderDetail = new List<List<string>>();
            foreach (Order eachOrder in _purchasingOrder)
                orderDetail.Add(eachOrder.GetDataList());
            return orderDetail;
        }

        //Get Purchase Order Total Price
        public int GetPurchaseOrderTotalPrice()
        {
            return _purchasingOrderTotalPrice;
        }
    }
}
