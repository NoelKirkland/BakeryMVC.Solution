using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title {get; set; }
    public string Date {get; set; }
    public string Description {get; set; }
    public double Price {get; set; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string title, string date, string description, double price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}