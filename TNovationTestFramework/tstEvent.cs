using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstEvent
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //test to see that it exists
            Assert.IsNotNull(AEvent);
        }

        [TestMethod]
        public void EventCodePropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            Int32 TestData = 23;
            //assign the data to the property
            AEvent.EventCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.EventCode, TestData);

        }

        [TestMethod]
        public void EventNamePropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "Women in Technology";
            //assign the data to the property
            AEvent.EventName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.EventName, TestData);

        }
         [TestMethod]
        public void CompanyNamePropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "CNTech";
            //assign the data to the property
            AEvent.CompanyName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.CompanyName, TestData);

        }
         [TestMethod]
        public void ConsultantAttendingPropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "Egle Sciglinskaite";
            //assign the data to the property
            AEvent.ConsultantAttending = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.ConsultantAttending, TestData);

        }
         [TestMethod]
        public void ContactPropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "0795432345";
            //assign the data to the property
            AEvent.Contact = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.Contact, TestData);

        }
         [TestMethod]
        public void EndDatePropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AEvent.EndDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.EndDate, TestData);

        }
         [TestMethod]
        public void StartDatePropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AEvent.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.StartDate, TestData);

        }
         [TestMethod]
        public void GuestSpeakersPropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "Mark Zuckerberg";
            //assign the data to the property
            AEvent.GuestSpeaker = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.GuestSpeaker, TestData);

        }
         [TestMethod]
        public void LocationPropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = " eXcel London";
            //assign the data to the property
            AEvent.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.Location, TestData);

        }
         [TestMethod]
        public void TypeOfEventPropertyOK()
        {
            //create an isntance of the class we want to create
            clsEvent AEvent = new clsEvent();
            //create some test data to assign to the property
            string TestData = "Seminar";
            //assign the data to the property
            AEvent.TypeOfEvent = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.TypeOfEvent, TestData);

        }
         [TestMethod]
        public void ValidMethodOK()
         {
             //create an isntance of the class we want to create
             clsEvent AEvent = new clsEvent();
             // boolean variabale to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string ConsultantAttending = "Egle Sciglinskaite";
             string Contact = "075432345";
             string EventName = "Technology Today";
             string GuestSpeakers = "Matthew Dean";
             string Location = "DMU Leicester";
             string TypeOfEvent = "Seminar";
             //invoke the method
             OK = AEvent.Valid(ConsultantAttending, Contact, EventName, GuestSpeakers, Location, TypeOfEvent);
             //test to see that the result is correct
             Assert.IsTrue(OK);


         }
     }
  }


    }
}
