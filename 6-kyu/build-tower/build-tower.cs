using System.Collections.Generic;
​
public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
      var tower = new List<string>();
​
      for (int currentFloor = 1; currentFloor <= nFloors; currentFloor++)
      {
          int towerBlockCount = 2 * currentFloor - 1;
          int paddingCount = nFloors - currentFloor;
​
          var floor =
              new string(' ', paddingCount) +
              new string('*', towerBlockCount) +
              new string(' ', paddingCount);
​
          tower.Add(floor);
      }
​
      return tower.ToArray();
  }
}