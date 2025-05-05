5. Get Top N Records Sorted by Date
Problem: Return the latest 3 blog posts.

using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    public class Post{
        public int Id {get;set;}
        public string Title {get;set;}
        public DateTime PublishedDate {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var posts = new List<Post> {
                new Post { Id = 1, Title = "Post 1", PublishedDate = new DateTime(2025, 5, 1) },
                new Post { Id = 2, Title = "Post 2", PublishedDate = new DateTime(2025, 4, 25) },
                new Post { Id = 3, Title = "Post 3", PublishedDate = new DateTime(2025, 5, 3) },
                new Post { Id = 4, Title = "Post 4", PublishedDate = new DateTime(2025, 4, 20) }
            };
            var result = posts.OrderByDescending(p=>p.PublishedDate).Take(3).Select(p=> new{
                Id=p.Id,
                Title=p.Title,
                PublishedDate=p.PublishedDate
            });
            foreach(var post in result){
                Console.WriteLine($"{post.Id} - {post.Title} - {post.PublishedDate:yyyy-MM-dd}");
            }
        }
    }
}
