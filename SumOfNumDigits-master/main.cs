using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (SumOfNumDigits(10));
  }
  public static int SumOfNumDigits(int number){
    int sum=0;
    while(number != 0){
      sum += number%10;
      number /= 10;
    }
    return sum;
  }
}