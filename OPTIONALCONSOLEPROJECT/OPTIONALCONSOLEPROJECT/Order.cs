using System;
using System.Collections.Generic;
using System.Text;

namespace OPTIONALCONSOLEPROJECT
{
    class Order
    {
        private int _no;
        public int No
        {
            get
            {
                return _no;
            }
        }
        private static int TotalCount = 0;
        private double _totalamount;
        public double TotalAmount
        {
            get
            {
                return _totalamount;
            }
        }
        public List<OrderItem> OrderItems;
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
        public Order()
        {
            TotalCount++;
            this._date = DateTime.Now;
            this._no = TotalCount;
            this.OrderItems = new List<OrderItem>();
           
            this._totalamount = this.GetTotalAmount();
        }
        public double GetTotalAmount()
        {
            double sum = 0;
            foreach (OrderItem item in this.OrderItems)
            {
                sum += item.MenuItem.Price * item.Count;
            }
            return sum;
        }
    }
}
