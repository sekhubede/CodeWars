using System.Linq;
using System.Collections.Generic;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) =>
      lines.Select((x, i) => $"{i + 1}: {x}").ToList();
}