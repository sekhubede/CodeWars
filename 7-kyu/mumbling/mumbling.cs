using System.Linq;
​
public class Accumul 
{
  public static string Accum(string s) 
  {
     return string.Join("-", s.Select((c, i) => char.ToUpper(c) + new string(char.ToLower(c), i)));
  }
}