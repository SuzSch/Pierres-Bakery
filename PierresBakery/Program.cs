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
      string input = Console.ReadLine();
      int quantity = int.Parse(input);
      int pricePerLoaf = 5;
      Bread breadOrder = new Bread(quantity, pricePerLoaf);
      int totalCost = breadOrder.GetTotalCost();
      Console.WriteLine($"You have ordered {breadOrder.Quantity} loaves");
      Console.WriteLine($"Your total for the loaves will be ${totalCost}");
    }
  }
}






