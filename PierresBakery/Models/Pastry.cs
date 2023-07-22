namespace PierresBakery.Models;

public class Pastry
{
  public int Quantity { get; set; }
  public int Price { get; set; }

  public Pastry(int quantity, int price)
  {
    Quantity = quantity;
    Price = price;
  }
  public int GetTotalCost()
  {
    int pricePerPastry = 2;
    int discountedPrice = pricePerPastry * 3;
    int numberOfDiscountedSets = Quantity / 4;
    int remainingPastries = Quantity % 4;
    int pastryTotalCost = (numberOfDiscountedSets * discountedPrice) + (remainingPastries * pricePerPastry);
    return pastryTotalCost;
  }

}
