using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
  [TestClass]
  public class VendorTest
  {
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
      List<Vendor> newList = new List<Vendor> { };

      List<Vendor> resultList = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, resultList);
    }
  }
}