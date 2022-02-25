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
      return Quantity * 10;
    }
  }
}