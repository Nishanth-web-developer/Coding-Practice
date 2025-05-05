7. Join Two Collections (Manual Join)
Problem: Join orders and customers manually.
  using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class Customer{
        public int Id {get;set;}
        public string Name {get;set;}
    }
    public class Order{
        public int Id {get;set;}
        public int CustomerId {get;set;}
        public Decimal TotalAmount {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var orders = new List<Order> {
                    new Order { Id = 1, CustomerId = 1, TotalAmount = 100 },
                    new Order { Id = 2, CustomerId = 2, TotalAmount = 200 }
                };
            var customers = new List<Customer> {
                    new Customer { Id = 1, Name = "John Doe" },
                    new Customer { Id = 2, Name = "Jane Smith" }
                };
            var result = orders.Join(customers,o=>o.Id,c=>c.Id,(o,c)=>new{
                CustomerName = c.Name,
                BillAmount = o.TotalAmount
            });
            foreach(var x in result){
                Console.WriteLine($"{x.CustomerName} - {x.BillAmount}");
            }
        }
    }
}
