12. Count Tasks per User
Problem: Get a list of users with the count of their tasks.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    public class User{
        public int Id {get;set;}
        public string Name  {get;set;}
        public List<Task>  Tasks  {get;set;}
        
    }
    public class Task{      
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Name = "John", Tasks = new List<Task> { new Task(), new Task() } },
                new User { Id = 2, Name = "Jane", Tasks = new List<Task> { new Task() } }
            };
            var result = users.GroupBy(u=>u.Id).Select(g=> new{
                Id=g.Key,
                Count=g.Sum(u => u.Tasks?.Count ?? 0)
            });
            foreach(var user in result){
                Console.WriteLine($"User {user.Id} => Task count = {user.Count}");
            }
        }
    }
}
