namespace PierresBakery.Models;

public class Bread
{
  public int quantity;
  public Bread(int quantity)
  {
    this.quantity = 1;
  }
  public int GetQuantity()
  {
    return quantity;
  }
}


