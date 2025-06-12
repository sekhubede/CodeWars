using System;
​
public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
      return string.IsNullOrEmpty(name)
        ? throw new ArgumentNullException("Name cannot be null or empty")
        : name.StartsWith("r", StringComparison.OrdinalIgnoreCase)
        ? $"{name} plays banjo"
        : $"{name} does not play banjo";
  }
}