namespace PierresBakery.Models
{
  public class BananaBread
  {
    public int Quantity { get; set; }
    public BananaBread(int quantity)
    {
      Quantity = quantity;
    }
    public int GetPrice()
    {
      if ((Quantity % 2) == 0)
      {
        return (Quantity / 2) * 10;
      }
      else return ((Quantity % 2) * 10) + (((Quantity - (Quantity % 2)) / 2) * 10);
    }
  }
}