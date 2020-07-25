using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest: IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("scones", "7/24/2020", "ordered 50 scones and might need more soon", 110.00);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnObjectValues_StringAndDouble()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "ordered 50 scones and might need more soon";
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
    public void GetAll_ReturnOrderList_List()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "ordered 50 scones and might need more soon";
      double price = 110.00;
      Order newOrder = new Order(title, date, description, price);
      List<Order> newList = new List<Order> { newOrder };

      List<Order> resultList = Order.GetAll();

      CollectionAssert.AreEqual(newList, resultList);
    }

    [TestMethod]
    public void OrderConstructor_ReturnOrderId_Int()
    {
      string title = "scones";
      string date = "7/24/2020";
      string description = "ordered 50 scones and might need more soon";
      double price = 110.00;
      Order newOrder = new Order(title, date, description, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      string title1 = "scones";
      string date1 = "7/24/2020";
      string description1 = "ordered 50 scones and might need more soon";
      double price1 = 110.00;
      string title2 = "croissants";
      string date2 = "7/20/2020";
      string description2 = "ordered 20 almond croissants and 80 regular croissants";
      double price2 = 190.00;
      Order newOrder1 = new Order(title1, date1, description1, price1);
      Order newOrder2 = new Order(title2, date2, description2, price2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}