using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "First Name";
            //assign the data to the property
            ACustomer.CustomerFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Last Name";
            //assign the data to the property
            ACustomer.CustomerLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerLastName, TestData);
        }
        [TestMethod]

        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Email";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerTeleNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "First Name";
            //assign the data to the property
            ACustomer.CustomerTeleNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerTeleNo, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the reslt ofg the validation
            Boolean Found = false;
            //create sometest data to use wiht the method
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            //test to see if the relst is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the calss we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //booealn variable to streot he reiult of the search 
            Boolean Found = true;
            //boolean variabnle to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invke teh method
            Found = ACustomer.Find(CustomerID);
            //chech the customer id
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //chech the customer id
            if (ACustomer.CustomerFirstName != "Amar")
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //chech the customer id
            if (ACustomer.CustomerLastName != "Sahota")
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //chech the customer id
            if (ACustomer.CustomerEmail != "amar.sahota@gmail.com")
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerTeleNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //chech the customer id
            if (ACustomer.CustomerTeleNo != "07334123123")
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
