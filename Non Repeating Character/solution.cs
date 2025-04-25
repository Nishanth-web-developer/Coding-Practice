using System;
using System.Collections.Generic;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            string input = Console.ReadLine();
            char result = FirstNonRepeatingChar(input);
            Console.WriteLine(result);
        }
        public static char FirstNonRepeatingChar(string input){
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach(char c in input){
                if(frequency.ContainsKey(c)){
                    frequency[c]++;
                }else{
                    frequency[c]=1;
                }
            }
            foreach(char c in input){
                if(frequency[c]==1){
                    return c;
                }
            }
            return '_';
        }
    }
}
