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
      Vendor newVendor = new Vendor("Grand Central", "best source of scones and danishes in Portland");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnObjectValues_String()
    {
      string name = "Grand Central";
      string description = "best source of scones and danishes in Portland";
      Vendor newVendor = new Vendor(name, description);

      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;

      Assert.AreEqual(name, resultName);
      Assert.AreEqual(description, resultDescription);
    }

    [TestMethod]
    public void GetAll_ReturnVendorList_List()
    {
      string name = "Grand Central";
      string description = "best source of scones and danishes in Portland";
      Vendor newVendor = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> { newVendor };

      List<Vendor> resultList = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, resultList);
    }

    [TestMethod]
    public void VendorConstructor_ReturnVendorId_int()
    {
      string name = "Grand Central";
      string description = "best source of scones and danishes in Portland";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      string name1 = "Grand Central";
      string description1 = "best source of scones and danishes in Portland";
      string name2 = "Suzy's Bakery";
      string description2 = "Good cupcakes. Deliveries always come on time";
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
      string vendorName = "Grand Central";
      string vendoreDescription = "best source of scones and danishes in Portland";
      Vendor newVendor = new Vendor(vendorName, vendoreDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}