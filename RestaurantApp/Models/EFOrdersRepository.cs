using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class EFOrdersRepository : IOrdersRepository
    {
        RestaurantDBContext context;

        public EFOrdersRepository(RestaurantDBContext c)
        {
            context = c;
        }

        public void AddOrder(Orders o)
        {
            context.Orders.Add(o);
            context.SaveChanges();
        }

        public ICollection<Orders> GetOrders()
        {
            return context.Orders.ToList();
        }
    }
}
