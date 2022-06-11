using System;

class MainClass {
  static int num2search = 22;
  static int arrindex;
  static int[] arr = new int[] {2,66,4,9,1,5,0,22,56,8,343,56,9};
  public static void Main (string[] args) {
    Console.WriteLine("***Input Array***");
    foreach(var item in arr){
      Console.Write(item+" ,"); 
    }    
    BubbleSort();
    Console.WriteLine("\n***Sorted Array***");
    foreach(var item in arr){
      Console.Write(item+" ,"); 
    }
    BinarySerach();
    Console.WriteLine("\nNumber :"+num2search+" is present at index :"+arrindex);    
  }
  public static void BubbleSort(){
    bool isSorted;
    for(int i=0;i<arr.Length;i++){
      isSorted=true;
      for (int j=1;j<arr.Length-i;j++){
        if(arr[j-1]>arr[j]){
          swap((j-1),j);
          isSorted=false;
        }
      }
      if(isSorted){
        return;
      }
    }
  }
  public static void swap(int i,int j){
    int temp;
    temp=arr[i];
    arr[i]=arr[j];
    arr[j]=temp;
  }
  public static void BinarySerach(){
    int Length = arr.Length;
    int left =0;
    int right = Length;
    
    while (left<right){
      int mid = ((right + left)/2);
      if (arr[mid]==num2search){
        arrindex=mid;
        return;
      }
      else{
        if (num2search<arr[mid]){
          right=(mid-1);
        }
        else{
          left=(mid+1);
        }
      }
    }
  }
}