14. Get Customers with Total Purchase Over 1000
Problem: Return customers whose total purchase amount exceeds 1000.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    public class Customer{
        public int Id {get;set;}
        public List<Order>  Orders  {get;set;}
        
    }
    public class Order{      
        public int TotalAmount {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var customers = new List<Customer> {
                    new Customer {
                        Id = 1,
                        Orders = new List<Order> {
                            new Order { TotalAmount = 500 },
                            new Order { TotalAmount = 600 }
                        }
                    },
                    new Customer {
                        Id = 2,
                        Orders = new List<Order> {
                            new Order { TotalAmount = 300 }
                            }
                        }
                    };


            var result = customers.Select(c=> new{
                Id = c.Id,
                TotalBillAmount = c.Orders.Sum(o=>o.TotalAmount)
            }).Where(c=>c.TotalBillAmount>1000);

            foreach(var customer in result){
                Console.WriteLine($"Customer {customer.Id} bill amount exceeds than 1000");
            }
        }
    }
}
