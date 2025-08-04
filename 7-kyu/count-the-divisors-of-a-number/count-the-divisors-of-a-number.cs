using System;
​
public class Kata
{
  public static int Divisors(int n)
  {
    int count = 0;
    int sqrt = (int)Math.Sqrt(n);
    
    for (int i = 1; i <= sqrt; i++)
    {
      if (n % i == 0)
      {
        count += (i == n / i) ? 1 : 2;  
      }
    }
    
    return count;
  }
}