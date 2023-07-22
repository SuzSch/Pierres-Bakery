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
}