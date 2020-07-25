using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
  [TestClass]
  public class VendorTest: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Powell's", "iconic bookstore with a busy coffee shop");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnObjectValues_String()
    {
      string name = "Powell's";
      string description = "iconic bookstore with a busy coffee shop";
      Vendor newVendor = new Vendor(name, description);

      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;

      Assert.AreEqual(name, resultName);
      Assert.AreEqual(description, resultDescription);
    }

    [TestMethod]
    public void GetAll_ReturnVendorList_List()
    {
      string name = "Powell's";
      string description = "iconic bookstore with a busy coffee shop";
      Vendor newVendor = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> { newVendor };

      List<Vendor> resultList = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, resultList);
    }

    [TestMethod]
    public void VendorConstructor_ReturnVendorId_int()
    {
      string name = "Powell's";
      string description = "iconic bookstore with a busy coffee shop";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      string name1 = "Powell's";
      string description1 = "iconic bookstore with a busy coffee shop";
      string name2 = "Le Pigeon";
      string description2 = "French restaurant";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddListOfOrdersToVendor_List()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "ordered 50 scones but we might need more soon";
      double price = 110.00;
      Order newOrder = new Order(title, date, description, price);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Powell's";
      string vendoreDescription = "iconic bookstore with a busy coffee shop";
      Vendor newVendor = new Vendor(vendorName, vendoreDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}