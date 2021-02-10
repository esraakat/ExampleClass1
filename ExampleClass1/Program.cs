using System;

namespace ExampleClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.productId = 111;
            product1.productName = "T-Shirt";
            product1.productPrice = 35.95;

            Products product2 = new Products();
            product2.productId = 222;
            product2.productName = "Skirt";
            product2.productPrice = 49.99;

            Products product3 = new Products();
            product3.productId = 333;
            product3.productName = "Hat";
            product3.productPrice = 15.50;

            Products product4 = new Products();
            product4.productId = 444;
            product4.productName = "Pants";
            product4.productPrice = 89.50;

            Products[] products = new Products[] { product1, product2, product3, product4 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productId + ": " + products[i].productName + ": " + products[i].productPrice);
            }

            Console.WriteLine("----------For loop ended.----------\n");

            foreach (Products product in products)
            {
                Console.WriteLine(product.productId + ": " + product.productName + ": " + product.productPrice);
            }

            Console.WriteLine("----------Foreach loop ended.----------\n");

            int j = 0;

            while (j < products.Length)
            {
                Console.WriteLine(products[j].productId + ": " + products[j].productName + ": " + products[j].productPrice);
                j++;
            }

            Console.WriteLine("----------While loop ended.----------\n");
        }
    }

    class Products
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
    }
}
