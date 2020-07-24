using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
  [TestClass]
  {
    [TestMethod]
    {
      public void OrderConstructor_CreatesInstanceOfOrder_Order()
      {
        Order newOrder = new Order("scones", "7/24/2020", "we ordered 50 scones but we might need more soon", 110.00);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()