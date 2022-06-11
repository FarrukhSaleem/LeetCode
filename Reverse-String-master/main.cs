using System;

class MainClass {
  public static void Main (string[] args) {
    char[] reverseString = ReverseString(".hkiehS meelaS hkurraF si eman yM");
    Console.WriteLine(reverseString);
  }

  public static char[] ReverseString(string str){
    char[] arr = str.ToCharArray();
    char temp;
    for(int i=0; arr.Length >1 && i < ((arr.Length - 1) - i) ;i++){      
      temp = arr[i];
      arr[i] = arr[(arr.Length-1)-i];
      arr[(arr.Length-1)-i] = temp;      
    }
    return  arr;
  }
}