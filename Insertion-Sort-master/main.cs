using System;

class MainClass {
  static int[] arr = new int[] {5,77,2,65,0,1,5,8,3,56,5};
  public static void Main (string[] args) {
    Console.WriteLine("Given Array:");
    foreach(var item in arr){
      Console.Write(item+" ,");
    }
    InsertionSort();
    
    Console.WriteLine("\nArray after insertion sort :");
    foreach(var item in arr){
      Console.Write(item+" ,");
    }
  }
  public static void InsertionSort(){
    int current;
    int j;
    for(int i=1;i<arr.Length;i++){   
    j=i-1;
      current = arr[i];      
      while(j>=0 && arr[j]>current){
         
    
        arr[j+1]=arr[j];
      j--;
      }
      arr[j+1]=current;
    }
  }
}