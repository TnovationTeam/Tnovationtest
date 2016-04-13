using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;
using System.Collections.Generic;

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
            Int32 SomeCount = 2;
            //assign the data to the property
            AllEvents.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.Count, SomeCount);

        }


        [TestMethod]
      public void AllEventsOK()
        {
            //create an instance of the class we want to create
            clsEventCollection Events = new clsEventCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsEvent> TestList = new List<clsEvent>();
            //add an item to the list
            //create item to test the data
            clsEvent TestItem = new clsEvent();
            //set its properties
            TestItem.EventCode = 1;
            TestItem.EventName = "Excel London";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Events.AllEvents = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Events.AllEvents, TestList);



        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsEventCollection Events = new clsEventCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsEvent> TestList = new List<clsEvent>();
            //add an item to the list
            //create item to test the data
            clsEvent TestItem = new clsEvent();
            //set its properties
            TestItem.EventCode = 1;
            TestItem.EventName = "Excel London";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Events.AllEvents = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Events.Count, TestList.Count);



        }

        ////[TestMethod]
        //public void TwoEventsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsEventCollection Events = new clsEventCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Events.Count, 2);
        //}
    }
}
