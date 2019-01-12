using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public interface IOrdersRepository
    {
        ICollection<Orders> GetOrders();

        void AddOrder(Orders o);

    }
}
