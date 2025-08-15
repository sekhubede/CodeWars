using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
      var remove = new HashSet<int>(b);
      return a.Where(x => !remove.Contains(x)).ToArray();
  }
}