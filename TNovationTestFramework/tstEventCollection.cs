using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstEventCollection
    {
        [TestMethod]
        public void InstanceOKCollection()
        {
            //create an instance of the class we want to create
            clsEventCollection AllEvents = new clsEventCollection();
            //test to see that it exists
            Assert.IsNotNull(AllEvents);
        }

        [TestMethod]
        public void CountProperty()
        {
            //create an instance of the class we want to create
            clsEventCollection AllEvents = new clsEventCollection();
            //create some test dat to ssign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllEvents.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.Count, SomeCount);

        }
    }
}
