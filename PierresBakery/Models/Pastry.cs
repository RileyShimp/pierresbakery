namespace PierresBakery
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int GetPrice()
    {
      return Quantity * 2;
    }
  }
}