using System;
using System.Linq;
​
public class Kata
{
  public static int[] SortNumbers(int[] nums) =>
    nums == null ? Array.Empty<int>() : nums.OrderBy(n => n).ToArray();
}