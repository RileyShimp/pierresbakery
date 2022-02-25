namespace PierresBakery.Models
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
      if ((Quantity % 3) == 0)
      {
        return (Quantity / 3) * 5;
      }
      else return ((Quantity % 3) * 2) + (((Quantity - (Quantity % 3)) / 3) * 5);
    }
  }
}