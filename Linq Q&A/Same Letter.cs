✅ 25. Find Names Starting and Ending with Same Letter
Problem: Return names that start and end with the same character (case-insensitive).
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            var names = new List<string> { "Anna", "Bob", "Alice", "Eve", "Tom" };
            var result  = names.Where(name=>!string.IsNullOrEmpty(name) && char.ToLower(name.First())==char.ToLower(name.Last()));
            foreach(var name in result){
                Console.WriteLine(name);
            }

        }
    }
}
