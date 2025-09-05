using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
    public static bool IsAnagram(string a, string b) =>
        (a.Length == b.Length) && 
        string.Concat(a.ToLower().OrderBy(c => c)) ==
        string.Concat(b.ToLower().OrderBy(c => c));
}