4. Group Orders by Customer
Problem: Group a list of orders by customer ID.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class Order{
        public int Id {get;set;}
        public int CustomerId {get;set;}
        public decimal TotalAmount {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var orders = new List<Order> {
                new Order { Id = 1, CustomerId = 1, TotalAmount = 100 },
                new Order { Id = 2, CustomerId = 2, TotalAmount = 200 },
                new Order { Id = 3, CustomerId = 1, TotalAmount = 150 }
            };
            var result = orders.GroupBy(o=>o.CustomerId).Select(g=> new{
                Customer = g.Key,
                Amount = g.Sum(o => o.TotalAmount)
            });
            foreach(var order in result){
                Console.WriteLine($"Customer-{order.Customer} total order amount is {order.Amount}");
            }

        }
    }
}
