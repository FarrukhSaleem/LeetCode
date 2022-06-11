using System;

class MainClass {
  public static void Main (string[] args) {
    int inputNumber=1534236469;
    long outputNumber;
    outputNumber=ReverseString(inputNumber);
    Console.WriteLine(outputNumber.ToString());
  }
  public static long ReverseString(int num){
    bool ispositive=(num>0);    
    long reverse=0;
    num = (ispositive) ? num:-num;    
    while(num>0){      
      reverse=(reverse*10)+(num%10);
      num=num/10;
    }
    if(reverse<=int.MinValue || reverse>=int.MaxValue)
     return 0;
    reverse =(ispositive)?reverse:(-reverse);
    return Convert.ToInt32(reverse);
  }
}