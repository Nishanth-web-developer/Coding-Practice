using System;
using System.Collections.Generic;

namespace MyCompiler {
    class Program {
        public static (int, int)? FindTopTwo(int[] numbers){
            List<int> arrList = new List<int>();
            foreach(int n in numbers){
                if(!arrList.Contains(n)){
                    arrList.Add(n);
                }
            }
            if(arrList.Count<=1){
                return null;
            }
            for(int i=0;i<arrList.Count;i++){
                for(int j=i+1;j<arrList.Count;j++){
                    if(arrList[i]<arrList[j]){
                        int temp=arrList[j];
                        arrList[j]=arrList[i];
                        arrList[i]=temp;
                    }
                }
            }
            return (arrList[0],arrList[1]);
        }
        public static void Main(string[] args) {    
            int[] numbers ={10, 5, 20, 8, 20};
            var result = FindTopTwo(numbers);
            if(result.HasValue){
                Console.WriteLine(result);
            }else{
                Console.WriteLine("null");
            }
        }
    }
}
