using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 2;
      Pastry newPastry = new Pastry(1);
      int result = newPastry.GetPrice();
      Assert.AreEqual(price, result);
    }
  }
}