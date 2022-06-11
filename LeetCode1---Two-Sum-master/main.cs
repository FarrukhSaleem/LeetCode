using System;
using System.Collections.Generic;

class MainClass {  
  public static void Main (string[] args) {    
    uint n= 00000000000000000000000000001011;
    int result=0;
   result=HammingWeight(n);
    
      Console.WriteLine(result.ToString());
        
  }
 public static int HammingWeight(uint n) {
        int count=0;
        int test=00000000000000000000000000000001;
        for (int i=0;i<32;i++){
            test = test << i;
        if(!((test & n) == 00000000000000000000000000000000))
            count++;
        }
        return count;
    }
}