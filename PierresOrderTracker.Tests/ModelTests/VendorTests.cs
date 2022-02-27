using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Tests
  {
    [TestClass]
    public class VendorTests 
    {
      public void AddVendor()
      {
        Vendor newVendor = new Vendor("little p's", "Paris", "littlep@littlep.com", "111.111.1111", "Great bakery in Paris!");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }
    }
  }