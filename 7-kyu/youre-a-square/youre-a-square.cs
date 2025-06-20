using System;
​
public class Kata
{
  public static bool IsSquare(int n)
  {
    if (n < 0) return false;
    int root = (int)Math.Sqrt(n);
    return root * root == n;
  }
}