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

        //[TestMethod]
        //public void CountProperty()
        //{
        //    //create an instance of the class we want to create
        //    clsEventCollection AllEvents = new clsEventCollection();
        //    //create some test dat to ssign to the property
        //    Int32 SomeCount = 0;
        //    //assign the data to the property
        //    AllEvents.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllEvents.Count, SomeCount);

        //}


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
        public void ListAndCountOK()

        {
            //create an instance of the class we want to create
            clsEventCollection AllEvents = new clsEventCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
           List<clsEvent> TestList = new List<clsEvent>();
            //add an item to the list
            //create item to test the data
            clsEvent TestItem = new clsEvent();
            //set its properties
            TestItem.EventCode = 1;
            TestItem.EventName = "Innovation";
            TestItem.CompanyName = "CTech";
            TestItem.ConsultantAttending = "Freddy";
            TestItem.Contact = "0758675643";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Tiffany Laster";
            TestItem.Location = "IT support for company";
            TestItem.TypeOfEvent = "Networking";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
           AllEvents.EventList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.Count, TestList.Count);



        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsEventCollection AllEvents = new clsEventCollection();
            //create the item of the test data
            clsEvent TestItem = new clsEvent();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            
            TestItem.EventName = "Innovation";
            TestItem.CompanyName = "CTech";
            TestItem.ConsultantAttending = "Freddy";
            TestItem.Contact = "0758675643";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Tiffany Laster";
            TestItem.Location = "IT support for company";
            TestItem.TypeOfEvent ="Networking";
           
            //set ThisEvent to the test data
            AllEvents.ThisEvent = TestItem;
            //add the record
            PrimaryKey = AllEvents.Add();
            //set the primary key of the test data
            TestItem.EventCode = PrimaryKey;
            //find the record
            AllEvents.ThisEvent.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.ThisEvent, TestItem);

        }

        [TestMethod]
        public void EventListOK()
        {
            //create an instance of the class we want to create
            clsEventCollection AllEvents = new clsEventCollection();
            //create some test data to assign to the property
            //in this ase the data needs to be a list of objects
            List<clsEvent> TestList = new List<clsEvent>();
            //add an item of test data
            clsEvent TestItem = new clsEvent();
            //set its properties
            TestItem.EventCode = 1;
            TestItem.EventName = "Innovation";
            TestItem.CompanyName = "CTech";
            TestItem.ConsultantAttending = "Freddy";
            TestItem.Contact = "0758675643";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Tiffany Laster";
            TestItem.Location = "IT support for company";
            TestItem.TypeOfEvent = "Networking";
           //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllEvents.EventList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.EventList, TestList);


        }


        [TestMethod]
        public void ThisEventPropertyOK()
        {
            //create an instance of the class we want to create
            clsEventCollection AllEvents = new clsEventCollection();          
            clsEvent TestEvent = new clsEvent();
            //set its properties
            TestEvent.EventCode = 1;
            TestEvent.EventName = "Innovation";
            TestEvent.CompanyName = "CTech";
            TestEvent.ConsultantAttending = "Freddy";
            TestEvent.Contact = "0758675643";
            TestEvent.StartDate = DateTime.Now.Date; ;
            TestEvent.GuestSpeaker = "Tiffany Laster";
            TestEvent.Location = "IT support for company";
            TestEvent.TypeOfEvent = "Networking";
          
            //assign the data to the property
            AllEvents.ThisEvent = TestEvent;
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.ThisEvent, TestEvent);


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
