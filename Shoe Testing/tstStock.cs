using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceoK()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            DateTime TestData = new DateTime();
            //assign the data to the property
            AStock.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Date, TestData);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            int TestData = 3;
            //assign the data to the property
            AStock.ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ID, TestData);
        }

        [TestMethod]
        public void brandPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            int TestData = 2;
            //assign the data to the property
            AStock.brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.brand, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            string TestData = "Nike";
            //assign the data to the property
            AStock.name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.name, TestData);
        }

        [TestMethod]
        public void sizePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            int TestData = 1;
            //assign the data to the property
            AStock.size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.size, TestData);
        }

        [TestMethod]
        public void quantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            int TestData = 1;
            //assign the data to the property
            AStock.quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.quantity, TestData);
        }

        [TestMethod]
        public void costPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign the property
            int TestData = 1;
            //assign the data to the property
            AStock.cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.cost, TestData);
        }

        [TestMethod]
        public void findMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //BoOlean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int ID = 1;
            //invoke the method
            Found = AStock.Find(ID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int ID = 1;
            //invoke the method
            Found = AStock.Find(ID);
            //check the id
            if (AStock.ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void sizeNoFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 size = 5;
            //invoke the method
            Found = AStock.Find(size);
            //chech the customer id
            if (AStock.size != 5)
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void nameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string name = "baabaaacaaaaadaabaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(name);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void namePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Supreme";
            //assign the data to the property
            AStock.name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.name, TestData);
        }

        [TestMethod]
        public void TestsizeTeleNoFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 size = 13;
            //invoke the method
            Found = AStock.Find(size);
            //chech the customer id
            if (AStock.size != 14)
            {
                OK = false;
            }
            //test ito see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
