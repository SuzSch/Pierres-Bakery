using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have a special on loaves of bread today. Buy 2, get 1 free. A single loaf costs $5");
      Console.WriteLine("How many loaves of bread would you like to order today?");
      Console.WriteLine("Please enter a number:");
      string BreadOrder = Console.ReadLine();
      int breadQty = int.Parse(BreadOrder);

      Console.WriteLine("Enter another number:");


      //Triangle tri = new Triangle(length1, length2, length3);
    }
  }
}