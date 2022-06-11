using System;

class MainClass {
  public static void Main (string[] args) {
    string s1="";
    string s2="";
    Console.WriteLine (AreAlmostEqual(s1,s2));
  }
  public static bool AreAlmostEqual(string s1,string s2){
    int count = 0;
		int index1 = -1;
		int index2 = -1;

		if (s1.Length != s2.Length)
			return false;
		else if (s1 == s2)
			return true;
		else
		{
			for (int i = 0; i < s1.Length; i++)
			{
				if (s1[i] == s2[i])
					continue;
				else
				{
					count++;
					if (count == 1)
						index1 = i;
					if (count == 2)
						index2 = i;
					if (count > 2)
						return false;
				}
			}
		}
		return (count == 2 && s1[index1] == s2[index2] && s1[index2] == s2[index1]);
  }
}