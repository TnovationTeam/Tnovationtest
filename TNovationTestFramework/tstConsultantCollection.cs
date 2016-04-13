using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstConsultantCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //test to see that it exists
            Assert.IsNotNull(AllConsultants);
        }
    }
}
