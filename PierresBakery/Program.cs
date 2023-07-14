using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Bread testBread = new Bread(quantity: 1);
      Console.WriteLine(testBread.GetType());
    }
  }
}