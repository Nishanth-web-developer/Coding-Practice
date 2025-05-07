24. Get Users Without Tasks
Problem: Return users who have no tasks assigned.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class User {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<Task> Tasks {get;set;}
    }
    class Task {
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Name = "John", Tasks = new List<Task> { new Task() } },
                new User { Id = 2, Name = "Jane", Tasks = new List<Task>() },
                new User { Id = 3, Name = "Jack", Tasks = null }
            };

            var result = users.Select(u=> new {
                Name =u.Name,
                TaskCount = u.Tasks!=null?u.Tasks.Count():0
            }).Where(u=>u.TaskCount==0);
            
            foreach(var user in result){
                Console.WriteLine($"{user.Name} has no tasks");
            }

        }
    }
}
