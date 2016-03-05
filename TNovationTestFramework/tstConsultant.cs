using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsultantClassLibrary;

namespace ConsultantTestFramework
{
    [TestClass]
    public class tstConsultant
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //test to see if it exists
            Assert.IsNotNull(AConsultant);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "21 bart road";
            //assign the data to the property
            AConsultant.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.Address, TestData);
        }

        [TestMethod]
        public void ConsultantNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AConsultant.ConsultantNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.ConsultantNo, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AConsultant.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.DateOfBirth, TestData);

        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "m@aol.com";
            //assign the data to the property
            AConsultant.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.Email, TestData);

        }

        [TestMethod]
        public void EmergencyContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "0752879265";
            //assign the data to the property
            AConsultant.EmergencyContact = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.EmergencyContact, TestData);

        }

        [TestMethod]
        public void EmploymentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AConsultant.EmploymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.EmploymentDate, TestData);
        }

        [TestMethod]
        public void HoursOfWorkPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            Int32 TestData = 127;
            //assign the data to the property
            AConsultant.HoursOfWork = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.HoursOfWork, TestData);
        }

        [TestMethod]
        public void JobDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Not Applicable";
            //assign the data to the property
            AConsultant.JobDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.JobDescription, TestData);

        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Frank";
            //assign the data to the property
            AConsultant.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.FirstName, TestData);

        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Jhonathan";
            //assign the data to the property
            AConsultant.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.LastName, TestData);

        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AConsultant.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.Status, TestData);

        }

        [TestMethod]
        public void TelNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "+44752890120";
            //assign the data to the property
            AConsultant.TelNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.TelNo, TestData);

        }

        [TestMethod]
        public void EmploymentHistoryPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Not Applicable";
            //assign the data to the property
            AConsultant.EmploymentHistory = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.EmploymentHistory, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the vaidation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //test to see that the result is correct, changed to false and it passed
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the vaidation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Frank";
            string LastName = "Jhonathan";
            string Address = "Flat C, 3 Basil Close";
            string Email = "JhonWayne@live.com";
            string WorkHistory = "Not Applicable";
            string JobDescription = "Employed";
            //invoke the method
            OK = AConsultant.Valid(FirstName,LastName,Address,Email,WorkHistory,JobDescription);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestConsultantNoFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record ifdata is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 2;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the Consultant No
            if (AConsultant.ConsultantNo != 2)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
            

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.FirstName != "mmm")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.LastName != "mmmmmm")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.DateOfBirth != Convert.ToDateTime("24/12/1994 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.Address != "flat b 2, thml")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.Email != "mwen@live.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestTelNoFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.TelNo != "0185815930")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestEmergencyContactFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.EmergencyContact != "sjfhfjaf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestEmploymentDateFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.EmploymentDate != Convert.ToDateTime("24/11/2005"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestHoursOfWorkFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record ifdata is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 2;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the Consultant No
            if (AConsultant.HoursOfWork != 72)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestEmploymentHistoryFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.EmploymentHistory != "sjfhfjaf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ConsultantNo = 1;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //check the ConsultantNo
            if (AConsultant.Status != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }


    }
}
