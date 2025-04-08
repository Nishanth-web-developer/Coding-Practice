using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    
    class Program {
        public static int[] topKFrequencyElements(int k,int[] arr){
        Dictionary<int,int> ElementCounts = new Dictionary<int,int>();

        foreach(int i in arr){
            if(ElementCounts.ContainsKey(i))
                ElementCounts[i]++;
            else
                ElementCounts[i] = 1;
        }

        var result = ElementCounts.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Value).ToArray();
        return result;
    }
        public static void Main(string[] args) {
            int[] arr = {1,1,1,2,2,3};
            int k =2;
            int [] topK = topKFrequencyElements(k,arr);
            foreach(int item in topK){
                Console.WriteLine(item);
            }
            
        }
    }
}
