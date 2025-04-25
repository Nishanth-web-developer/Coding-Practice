using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            string str1=Console.ReadLine().ToLower(); 
            string str2=Console.ReadLine().ToLower();
            bool result = AreAnagrams( str1,  str2);   
            Console.WriteLine(result);
        }
        public static bool AreAnagrams(string str1, string str2){
            char[] charArr1 = str1.ToCharArray();
            char[] charArr2 = str2.ToCharArray();
            Array.Sort(charArr1);
            Array.Sort(charArr2);
            String s1 = new String(charArr1);
            String s2 = new String(charArr2);
            return s1==s2;
        }
    }
}
