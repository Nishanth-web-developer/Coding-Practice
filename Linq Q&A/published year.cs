16. Group Posts by Year
Problem: Group blog posts by published year.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Post{
        public int Id {get;set;}
        public string Title {get;set;}
        public DateTime PublishedDate {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var posts = new List<Post> {
                new Post { Id = 1, Title = "Post 1", PublishedDate = new DateTime(2023, 1, 10) },
                new Post { Id = 2, Title = "Post 2", PublishedDate = new DateTime(2024, 5, 15) },
                new Post { Id = 3, Title = "Post 3", PublishedDate = new DateTime(2023, 8, 20) }
            };
            var result = posts.GroupBy(p=>p.PublishedDate.Year).Select(g=>new{
                Year = g.Key,
                BlogPosts = g.ToList() 
            });
            foreach(var blogs in result){
                Console.WriteLine(blogs.Year);
                foreach(var blog in blogs.BlogPosts){
                    Console.WriteLine($"{blog.Id} - {blog.Title}");
                }
            }

        }
    }
}
