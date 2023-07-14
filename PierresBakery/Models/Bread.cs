namespace PierresBakery.Models;

public class Bread
{
  public int quantity;
  public int price;
  public Bread(int quantity, int price)
  {
    this.quantity = quantity;
    this.price = price;

  }
  public int GetQuantity()
  {
    return quantity;
  }

  public int GetTotalCost()
  {
    int pricePerLoaf = 5;
    int fullPriceLoaves = quantity / 3 * 2;
    int remainingLoaves = quantity % 3;
    int totalCost = (fullPriceLoaves + remainingLoaves) * pricePerLoaf;
    return totalCost;
  }
}


