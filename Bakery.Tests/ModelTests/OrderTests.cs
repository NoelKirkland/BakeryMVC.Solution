using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("scones", "7/24/2020", "we ordered 50 scones but we might need more soon", 110.00);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnValues_StringAndDouble()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "we ordered 50 scones but we might need more soon";
      double price = 110.00;
      Order newOrder = new Order(title, date, description, price);

      string resultTitle = newOrder.Title;
      string resultDate = newOrder.Date;
      string resultDescription = newOrder.Description;
      double resultPrice = newOrder.Price;

      Assert.AreEqual("not this 1", resultTitle);
      Assert.AreEqual("not this 2", resultDate);
      Assert.AreEqual("not this 3", resultDescription);
      Assert.AreEqual("not this 4", resultPrice);
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()