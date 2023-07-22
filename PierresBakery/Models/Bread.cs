namespace PierresBakery.Models;

public class Bread
{
  public int Quantity { get; set; }
  public int Price { get; set; }

  public Bread(int quantity, int price)
  {
    Quantity = quantity;
    Price = price;
  }

  public int GetTotalCost()
  {
    int pricePerLoaf = 5;
    int fullPriceLoaves = Quantity / 3 * 2;
    int remainingLoaves = Quantity % 3;
    int breadTotalCost = (fullPriceLoaves + remainingLoaves) * pricePerLoaf;
    return breadTotalCost;
  }
}




