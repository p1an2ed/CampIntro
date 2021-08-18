using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Computer(product1);

            Product product2 = new Product();
            MobilePhone(product2);

            Product[] products = new Product[] { product1, product2 };

            Console.WriteLine("--------------");
            Console.WriteLine("With ForEach");
            Console.WriteLine("");

            Foreach(products);

            Console.WriteLine("--------------");
            Console.WriteLine("With For");
            Console.WriteLine("");

            For(products);

            Console.WriteLine("--------------");
            Console.WriteLine("With While");
            Console.WriteLine("");

            While(products);

            Console.WriteLine("--------------");

            Console.ReadKey(true);
        }

        private static void MobilePhone(Product product2)
        {
            product2.productName = "Mobile Phone";
            product2.productDescription = "You can make calls with it";
            product2.StockAmount = 243;
            product2.Price = 2450;
        }

        private static void Computer(Product product1)
        {
            product1.productName = "Computer";
            product1.productDescription = "Great for Video Editing";
            product1.StockAmount = 99;
            product1.Price = 4500;
        }

        private static void While(Product[] products)
        {
            int number = 0;
            while (number < products.Length)
            {
                Console.WriteLine(products[number].productName + " removed!");
                number++;
            }
        }

        private static void For(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + " updated!");
            }
        }

        private static void Foreach(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.productName + " added!");
            }
        }
    }
}
