18. Conditional Projection
Problem: Return products with a status label: "In Stock" if quantity > 0, "Out of Stock" otherwise.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Product{
        public int Id {get;set;}
        public string Name {get;set;}
        public int Quantity {get;set;}
    }
 
    class Program {
        public static void Main(string[] args) {
           var products = new List<Product> {
                    new Product { Id = 1, Name = "Laptop", Quantity = 5 },
                    new Product { Id = 2, Name = "Mouse", Quantity = 0 }
                };


            var result = products.Select(p=> new{
                Id= p.Id,
                Name = p.Name,
                StockStatus = p.Quantity>0?"In Stock":"Out of Stock"
            });
            
            foreach(var product in result){
                Console.WriteLine($"{product.Id} - {product.Name} - {product.StockStatus}");
            }

        }
    }
}
