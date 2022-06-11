using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(minOperations("0100"));
    
  }
  public static int minOperations(string s) {
        int n = s.Length;
        char[] chs = s.ToCharArray();
        char p = chs[0];
        int cnt = 0;
        for (int i = 1; i < n; i++) {
            if (p == chs[i]) {
                cnt++;
            }
            p = p == '0' ? '1' : '0';
        }
        return Math.Min(cnt, n-cnt);
    }
}