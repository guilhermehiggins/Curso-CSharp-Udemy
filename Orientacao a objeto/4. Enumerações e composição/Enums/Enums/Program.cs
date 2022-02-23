// Exercicio proposto:
//
// Ler os dados de um pedido com N itens (N fornecido pelo usuário).
// Depois, mostrar um sumário do pedido conforme exemplo(próxima página).
// Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now
// (Foi passado o UML)

using System;
using System.Globalization;
using Enums.Entities.Enums;
using Enums.Entities;
using System.Collections.Generic;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int quantItems = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem items = new OrderItem(quant, productPrice, product);
                order.AddItem(items);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
