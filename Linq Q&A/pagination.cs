3. Get Paginated Results
Problem: Implement pagination with pageNumber and pageSize.
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyCompiler { 
    class Program {
        public static void Main(string[] args) {
            var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int pageNumber = 2, pageSize = 3;
            var result = data.Skip((pageNumber-1)*pageSize).Take(pageSize);
            foreach(var num in result){
                Console.WriteLine(num);
            }

        }
    }
}
