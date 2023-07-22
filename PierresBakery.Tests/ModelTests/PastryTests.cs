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

    [TestMethod]
    public void PastryOrder_GetQuantityofPastriesOrdered_NumberOrdered()
    {
      int pastryOrder = 1;
      Pastry newPastryOrder = new Pastry(quantity: pastryOrder, price: 2);
      int actualOrder = newPastryOrder.Quantity;
      Assert.AreEqual(pastryOrder, actualOrder);
    }

    [TestMethod]
    public void GetTotalCost_ReturnsCorrectTotalCost()
    {
      int quantity = 3;
      int pricePerPastry = 2;
      Pastry newPastryOrder = new Pastry(quantity, pricePerPastry);
      int totalCost = newPastryOrder.GetTotalCost();
      Assert.AreEqual(6, totalCost);
    }
  }
}