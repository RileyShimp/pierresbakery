namespace PierresBakery
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int GetPrice(){
      return 5;
    }
  }
}