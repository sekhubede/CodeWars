using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata {
  public static int[] DeleteNth(int[] arr, int x) {
      var result = new List<int>();
      var counts = new Dictionary<int, int>();
    
      foreach(var num in arr)
      {
        if (!counts.ContainsKey(num))
          counts[num] = 0;
        
        if (counts[num] < x)
        {
          result.Add(num);
          counts[num]++;
        }
      }
    
      return result.ToArray();
  }
}