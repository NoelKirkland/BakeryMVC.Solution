namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}