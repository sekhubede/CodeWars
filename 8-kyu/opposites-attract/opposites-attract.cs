using System;
​
public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
      return (flower1 % 2) != (flower2 % 2);
    }
}