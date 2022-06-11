using System;

class MainClass {
  static int[] arr = new int[] {87,2,44,0,1,44,6,77,100,0};
  public static void Main (string[] args) {
    Console.WriteLine("Array before Sorting;");
    foreach(var item in arr){
      Console.Write(item+" ,");
    }
    BubbleSort();
    Console.WriteLine("\nArray after Sorting;");
    foreach(var item in arr){
      Console.Write(item+" ,");
    }
  }
  public static void BubbleSort(){
    bool isSorted;
    for(int i=0;i<arr.Length;i++){
      isSorted = true;
      for(int j=1;j<arr.Length-i;j++){
        if (arr[j]<arr[j-1]){
          Swap(j,(j-1));
          isSorted = false;
        }
      }
      if (isSorted)
        return;
    }
  }
  public static void Swap(int i, int j){
    int temp;
    temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
  }
}