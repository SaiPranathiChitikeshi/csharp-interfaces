using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class InterfaceExampleTest
    {
        [TestMethod]
        public void InterfaceTest()
        {
            InterfaceExample inter = new InterfaceExample();
            Assert.AreEqual(inter.getDepartmnent(), "IT");
            Assert.AreEqual(inter.getSalary(), 1234.90);
        }
    }
}
