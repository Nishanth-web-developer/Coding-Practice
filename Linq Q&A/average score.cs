Join Students with Marks and Get Average
Problem: Join students with marks and get each student's average score.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Student {
        public int Id {get;set;}
        public string Name {get;set;}
    }
    class Mark {
        public int StudentId {get;set;}
        public string Subject {get;set;}
        public int Score {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var students = new List<Student> {
                    new Student { Id = 1, Name = "Alice" },
                    new Student { Id = 2, Name = "Bob" }
            };

            var marks = new List<Mark> {
                new Mark { StudentId = 1, Subject = "Math", Score = 85 },
                new Mark { StudentId = 1, Subject = "Science", Score = 90 },
                new Mark { StudentId = 2, Subject = "Math", Score = 70 }
            };

            var result = from s in students
                        join m in marks on s.Id equals m.StudentId into studAvg
                        select new {
                            Name =s.Name,
                            StudentAverageMark = studAvg.Any() ? studAvg.Average(m=>m.Score) :0
                        };
            
            foreach(var student in result){
                Console.WriteLine($"{student.Name} average score is {student.StudentAverageMark}");
            }

        }
    }
}
