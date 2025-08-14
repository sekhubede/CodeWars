using System;
using System.Globalization;
​
public class Kata
{
  public static string Problem(String a) =>
    double.TryParse(a, out double num) 
      ? (num * 50 + 6).ToString(CultureInfo.InvariantCulture) 
      : "Error";
}