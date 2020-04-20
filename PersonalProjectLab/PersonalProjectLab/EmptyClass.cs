using System;
namespace PersonalProjectLab
{
    public class Order
    {
        string _ordertype = "";
        string _orderdetail = "";
        int _numtoppings = 0;

        public Order()
        {

        }


        public void addordertype(string ordertype)
        {
            _ordertype = ordertype;

        }
        public void addorderdetail(string orderdetail, int numtoppings)
        {
            _orderdetail = orderdetail;
            _numtoppings = numtoppings;
        }

        public string getorderdetails()
        {
            if (_ordertype=="soup")
            {
                return _orderdetail + " " + _ordertype;
            }
            else if (_ordertype == "salad")
            {
                return _numtoppings + " " + _orderdetail + " " + _ordertype;
            }
            return "UnKnown Order";
        }
    }
}
