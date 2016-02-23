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
            Int32 TestData = 1;
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
            string TestData = "CTech";
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
            string TestData = "Elizabeth Saw";
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
            string TestData = " Excel London";
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
            string TestData = "Conference";
            //assign the data to the property
            AEvent.TypeOfEvent = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEvent.TypeOfEvent, TestData);

        }
       

         [TestMethod]
         public void FindMethodOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //test rto see that the result is correct
             Assert.IsTrue(Found);

         }

         [TestMethod]
         public void TestEventCodeFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.EventCode != 1) 
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsTrue(OK);

         }

         [TestMethod]
         public void TestEventNameFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.EventName != "Women in Technology")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void TestConsultantAttendingFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.ConsultantAttending != "Egle Sciglinskaite")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }
         [TestMethod]
         public void TestEndDateFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.EndDate != Convert.ToDateTime("22/03/2016 19:00:00"))
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void TestStartDateFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.StartDate != Convert.ToDateTime("22/03/2016 13:00:00"))
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void TestGuestSpeakerFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.GuestSpeaker != "Elizabeth Saw")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void TestLocationFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.Location != " Excel London")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void TestTypeOfEventFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.TypeOfEvent != "Conference")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }
         [TestMethod]
         public void TestCompanyNameFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.CompanyName != "CTech")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void TestContactFound()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean varibale to store the result of the validation
             Boolean Found = false;
             //boolean variable to store the result of the search
             Boolean OK = true;
             //create some test data to use with the method
             Int32 EventCode = 1;
             //invoke the method
             Found = AEvent.Find(EventCode);
             //check the event code
             if (AEvent.Contact != "075432345")
             {
                 OK = false;
             }
             //test to see that the result is correct
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void ValidMethodOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //invoke method
             OK = AEvent.Valid(EventName,CompanyName,Contact,EndDate,StartDate,GuestSpeaker,Location,TypeOfEvent);
             //test to see that the result is correct
             Assert.IsTrue(OK);

         }


         [TestMethod]
         public void StartDateExtremeMinOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();           
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //create a variable to store the test date data
             DateTime TestDate;
             //set to todays date
             TestDate = DateTime.Now.Date;
             //date changed to -100, this test should fail
             TestDate = TestDate.AddYears(-100);
             //convert date variable to string variable
             string StartDate = TestDate.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);   
             //check if it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void StartDateMinLessOneOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";            
             string TypeOfEvent = "Conference";           
             string Location = "Excel London";
             //variable to store date
             DateTime TestDate;
             //set to todays date
             TestDate = DateTime.Now.Date;
             //date changed to -100, this test should fail
             TestDate = TestDate.AddDays(-1);
             //convert date variable to string variable
             string StartDate = TestDate.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void StartDateMinOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //variable to store date
             DateTime TestDate;
             //set to todays date
             TestDate = DateTime.Now.Date;
             //convert date variable to string variable
             string StartDate = TestDate.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void StartDateMinPlusOneOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //variable to store date
             DateTime TestDate;
             //set to todays date
             TestDate = DateTime.Now.Date;
             //date changed to -100, this test should fail
             TestDate = TestDate.AddDays(1);
             //convert date variable to string variable
             string StartDate = TestDate.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void StartDateExtremeMaxOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //variable to store date
             DateTime TestDate;
             //set to todays date
             TestDate = DateTime.Now.Date;
             //date changed to -100, this test should fail
             TestDate = TestDate.AddYears(100);
             //convert date variable to string variable
             string StartDate = TestDate.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }

         [TestMethod]
         public void StartDateInvalidDataOK()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "Excel London";
             string TypeOfEvent = "Conference";
             //variable to store date
             string StartDate = "January twentieth";
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationMinlessoneOk()
         {

             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string Location = "";///testing this
             string TypeOfEvent = "Conference";
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }

         [TestMethod]
         public void LocationMinOk()
         {

             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
         
             string TypeOfEvent = "Conference";
             string Location = "ab"; //testing this
             //variable to store date
           
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationMaxLessOneOk()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string TypeOfEvent = "Conference";
             string Location = "";
             //creates  29 characters instead of writing many out
             Location = Location.PadRight(29, 'b');
             //variable to store date
            
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationMaxOk()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";
             string TypeOfEvent = "Conference";
             //variable to store location
             string Location = "";
             //creates  29 characters instead of writing many out
             Location = Location.PadRight(30, 'b');
             //variable to store date
             string startDate = DateTime.Now.Date.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);  
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationMaxPlusOneOk()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";  
             string TypeOfEvent = "Conference";
             //variable to store location
             string Location = "";
             //creates  29 characters instead of writing many out
             Location = Location.PadRight(31, 'b');
             //variable to store date
             string startDate = DateTime.Now.Date.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationMidOk()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw"; 
             string TypeOfEvent = "Conference";
             //variable to store location
             string Location = "";
             //creates  29 characters instead of writing many out
             Location = Location.PadRight(15, 'b');
             //variable to store date
             string startDate = DateTime.Now.Date.ToString();
             //invoke method
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent);
             //check iff it is correct
             Assert.IsTrue(OK);

         }
         [TestMethod]
         public void LocationExtremeMaxOk()
         {
             //create an instance of the class we want to create
             clsEvent AEvent = new clsEvent();
             //boolean variable to store the result of the validation
             Boolean OK = false;
             //create some test data to pass to the method
             string EventName = "Women in Technolog";
             string CompanyName = "CTech";
             string Contact = "075432345";
             string EndDate = DateTime.Now.Date.ToString();
             string StartDate = DateTime.Now.Date.ToString();
             string GuestSpeaker = "Elizabeth Saw";   
             string TypeOfEvent = "Conference";
             //variable to store location
             string  Location = "";
             //creates  29 characters instead of writing many 
             Location = Location.PadRight(500, 'b');
             //variable to store date
             OK = AEvent.Valid(EventName, CompanyName, Contact, EndDate, StartDate, GuestSpeaker, Location, TypeOfEvent); 
             //check if it is correct
             Assert.IsTrue(OK);

         }

    }
  }


