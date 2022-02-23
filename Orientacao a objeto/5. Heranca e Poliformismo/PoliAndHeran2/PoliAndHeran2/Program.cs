// Exercicio proposto:
//
// Fazer um programa para ler os dados de N produtos(N fornecido pelo usuário).
// Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
// Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
// Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo (próxima página).
// Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto

using System;
using System.Globalization;
using PoliAndHeran2.Entities;
using System.Collections.Generic;

namespace PoliAndHeran2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the numbers of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'c' || typeProduct == 'C')
                {
                    productsList.Add(new Product(name, price));
                }
                else if (typeProduct == 'u' || typeProduct == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productsList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (typeProduct == 'i' || typeProduct == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productsList.Add(new ImportedProduct(name, price, customsFee));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in productsList)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
