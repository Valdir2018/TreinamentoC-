using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace course_enumeration_composition.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }// Faltou essa composição de objetos = Cod do Nélio Alves

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price    = price;
            this.Product = product;
        }


        public double SubTotal()
        {  // Retorna o preço multiplicado pela quantidade
            return Price * Quantity;
        }

        public override string ToString()
        {
            // Trecho reestruturado do codigo dpo Nelio Alves
            return Product.Name
                 + ", $"
                 + Price.ToString("F2", CultureInfo.InvariantCulture)
                 + ", Quantity: "
                 + ", Subtotal: $"
                 + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
