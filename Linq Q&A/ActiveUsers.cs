//Problem: Given a list of users, filter all active users with the role of "Admin".
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler {
    class User{
        public int Id {get;set;}
        public string Name {get;set;}
        public bool IsActive {get;set;}
        public string Role {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Name = "John", IsActive = true, Role = "Admin" },
                new User { Id = 2, Name = "Jane", IsActive = false, Role = "User" },
                new User { Id = 3, Name = "Jack", IsActive = true, Role = "Admin" },
                new User { Id = 4, Name = "Jill", IsActive = true, Role = "User" }
            };
            var result = users.Where(u=>u.IsActive==true && u.Role=="Admin").OrderByDescending(u=>u.Id);
            foreach(var u in result){
                Console.WriteLine(u.Name);
            }

        }
    }
}
