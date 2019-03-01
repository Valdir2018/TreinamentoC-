using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_enumeration_composition.Entities;
using course_enumeration_composition.Entities.Enums;
using System.Globalization;

namespace course_enumeration_composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter order data: ");
 
            Console.Write("Status:");
            OrderStatus Status;
            Enum.TryParse("PROCESSING", true, out Status);

            // Instância do Obj de Cliente
            Client client = new Client(name, email, birthdate);

            // Instância do Obj de Pedidos
            Order order = new Order(DateTime.Now, Status, client); // Pega a hora atual,o status e cliente


           
            Console.WriteLine("How many itens to this order ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= n; i++)
            {
                Console.Write($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product Price:");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int Qtd = int.Parse(Console.ReadLine());

                Product product = new Product(ProductName, Price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


                OrderItem orderItem = new OrderItem(quantity, Price, product);
                order.AddItem(orderItem);


               

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
       
            Console.ReadKey();
        }
    }
}
