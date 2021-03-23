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
            clsOrder AOrder = new clsOrder();
            Assert.IsNotNull(AOrder);
        }
    }
}
