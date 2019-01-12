using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class ListOrdersRepository : IOrdersRepository
    {
        private List<Orders> orders = new List<Orders>();

        private int nextId = 1;

        public void AddOrder(Orders o)
        {
            o.Id = nextId++;
            orders.Add(o);
        }

        public ICollection<Orders> GetOrders()
        {
            return orders;
        }
    }
}
