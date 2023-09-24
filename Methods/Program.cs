using System;

namespace Methods
{

    class Program
    {
        public static void Main(string[] args)
        {
            //createing array of strings named fruits 
            string[] fruits = new string[] { };

            //creating instances of Product
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.ProductPrice = 10;
            product1.ProductDescription = "Amasya elması";
            product1.stockQuantity = 10;

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 10;
            product2.ProductDescription = "Diyarbakır karpuzu";
            product2.stockQuantity = 19;

            //creating array of product instances
            Product[] products = new Product[] { product1, product2 };

            //typesafe - tip güvenli 
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice + " TL");
                Console.WriteLine(product.ProductDescription);
                Console.WriteLine(product.stockQuantity + " KG");
                Console.WriteLine("- - - - - - - - - - ");
            }

            Console.WriteLine("- - - - -METHODS- - - - -");

            CartManager cartManager = new CartManager();
            cartManager.addProduct(product1);
            cartManager.addProduct(product2);
            cartManager.addProduct2("Armut", "Yeşil armut", 14);
        }
    }
}

// do not repeat yourself - DRY - clean code - best practice