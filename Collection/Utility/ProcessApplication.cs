using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection.DataStore;
using EllasticCollection.UI;


namespace Collection.Utility
{
    public  class ProcessApp
    {

        public void RunApp()
        {
            Console.WriteLine("Welcome to Our Store");
            DisplayOptions();
        }

        public void DisplayAllProduct()
        {
            var products = new List<Models.Products>
            {
                new Models.Products { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },

                new Models.Products { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },

                new Models.Products { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
            };



            var collection = new CollectionsDb(products);
            var allProducts = collection.GetProperties();

            collection.Display(allProducts);
        }

        public void SpecifyProduct()
        {
            Console.WriteLine("Enter the Product to display");
        }
        void DisplayOptions()
        {
            try
            {

                Console.WriteLine("1. Display all Products. \n2. Specify Products you want to display. \n3.  Exit.");
                string Option = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(Option, out int value))
                {
                    switch (value)
                    {
                        case (int)ProductChoice.DisplayAllProduct:
                            DisplayAllProduct();
                            DisplayOptions();
                            Console.Clear();
                            break;
                        case (int)ProductChoice.SpecifyProduct:
                            SpecifyProduct();
                            DisplayOptions();
                            break;
                        case (int)ProductChoice.Exit:
                            Environment.Exit(0);
                            DisplayOptions();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Input is incorrect");
                            DisplayOptions();
                            break;
                    }
                } else
                {
                    Console.WriteLine("Input is incorrect!");
                    DisplayOptions();
                }
            }
            catch
            {
                Console.WriteLine("please input Number");
            }
        }
    }
}
