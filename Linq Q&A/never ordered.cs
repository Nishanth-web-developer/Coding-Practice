20. Get Products with No Orders
Problem: Return products that were never ordered.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Product{
        public int Id {get;set;}
        public string Name {get;set;}        
    }
    class OrderItem{
        public int ProductId {get;set;}       
    }
 
    class Program {
        public static void Main(string[] args) {
           var products = new List<Product> {
                new Product { Id = 1, Name = "Phone" },
                new Product { Id = 2, Name = "TV" },
                new Product { Id = 3, Name = "Keyboard" }
            };

            var orderItems = new List<OrderItem> {
                new OrderItem { ProductId = 1 },
                new OrderItem { ProductId = 2 }
            };


            var result = products.Join(orderItems,p=>p.Id,o=>o.ProductId,(p,o)=> new{
                Id=p.Id,
                Name=p.Name
            });
            
            foreach(var OrderedProduct in result){
                Console.WriteLine($"{OrderedProduct.Id} - {OrderedProduct.Name}");
            }

        }
    }
}
