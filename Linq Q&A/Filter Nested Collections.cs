8. Filter Nested Collections
Problem: Get users who have at least one completed task.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class User{
        public int Id {get;set;}
        public List<Task> Tasks {get;set;}
    }
    public class Task{
        public int Id {get;set;}
        public bool IsCompleted {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                    new User { Id = 1, Tasks = new List<Task> { new Task { Id = 1, IsCompleted = true }, new Task { Id = 2, IsCompleted = false } } },
                    new User { Id = 2, Tasks = new List<Task> { new Task { Id = 3, IsCompleted = false } } }
                };
            var result = users.Where(u=>u.Tasks.Count(t=>t.IsCompleted==true)>0).Select(u=>u.Id);
            foreach(var userId in result){
                Console.WriteLine(userId);
            }

        }
    }
}
