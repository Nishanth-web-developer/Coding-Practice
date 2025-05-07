21. Get Overdue Tasks
Problem: Get all tasks whose due date is before today and are not completed.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Task {
        public int Id {get;set;}
        public string Title {get;set;}
        public DateTime DueDate {get;set;}
        public bool IsCompleted {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var tasks = new List<Task> {
                    new Task { Id = 1, Title = "Task A", DueDate = DateTime.Today.AddDays(-1), IsCompleted = false },
                    new Task { Id = 2, Title = "Task B", DueDate = DateTime.Today.AddDays(2), IsCompleted = false },
                    new Task { Id = 3, Title = "Task C", DueDate = DateTime.Today.AddDays(-3), IsCompleted = true }
            };
            var result = tasks.Where(t=>t.DueDate<DateTime.Today && t.IsCompleted == false );
            foreach(var task in result){
                Console.WriteLine($"{task.Title}");
            }

        }
    }
}
