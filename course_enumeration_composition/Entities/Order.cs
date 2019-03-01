using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_enumeration_composition.Entities.Enums;
using course_enumeration_composition.Entities;
using System.Globalization;

namespace course_enumeration_composition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        // Implementação do Nelio Alves
        public double Total()
        {
            double sum = 0.0;
            // Para cada item sum recebe o valor e soma com o valor da SubTotal
            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        // Método implementado pelo Nélio Alves
        /*
         * Sobre o StringBuilder ->Representa uma cadeia de caracteres mutável. Essa classe não pode ser herdada.
         * 
         * 
         * 
         * 
         * 
         * /
         * */
        public override string ToString()
        {
            StringBuilder sb = new  StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
