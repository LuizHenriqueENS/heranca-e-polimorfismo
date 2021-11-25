using Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();
            

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++) {
                Console.Write($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char r = Console.ReadLine()[0];
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (r) {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                    case 'i':
                        Console.Write("Customs Fees: ");
                        double customsFees = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFees));
                        break;
                    case 'u':
                        Console.Write("Manufature Date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list) {
                Console.WriteLine(p.PriceTag(), CultureInfo.InvariantCulture);
            }
        }
    }
}
