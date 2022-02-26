using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("---------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Our Bread is $5.00 a loaf.");
      Console.WriteLine("Buy 2, get 1 free!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Our Pastries are $2.00 each.");
      Console.WriteLine("Or 3 for $5.00!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Our special today is Banana Bread!");
      Console.WriteLine("$10.00 per loaf!");
      Console.WriteLine("Buy 1, Get One free!!!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("---------------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadQuantity = Console.ReadLine();
      int breadQuantity = int.Parse(stringBreadQuantity);
      Console.WriteLine("How many pastries would you like?");
      string stringPastryQuantity = Console.ReadLine();
      int pastryQuantity = int.Parse(stringPastryQuantity);
      Console.WriteLine("How many loaves of Banana bread would you like?");
      string stringBananaBreadQuantity = Console.ReadLine();
      int bananaBreadQuantity = int.Parse(stringBananaBreadQuantity);
      Bread breadOrder = new Bread(breadQuantity);
      Pastry pastryOrder = new Pastry(pastryQuantity);
      BananaBread bananaBreadOrder = new BananaBread(bananaBreadQuantity);
      int breadTotal = breadOrder.GetPrice();
      int pastryTotal = pastryOrder.GetPrice();
      int bananaBreadTotal = bananaBreadOrder.GetPrice();
      int orderTotal = breadTotal + pastryTotal + bananaBreadTotal;
      Console.WriteLine("---------------------------");
      Console.WriteLine("YOUR ORDER");
      Console.WriteLine("Bread: " + breadQuantity);
      Console.WriteLine("Pastries: " + pastryQuantity);
      Console.WriteLine("Banana Bread: " + bananaBreadQuantity);
      Console.WriteLine("YOUR TOTAL IS: $" + orderTotal + ".00");
      Console.WriteLine("Thanks for shopping at Pierre's Bakery!");
    }
  }
}