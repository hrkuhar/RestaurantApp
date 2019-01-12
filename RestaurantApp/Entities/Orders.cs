using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }

        [NotMapped]
        public Cart Cart { get; set; }
    }
}
