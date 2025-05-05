2. Project Entity to DTO
Problem: Convert a list of Employee objects into EmployeeDto for API output.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler {
    class EmployeeDto{
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Department{get;set;}
    }
    class Employee{
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}    
        public Department Department {get;set;}
        public int DepartmentId {get;set;}
    }
    class Department {
        public int Id {get;set;}
        public string Name {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var employees = new List<Employee> {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Department = new Department { Name = "HR" } },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Department = new Department { Name = "Finance" } }
            };

            var result= employees.Select(e=> new EmployeeDto{
                Id=e.Id,
                FirstName=e.FirstName,
                LastName=e.LastName,
                Department=e.Department.Name
            });
            
            foreach(var emp in result){
                Console.WriteLine($"{emp.Id}-{emp.FirstName}-{emp.LastName}-{emp.Department}");
            }
        }
    }
}
