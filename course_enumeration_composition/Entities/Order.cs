using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_enumeration_composition.Entities.Enums;
using course_enumeration_composition.Entities;

namespace course_enumeration_composition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status)
        {
            this.Moment = moment;
            this.Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
          
        }
    }
}
