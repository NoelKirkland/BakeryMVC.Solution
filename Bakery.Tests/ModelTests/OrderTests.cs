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
    public void OrderConstructor_ReturnObjectValues_StringAndDouble()
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

      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(date, resultDate);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(price, resultPrice);
    }

    [TestMethod]
    public void OrderConstructor_ReturnObjectId_Int()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "we ordered 50 scones but we might need more soon";
      double price = 110.00;
      Order newOrder = new Order(title, date, description, price);

      int result = newOrder.Id;

      Assert.AreEqual(123, result);
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()