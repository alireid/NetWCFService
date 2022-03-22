
namespace ProductClient
{
    using System;
    using System.Collections.Generic;
    using ProductClient.DataServices;
    using ProductClient.WCFProductService;

    class Program
    {
        private static ProductClientDataService _service;

        // Constants
        private const string Quit = "Q";
        private const string Edit = "E";
        private const string Delete = "D";
        private const string New = "N";
        private const string ListAllProducts = "L";
        private const string Yes = "Y";

        static void Main(string[] args)
        {
            _service = new ProductClientDataService();

            // Space so that ToUpper Doesnt Crashes!
            string userInput = "";

            while (userInput.ToUpper() != Quit)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("L) List all Products");
                Console.WriteLine("N) Enter a new Product");
                Console.WriteLine("Q) Quit");
                Console.Write("Please enter a command: ");

                userInput = Console.ReadLine().ToUpper();
                int ProductIndex = default (int);

                if (userInput == ListAllProducts)
                {
                    ListProducts();
                }
                else if (userInput == New)
                {
                    EnterProduct();
                }
                else if (Int32.TryParse(userInput, out ProductIndex))
                {
                    DisplayProduct(ProductIndex);
                }
            }
        }

        private static void DisplayProduct(int ProductId)
        {
            Product Product = _service.GetProductByID(ProductId);
            Console.WriteLine("Product Id: {0}), Posted By: {1} ", Product.Id, Product.Name);
            Console.WriteLine("Product: {0}", Product.Desc);
            Console.WriteLine("---------------");
            Console.WriteLine("E) Edit Product");
            Console.WriteLine("D) Delete Product");
            Console.WriteLine("C) Continue");
            Console.Write("Please enter a command: ");

            var userInput = Console.ReadLine().ToUpper();
            if (userInput == Edit)
            {
                EditProduct(ProductId);
            }
            else if (userInput == Delete)
            {
                DeleteProduct(ProductId);
            }
        }

        private static void EditProduct(int ProductId)
        {
            Console.WriteLine("---------------");

            Console.Write("Product Name?");
            var ProductName = Console.ReadLine();

            Console.Write("New Product Desc? ");
            var ProductDesc = Console.ReadLine();            

            Product Product = new Product
            {
                Id = ProductId,
                Name = ProductName,
                Desc = ProductDesc
            };

            _service.UpdateProduct(Product);
        }

        private static void EnterProduct()
        {
            Console.WriteLine("---------------");
            Console.Write("Product Name? ");
            var ProductName = Console.ReadLine();

            Console.Write("New Product Desc? ");
            var ProductDesc = Console.ReadLine(); 

            Product Product = new Product
            {
                Name = ProductName,
                Desc = ProductDesc
            };

            _service.CreateProduct(Product);
        }

        static void ListProducts()
        {
            IList<Product> Products = _service.GetProducts();

            Console.WriteLine("---------------");
            foreach (Product Product in Products)
            {
                Console.WriteLine("Product Id: {0}), Product Name: {1} ", Product.Id, Product.Name);
                Console.WriteLine("Product Desc: {0}", Product.Desc);
            }
            Console.WriteLine("---------------");
        }

        private static void DeleteProduct(int ProductId)
        {
            Console.WriteLine("---------------");
            Console.Write("Are you sure you want to delete this Product? (Y/N) ");

            var userInput = Console.ReadLine().ToUpper();
            if (userInput == Yes)
            {
                _service.DeleteProduct(ProductId);
            }
        }
    }
}
