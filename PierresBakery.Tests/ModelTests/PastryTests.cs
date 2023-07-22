using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatePastryOrder_Pastry()
    {
      Pastry newPastryOrder = new Pastry(quantity: 1, price: 2);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
  }
}