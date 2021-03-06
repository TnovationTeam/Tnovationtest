﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
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
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AConsultant.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.DateAdded, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the vaidation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ConsultantNo = 2;
            //invoke the method
            Found = AConsultant.Find(ConsultantNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the vaidation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "James";
            string Address = "Flat C, Colly road";
            string Email = "JhonWayne@live.com";
            string EmploymentHistory = "Employed";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
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
            Assert.IsTrue(OK);


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
            if (AConsultant.FirstName != "James")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.LastName != "James")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.DateOfBirth != Convert.ToDateTime("24/11/1990 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void TestDateAddedFound()
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
            if (AConsultant.DateAdded != Convert.ToDateTime("21/04/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.Address != "Flat C, Colly road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.Email != "Colly@aol.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.TelephoneNo != "07548389201")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.EmergencyContact != "07492859201")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.EmploymentDate != Convert.ToDateTime("12/12/2014"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.HoursOfWork != 128)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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
            if (AConsultant.EmploymentHistory != "None")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


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

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = ""; //This should fail
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "B"; //This should pass
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "AB"; //This should pass
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Abcdhfmhklfigmahsmghcksmsdmjnbhmklowpoutfghmglava"; //This should pass
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnamjnhgbnjss"; //This should pass
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "abcdmjmjmghhasmjkloithkgk"; //This should pass
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnamjnhgbnjsss"; //This should fail
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnn abcdmjmjmghhkgkngnn abcdmjmjmghhkgkngnn abcdmjmjmghhkgkngnnmshfnvczsa’"; //This should fail
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);



        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = ""; //this should fail
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "B";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "AB";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "Abcdhfmhklfigmahsmghcksmsdmjnbhmklowpoutfghmglava";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnamjnhgbnjss";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "abcdmjmjmghhasmjkloithkgk";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnamjnhgbnjsss"; //This should fail
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James’";
            string LastName = "abcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnabcdmjmjmghhkgkngnnmshfnvczsa"; //This should fail
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);



        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string EmploymentHistory = "None";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string EmploymentHistory = "None";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 15 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James"; //This should pass
            string LastName = "abcdmjmjmghhasmjkloithkgk";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string EmploymentHistory = "None";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string EmploymentHistory = "None";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrow (+1)
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "flat b 2, thml";
            string Email = "mwen@live.com";
            string EmploymentHistory = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLES";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, DateAdded, EmploymentHistory);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "Flat2CBASTREETLEICER";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "Flat2CBASTREETLEICERR";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "Flat2CBASTREETLEICERR";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "Flat2CBASTREETLEICERRFlat2CBASTREETLEICERRFlat2CBASTREETLEIC";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "Flat2CBASTREETLEICERRFlat2CBASTREETLEICERRFlat2CBASTREETLEICE";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "CERRFlat2CBASTREETLEICERRFlat2";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "m@y";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "m@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "m@xyz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mshjsmshjsmshjsmshjsmshjsmshjsmshjsmshjsmshjsm@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mshjsmshjsmshjsmshjsmshjsmshjsmshjsmshjsmshjsjm@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mshjsmshjsmshjsmshjsmshjsmshjsmshjsmshjjsmshjsjm@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mshjsmshjsmshhjsjm@yz.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMinLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "m@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "ABC"; //this should fail
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMin()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mwen@live.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "None";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mmwen@xyz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "Fired";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mmwen@yz.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "asfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjandfdafdsaffsddfafff";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMax()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mmwen@yz";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "asfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjandfdafdsaffsddfafffz";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mwenn@xyz.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "asfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjandfdafdsaffsddfafffz";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmploymentHistoryMid()
        {
            //create an instance of the class we want to create
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "James";
            string LastName = "mmmmmm";
            string Address = "FlatB2CTHYMEROADLESS";
            string Email = "mmwen@yz.com";
            string DateAdded = DateTime.Now.Date.ToString();
            string EmploymentHistory = "asfjnjkgjangljkasfjnjkkgjangljkasfjnjkgjangljkasfjnjkgjangljkasfjnjkgjangsa";
            //invoke the method
            OK = AConsultant.Valid(FirstName, LastName, Address, Email, EmploymentHistory, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
