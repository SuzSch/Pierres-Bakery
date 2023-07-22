using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateBreadOrder_Bread()
    {
      //arrange, act, assert
      Bread newBreadOrder = new Bread(quantity: 1, price: 5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_GetQuantityofBreadOrdered_NumberOrdered()
    {
      int breadOrder = 1;
      Bread newBreadOrder = new Bread(quantity: breadOrder, price: 5);
      int actualOrder = newBreadOrder.Quantity;
      Assert.AreEqual(breadOrder, actualOrder);
    }

    [TestMethod]
    public void GetTotalCost_ReturnsCorrectTotalCost()
    {
      int quantity = 5;
      int pricePerLoaf = 5;
      Bread newBreadOrder = new Bread(quantity, pricePerLoaf);
      int totalCost = newBreadOrder.GetTotalCost();
      Assert.AreEqual(20, totalCost);
    }
  }
}