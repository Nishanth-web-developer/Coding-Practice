Get Most Recent Task Per User
Problem: For each user, get their most recently added task.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class User{
        public int Id {get;set;}
        public List<Task> Tasks {get;set;}
    }
    class Task{
        public int Id {get;set;}
        public DateTime CreatedAt {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
           var users = new List<User> {
                new User {
                    Id = 1,
                    Tasks = new List<Task> {
                        new Task { Id = 1, CreatedAt = new DateTime(2024, 1, 1) },
                        new Task { Id = 2, CreatedAt = new DateTime(2024, 5, 1) }
                    }
                },
                new User {
                    Id = 2,
                    Tasks = new List<Task> {
                        new Task { Id = 3, CreatedAt = new DateTime(2024, 3, 10) }
                    }
                }
            };

            var result = users.Select(u=> new{
                Id=u.Id,
                MyTask = u.Tasks.OrderByDescending(t=>t.CreatedAt).FirstOrDefault()
            });
            
            foreach(var task in result){
                Console.WriteLine($"{task.Id} - {task.MyTask.Id} - {task.MyTask.CreatedAt:yyyy/MM/dd}");
            }

        }
    }
}
