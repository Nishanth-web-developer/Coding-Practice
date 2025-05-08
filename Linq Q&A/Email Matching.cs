Case-Insensitive Email Matching
Problem: Check if the list contains a user with the email "Admin@Example.com" (ignore case).
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class User{
        public int Id {get;set;}
        public string Email {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Email = "admin@example.com" },
                new User { Id = 2, Email = "user@example.com" }
            };
            string inputEmail = "Admin@Example.com";
            var result = users.Where(u=>u.Email.ToLower()==inputEmail.ToLower()).FirstOrDefault();
            if(result!=null){
                Console.WriteLine($"{result.Email} is exists ");
            }else{
                Console.WriteLine($"{inputEmail} not exists");
            }
        }
    }
}
