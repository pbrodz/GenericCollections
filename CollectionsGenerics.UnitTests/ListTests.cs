using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;
using System.Collections.Generic;

namespace CollectionsGenerics.UnitTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void lists()
        {
            //Lets create a list of objects here
            var orders = new List<order>();
            orders.Add(new order() { id = 1, customer = "Lightning", value = 100.00 });
        }
        [TestMethod]
        public void genList()
        {
            //We've created a Generic Order that can take in a variable type for the customer
            //So, we'll pass in a string first
            var stringOrders = new List<genOrder<string>>();
            stringOrders.Add(new genOrder<string>() { id = 1, customer = "Microsoft", value = 100.00 });

            //same method, now we'll pass in an integer!
            var intOrders = new List<genOrder<int>>();
            intOrders.Add(new genOrder<int>() { id=1, customer=5, value=100.0});
        }
    }
}
