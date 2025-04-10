using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Student{
        public string Name {get;set;}
        public string Department {get;set;}
        public List<int> Marks {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            List<Student> studentList = new List<Student>(){
                new Student {Name = "Nishanth" ,Department = "ECE" ,Marks = new List<int>() {90,87,96}},
                new Student {Name = "Kesavan" ,Department = "ECE" ,Marks = new List<int>() {82,79,90}},
                new Student {Name = "Mayavan" ,Department = "CSE" ,Marks = new List<int>() {88,98,84}},
                new Student {Name = "Saravanan" ,Department = "CSE" ,Marks = new List<int>() {90,86,96}},
                new Student {Name = "Vignesh" ,Department = "MECH" ,Marks = new List<int>() {87,92,89}}
            };

            var topStudent = studentList.OrderByDescending(s=>s.Marks.Average()).Take(1).Select(s=> new {Name=s.Name,Average =s.Marks.Average()}).FirstOrDefault();
            Console.WriteLine($"Top Student: {topStudent.Name} (Average: {topStudent.Average:F2})");
            var departmentAverage = studentList.GroupBy(s => s.Department).Select(g => new{Department = g.Key,Average = g.Average(s => s.Marks.Average())});
            Console.WriteLine("Department Averages:");
            foreach(var deptavg in departmentAverage){
                Console.WriteLine($"- {deptavg.Department} : {deptavg.Average:F2}");
            } 
       
        }
    }
}
