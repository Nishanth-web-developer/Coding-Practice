 13. Users with All Tasks Completed
Problem: Get users where all tasks are completed.
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
        public bool IsCompleted{get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Name = "A", Tasks = new List<Task> { new Task { IsCompleted = true }, new Task { IsCompleted = true } } },
                new User { Id = 2, Name = "B", Tasks = new List<Task> { new Task { IsCompleted = true }, new Task { IsCompleted = false } } }
                };

            var result = users.Select(u=> new{
                Name = u.Name,
                CompletedTask = u.Tasks?.Count(t => t.IsCompleted) ?? 0
            });
            foreach(var user in result){
                Console.WriteLine($"User {user.Name} => Completed tasks count = {user.CompletedTask}");
            }
        }
    }
}
