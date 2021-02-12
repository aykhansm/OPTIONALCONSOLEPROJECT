using System;
using System.Collections.Generic;
using System.Text;

namespace OPTIONALCONSOLEPROJECT
{
    class MenuItem
    {
        private string _no;
        public string No
        {
            get
            {
                return _no;
            }
        }
        public string Name;
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public string Category;
        private static int TotalCount=100;
        public MenuItem(string name,double price,string category)
        {
            this._no = this.Category.Substring(0, 2).ToUpper() + TotalCount;
            TotalCount++;
        }
    }
}
