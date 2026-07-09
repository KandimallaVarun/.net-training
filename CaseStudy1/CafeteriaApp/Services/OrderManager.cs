using CafeteriaApp.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CafeteriaApp.Services
{
    public class OrderManager
    {
        private Dictionary<int, MenuItem> menu = new Dictionary<int, MenuItem>();
        private List<Order> orders = new List<Order>();
        private int nextOrderId = 1;

        public OrderManager()
        {
            // Seed Menu Items
            menu.Add(1, new MenuItem(1, "Coffee", 2.5));
            menu.Add(2, new MenuItem(2, "Sandwich", 4.0));
            menu.Add(3, new MenuItem(3, "Pasta", 6.0));
            menu.Add(4, new MenuItem(4, "Juice", 3.0));
            menu.Add(5, new MenuItem(5, "Salad", 3.5));
        }

        public List<MenuItem> ShowMenu()
        {
            return menu.Values.ToList();
        }

        public bool PlaceOrder(int itemId, string name)
        {
            Order oldOrder = orders.Find(order => order.EmployeeName == name);
            if (oldOrder != null)
            {
                oldOrder.Items.Add(menu.GetValueOrDefault(itemId));
                oldOrder.CalculateTotal();
                return true;
            }

            Order order = new Order(nextOrderId++, name);
            //MenuItem newItem = null;
            //foreach (var item in menu)
            //{
            //    if (item.Value.Id == itemId)
            //    {
            //        newItem = item.Value;
            //        break;
            //    }
            //}
            order.Items.Add(menu.GetValueOrDefault(itemId));
            order.CalculateTotal();
            orders.Add(order);
            return true;
        }

        //public MenuItem GetMenuItemById(int id)
        //{
        //    if (menu.ContainsKey(id))
        //    {
        //        return menu[id];
        //    }
        //    return null;
        //}

        public Order SearchOrder(int id)
        {
            //foreach (Order order in orders)
            //{
            //    if(order.OrderId == id)
            //    {
            //        return order;
            //    }
            //}
            //return null;
            return orders.Find(order => order.OrderId == id);
        }

        public bool CancelOrder(int id)
        {
            if(SearchOrder(id) != null)
            {
                orders.Remove(SearchOrder(id));
                return true;
            }

            return false;
        }

        // Helpers for testing
        public void AddOrderForTest(string name, List<int> itemIds)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders() => orders;
    }
}
