using System;
​
public class Kata
{
  public static int GetAge(string inputString) =>
     (int)char.GetNumericValue(inputString[0]);
}