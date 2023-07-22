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
      int breadTotalCost = breadOrder.GetTotalCost();
      Console.WriteLine($"You have ordered {breadOrder.Quantity} loaves");
      Console.WriteLine($"Your total for the loaves will be ${breadTotalCost}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("We also have a special on pastries. Buy 3, get 1 free. A single pastry costs $2");
      Console.WriteLine("How many pastries would you like to order today?");
      Console.WriteLine("Please enter a number:");
      string pastryInput = Console.ReadLine();
      int pastryQuantity = int.Parse(pastryInput);
      int pricePerPastry = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity, pricePerPastry);
      int pastryTotalCost = pastryOrder.GetTotalCost();
      Console.WriteLine($"You have ordered {pastryOrder.Quantity} pastries");
      Console.WriteLine($"Your total for the pastries will be ${pastryTotalCost}");
      int grandTotal = breadTotalCost + pastryTotalCost;
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"Your grand total for bread and pastries will be ${grandTotal}");
      Console.WriteLine("Thank you for coming to Pierre's Bakery. Have a great day!");

    }
  }
}







