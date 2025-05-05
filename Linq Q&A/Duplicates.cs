6. Check for Duplicates
Problem: Check if there are duplicate emails in the user list.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class User{
        public int Id {get;set;}
        public string Email {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Email = "john.doe@example.com" },
                new User { Id = 2, Email = "jane.smith@example.com" },
                new User { Id = 3, Email = "john.doe@example.com" }
            };

            var result = users.GroupBy(u=>u.Email).Where(g=>g.Count()>1).Select(g=>g.Key);
            foreach(var email in result){
                Console.WriteLine(email);
            }
            
        }
    }
}
