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
            TestItem.EventCode = 7;
            TestItem.EventName = "Yayitsfixed-Freddy";
            TestItem.CompanyName = "Thank me,hahaha";
            TestItem.ConsultantAttending = "test";
            TestItem.Contact = "07545636";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Test";
            TestItem.Location = "test";
            TestItem.TypeOfEvent = "test";

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
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsEventCollection AllEvents = new clsEventCollection();
            //create the item of the test data
            clsEvent TestItem = new clsEvent();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EventCode = 10;
            TestItem.EventName = "this better work";
            TestItem.CompanyName = "Thank hahaha";
            TestItem.ConsultantAttending = "test";
            TestItem.Contact = "07545636";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Test";
            TestItem.Location = "test";
            TestItem.TypeOfEvent = "test";
            //set ThisAddress to the test data
            AllEvents.ThisEvent = TestItem;
            TestItem.EventCode = PrimaryKey;
            //find the record
            AllEvents.ThisEvent.Find(PrimaryKey);
            //delete the record
            AllEvents.Delete();
            //now find the record
            Boolean Found = AllEvents.ThisEvent.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsEventCollection AllEvents = new clsEventCollection();
            //create the item of the test data
            clsEvent TestItem = new clsEvent();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EventCode = 11;
            TestItem.EventName = "thissdh work";
            TestItem.CompanyName = "Thandshhaha";
            TestItem.ConsultantAttending = "tdfhest";
            TestItem.Contact = "075645636";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Tshaest";
            TestItem.Location = "tessdft";
            TestItem.TypeOfEvent = "tessdft";
            //set ThisAddress to the test data
            AllEvents.ThisEvent = TestItem;

            //set the primary key of the test data
            TestItem.EventCode = PrimaryKey;
            //modify the test data
            TestItem.EventCode = 12;
            TestItem.EventName = "thdhsr work";
            TestItem.CompanyName = "Thadsfhaha";
            TestItem.ConsultantAttending = "tedsfhst";
            TestItem.Contact = "075456436";
            TestItem.StartDate = DateTime.Now.Date; ;
            TestItem.GuestSpeaker = "Tesfswt";
            TestItem.Location = "tefsst";
            TestItem.TypeOfEvent = "tsdfest";
            //set the record based on new test data
            AllEvents.ThisEvent = TestItem;
            //update the record
            AllEvents.Update();
            //find the record
            AllEvents.ThisEvent.Find(PrimaryKey);
            //test to see this address matches the test data
            Assert.AreEqual(AllEvents.ThisEvent, TestItem);
        }
    
    
    }
}
