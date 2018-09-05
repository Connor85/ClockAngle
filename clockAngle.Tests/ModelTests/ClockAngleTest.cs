using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clock;
using System.Collections.Generic;

namespace Clock.Tests
{
  [TestClass]
  public class TimeTest
  {
    [TestMethod]
    public void IsTime_isOneEighty_True()
    {
      Time testTime = new Time();
      Assert.AreEqual(122, testTime.ClockAngle(4,44));
    }
  }
}
