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
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.Write("Enter order data: ");
            Console.Write("Status:");
            OrderStatus orderStatus;
            Enum.TryParse("PROCESSING", true, out orderStatus);

        


            Console.WriteLine("How many itens to this order ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= n; i++)
            {
                Console.Write($"Enter {i} item data: ");
                Console.Write("product name: ");
                string Name = Console.ReadLine();
                Console.Write("Protuct Price:");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int Qtd = int.Parse(Console.ReadLine());

                Product product = new Product(Name, Price);
                OrderItem orderItem = new OrderItem(Qtd, Price);
                Order order = new Order();
                order.AddItem(orderItem);


                Console.WriteLine(order);

            }







            Console.ReadKey();
        }
    }
}
