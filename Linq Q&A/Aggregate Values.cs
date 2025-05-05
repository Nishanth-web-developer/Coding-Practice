9. Aggregate Values
Problem: Calculate the total amount from a list of invoices.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class Invoice{
        public int Id {get;set;}
        public decimal Amount {get;set;}
    }

    class Program {
        public static void Main(string[] args) {
            var invoices = new List<Invoice> {
                new Invoice { Id = 1, Amount = 500 },
                new Invoice { Id = 2, Amount = 300 },
                new Invoice { Id = 3, Amount = 200 }
            };
            var result = invoices.Sum(i=>i.Amount);
            Console.WriteLine(result);

        }
    }
}
