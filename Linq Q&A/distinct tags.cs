Get Distinct Values
Problem: Get a list of distinct tags used in blog posts.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class Post{
        public int Id {get;set;}
        public List<string> Tags {get;set;}
    }

    class Program {
        public static void Main(string[] args) {
            var posts = new List<Post> {
                    new Post { Id = 1, Tags = new List<string> { "ASP.NET", "C#" } },
                    new Post { Id = 2, Tags = new List<string> { "C#", "LINQ" } },
                    new Post { Id = 3, Tags = new List<string> { "ASP.NET", "LINQ" } }
                };

            var result = posts.SelectMany(t=>t.Tags).Distinct();
            foreach(string post in result){
                Console.WriteLine(post);
            }            
        }
    }
}
