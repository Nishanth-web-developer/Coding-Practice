11. Flatten a List of Lists
Problem: Flatten a list of users’ hobbies into a single list of hobbies.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    public class User{
        public int Id {get;set;}
        public string Name  {get;set;}
        public List<string> Hobbies  {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                    new User { Id = 1, Name = "Alice", Hobbies = new List<string> { "Reading", "Cycling" } },
                    new User { Id = 2, Name = "Bob", Hobbies = new List<string> { "Gaming", "Reading" } }
                };
            var result = users.SelectMany(u=>u.Hobbies).Distinct();
            foreach(string hobby in result){
                Console.WriteLine(hobby);
            }
        }
    }
}
