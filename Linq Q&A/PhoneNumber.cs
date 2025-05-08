 29. Replace Nulls with Defaults
Problem: Replace null PhoneNumber with "Not Provided" in user list.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class User{
        public int Id {get;set;}
        public string Name {get;set;}
        public string PhoneNumber {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var users = new List<User> {
                new User { Id = 1, Name = "A", PhoneNumber = "123456" },
                new User { Id = 2, Name = "B", PhoneNumber = null }
            };

            var result = users.Select(u=> new {
                Id=u.Id,
                Name=u.Name,
                PhoneNumberStatus= u.PhoneNumber!=null?u.PhoneNumber :"Not Provided"
            });
            foreach(var user in result){
                Console.WriteLine($"{user.Id} - {user.Name} - {user.PhoneNumberStatus}");
            }
        }
    }
}
