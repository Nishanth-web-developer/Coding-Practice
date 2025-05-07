Group Products by Category and Count
Problem: Group products by category and get the count of products in each category.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Product {
        public string Name {get;set;}
        public string Category {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var products = new List<Product> {
                new Product { Name = "Phone", Category = "Electronics" },
                new Product { Name = "TV", Category = "Electronics" },
                new Product { Name = "Chair", Category = "Furniture" }
            };

            var result = products.GroupBy(p=>p.Category).Select(g=> new{
                Category = g.Key,
                ProductCount = g.Count()
            });
            foreach(var product in result){
                Console.WriteLine($"{product.Category} count is {product.ProductCount}");
            }

        }
    }
}
