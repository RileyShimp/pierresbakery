using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BananaBreadTests
  {
    [TestMethod]
    public void BananaBreadConstructor_CreatesInstanceOfBananaBread_BananaBread()
    {
      BananaBread newBananaBread = new BananaBread(1);
      Assert.AreEqual(typeof(BananaBread), newBananaBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 10;
      BananaBread newBananaBread = new BananaBread(1);
      int result = newBananaBread.GetPrice();
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceBasedOnQuantity_Int()
    {
      int quantity = 2;
      BananaBread newBananaBread = new BananaBread(quantity);
      int result = newBananaBread.GetPrice();
      Assert.AreEqual(20, result);
    }
  }
}