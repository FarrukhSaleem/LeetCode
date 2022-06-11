using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (MergeAlternately("Fruhaleem","arkS"));
  }
  public static string MergeAlternately(string word1, string word2) {
    string res="";
    int i= 0;
    int j= 0; 
    while(i<word1.Length || j<word2.Length){
      if(i<word1.Length){
        res += word1[i++];
      }
      if(j<word2.Length){
        res += word2[j++];
      }
    }
    return res;
    }
}