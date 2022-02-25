using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread(1);
      int result = newBread.GetPrice();
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceBasedOnQuantity_Int()
    {
      int quantity = 2;
      Bread newBread = new Bread(quantity);
      int result = newBread.GetPrice();
      Assert.AreEqual(10, result);
    }
    
    [TestMethod]
    public void GetPrice_ReturnsSalePriceBasedOnQuantity_Int()
    {
      int quantity = 3;
      Bread newBread = new Bread(quantity);
      int result = newBread.GetPrice();
      Assert.AreEqual(10, result);
    }
  }
}
