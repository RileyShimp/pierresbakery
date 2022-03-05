namespace PierresBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int GetPrice()
    {
      if ((Quantity % 3) == 0)
      {
        return (Quantity / 3) * 10;
      }
      else return ((Quantity % 3) * 5) + (((Quantity - (Quantity % 3)) / 3) * 10);
    }
  }
}