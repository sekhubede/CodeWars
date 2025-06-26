using System.Linq;
​
public class Kata
{
  public static string DuplicateEncode(string word)
  {
    var lowerWord = word.ToLower();
    return string.Concat(lowerWord.Select(c => lowerWord.Count(x => x == c) > 1 ? ')' : '('));
  }
}