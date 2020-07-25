using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(int vendorId, string orderTitle, string orderDate, string OrderDescription, double orderPrice)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Vendor foundVendor = Vendor.Find(vendorId);
    //   Order newOrder = new Order(orderTitle, orderDate, orderDescription, orderPrice);
    //   foundVendor.AddOrder(newOrder);
    //   List<Order> vendorOrders = foundVendor.Orders;
    //   model.Add("orders", vendorOrders);
    //   model.Add("vendor", foundVendor);
    //   return View("Show", model);
    // }
  }
}