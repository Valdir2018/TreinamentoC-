using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_enumeration_composition.Entities;
using course_enumeration_composition.Entities.Enums;

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
          





            Console.ReadKey();
        }
    }
}
