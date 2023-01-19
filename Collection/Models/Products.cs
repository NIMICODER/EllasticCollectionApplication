using System;
using System.Collections.Generic;
using System.Text;

namespace Collection.Models
{
    public class Products
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public int OrderCount { get; set; }


        public Products()
        {

        }

        public Products(int id, string name, int quantity, decimal price, string category, int orderCount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Category = category;
            OrderCount = orderCount;

        }
    }
}
