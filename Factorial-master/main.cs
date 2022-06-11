using System;

class MainClass {
  public static void Main (string[] args) {
    decimal varfact;
    varfact = Factorial(26);
    Console.WriteLine("Factorial of a number is :" + varfact.ToString());
  }
  public static decimal Factorial(int input){
    if (input>1)
    return (input *Factorial(input-1));
    else
    return 1;
  }
}