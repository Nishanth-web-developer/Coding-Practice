✅ 15. Get Top-Selling Product
Problem: Find the product with the highest total quantity sold.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class OrderItem{
        public int ProductId{get;set;}
        public int Quantity{get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var orderItems = new List<OrderItem> {
                new OrderItem { ProductId = 1, Quantity = 5 },
                new OrderItem { ProductId = 2, Quantity = 10 },
                new OrderItem { ProductId = 1, Quantity = 3 }
            };
            var result = orderItems.OrderByDescending(o=>o.Quantity).FirstOrDefault();
            Console.WriteLine($"Product {result.ProductId} is the maximum available quantity {result.Quantity}");
        }
    }
}
