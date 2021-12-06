/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Globalization;
using System.Collections.Generic;
using Aula133_HerancaPolimorfismo_ExProposto.Entities;

namespace Aula133_HerancaPolimorfismo_ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter products quantity: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (type == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
