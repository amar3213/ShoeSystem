using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void IsInstanceOk()
        {
            //create an instance of the class we want create
            clsOrder AOrder = new clsOrder();

            //Test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderAddressOk()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AOrder.OrderAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderAddress, TestData);
        }

        [TestMethod]
        public void CustomerNameOk()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "John Wick";
            //assign the data to the property
            AOrder.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void OrderItemOk()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Nike";
            //assign the data to the property
            AOrder.OrderItem = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderItem, TestData);
        }

        [TestMethod]
        public void OrderIDOk()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerID()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 12;
            //assign the data to the property
            AOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.CustomerID, TestData);
        }
    }
}
