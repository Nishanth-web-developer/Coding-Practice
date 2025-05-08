27. Find Longest Comment per Post
Problem: For each post, find the longest comment based on text length.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Post{
        public int Id {get;set;}
        public List<Comment> Comments {get;set;}
    }
    public class Comment{
        public int Id {get;set;}
        public string Text {get;set;}
    }
    class Program {
        public static void Main(string[] args) {
            var posts = new List<Post> {
                new Post {
                        Id = 1,
                        Comments = new List<Comment> {
                            new Comment { Id = 1, Text = "Nice" },
                            new Comment { Id = 2, Text = "Very informative and helpful!" }
                        }
                    },
            new Post {
                    Id = 2,
                    Comments = new List<Comment> {
                        new Comment { Id = 3, Text = "Okay." }
                    }
                }
            };
            var result = posts.Select(p=> new{
                Id=p.Id,
                LargeComment = p.Comments.OrderByDescending(c => c.Text.Length).FirstOrDefault()?.Text
            });
            foreach(var post in result){
                Console.WriteLine($"{post.Id} - {post.LargeComment}");
            }
        }
    }
}
