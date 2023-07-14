using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models.Bread;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      Assert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}