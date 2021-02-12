using System;
using System.Collections.Generic;
using System.Text;

namespace OPTIONALCONSOLEPROJECT
{
    class RestaurantManager : IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<Order> Orders { get; set; }

        public void AddMenuItem(string name, double price, string category)
        {
        }

        public void AddOrder(List<MenuItem> menuitems, int count)
        {
        }

        public void EditMenuItemByNo(string no)
        {
        }

        public List<Order> GetOrderByDate(DateTime date)
        {
        }

        public Order GetOrderByNo(int no)
        {
        }

        public List<Order> GetOrdersByDatesInterval(DateTime firstdate, DateTime seconddate)
        {
        }

        public List<Order> GetOrdersByPriceInterval(double price1, double price2)
        {
        }

        public List<MenuItem> MenuItemsByCategory(string category)
        {
        }

        public List<MenuItem> MenuItemsByPriceInterval(double price1, double price2)
        {
        }

        public List<MenuItem> MenuItemsBySearchValue(string category)
        {
        }

        public void RemoveOrderByNo(int no)
        {
        }
    }
}
