using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
       return data.Select(d => (d[0] >= 55 && d[1] > 7) ? "Senior" : "Open");
    }
}