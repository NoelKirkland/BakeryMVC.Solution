namespace Bakery.Models
{
  public class Order
  {
    public string Title {get; set; }
    public string Date {get; set; }
    public string Description {get; set; }
    public double Price {get; set; }

    public Order(string title, string date, string description, double price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
    }
  }
}