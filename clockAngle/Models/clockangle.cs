using System;

namespace Clock
{
  public class Time
  {
    public int ClockAngle(int hourHand, int minuteHand)
    {
      var minuteDegree = minuteHand * 6;
      var hourDegree = hourHand * 30 + minuteHand/2;
      var angleDiff = minuteDegree - hourDegree;
      return Math.Abs(angleDiff);
    }
  }
}
