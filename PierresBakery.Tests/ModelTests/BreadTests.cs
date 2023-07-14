using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
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
      int BreadOrder = 1;
      Bread newBreadOrder = new Bread(quantity: BreadOrder, price: 5);
      int ActualOrder = newBreadOrder.GetQuantity();
      Assert.AreEqual(BreadOrder, ActualOrder);
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