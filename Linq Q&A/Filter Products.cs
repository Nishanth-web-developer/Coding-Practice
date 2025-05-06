19. Filter Products by Multiple Criteria
Problem: Get all products that are in category “Electronics” and cost less than 1000.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Product{
        public string Name {get;set;}
        public string Category {get;set;}
        public int Price {get;set;}
    }
 
    class Program {
        public static void Main(string[] args) {
           var products = new List<Product> {
                    new Product { Name = "Laptop", Category = "Electronics", Price = 1200 },
                    new Product { Name = "Tablet", Category = "Electronics", Price = 800 },
                    new Product { Name = "Chair", Category = "Furniture", Price = 150 }
                };

            var result = products.Where(p=>p.Category == "Electronics" && p.Price < 1000).Select(p=> new{
                Name = p.Name,
                Category = p.Category,
                Price = p.Price
            });
            
            foreach(var product in result){
                Console.WriteLine($"{product.Name} - {product.Category} - {product.Price}");
            }

        }
    }
}
