using System;
using System.Linq;
​
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    return string.IsNullOrEmpty(phrase) ? phrase : string.Join(" ", phrase.Split(' ')
                                                              .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
  }
}