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
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Frank";
            //assign the data to the property
            AConsultant.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.Name, TestData);

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
        public void TelephoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "+44752890120";
            //assign the data to the property
            AConsultant.TelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.TelephoneNo, TestData);

        }

        [TestMethod]
        public void WorkHistoryPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            string TestData = "Not Applicable";
            //assign the data to the property
            AConsultant.WorkHistory = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.WorkHistory, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultantList = new clsConsultant();
            //boolean variable to store the result of the vaidation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ConsultantNo = 12345;
            //invoke the method
            Found = AConsultantList.Find(ConsultantNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }
    }
}
