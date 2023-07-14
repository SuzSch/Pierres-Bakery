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
      Bread newBreadOrder = new Bread(quantity: 1);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_GetQuantityofBreadOrdered_NumberOrdered()
    {
      int BreadOrder = 1;
      Bread newBreadOrder = new Bread(BreadOrder);
      int ActualOrder = newBreadOrder.GetQuantity();
      Assert.AreEqual(BreadOrder, ActualOrder);
    }
  }

}