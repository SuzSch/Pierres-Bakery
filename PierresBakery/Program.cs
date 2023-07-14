using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Bread testBread = new Bread();
      Console.WriteLine(testBread.GetType());
    }
  }
}