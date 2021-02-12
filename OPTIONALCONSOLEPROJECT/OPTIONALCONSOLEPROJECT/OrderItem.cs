using System;
using System.Collections.Generic;
using System.Text;

namespace OPTIONALCONSOLEPROJECT
{
    class OrderItem
    {
        public MenuItem MenuItem;
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }
        public OrderItem(MenuItem product,int count)
        {
            this.MenuItem = product;
            this.Count = count;
        }
    }
}
