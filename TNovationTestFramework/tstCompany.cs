using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstCompany
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //test to see that it exists
            Assert.IsNotNull(ACompany);
        }


        [TestMethod]
        public void CompanyAddressOK()
        {
            //create an instance of the class you want to create
            clsCompany ACompany = new clsCompany();
            //create to some test data to assign to the property
            string SomeCompany = "TNovation";
            //assign the data to the property
            ACompany.CompanyAddress = SomeCompany;
            //test to see the two values are same
            Assert.AreEqual(ACompany.CompanyAddress, SomeCompany);
        }
        [TestMethod]
        public void CompanyCodeOK()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            ACompany.CompanyCode = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACompany.CompanyCode, TestData);
        }
        [TestMethod]
        public void CompanyEmailAddressOK()
        {
            //create an instance of the class we want to create
            clsCompany AnEmail = new clsCompany();
            //create some test data to assign to the property
            string TestData = "vijaymodhwadia@hotmail.co.uk";
            //assign the data to the property
            AnEmail.CompanyEmailAddress = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnEmail.CompanyEmailAddress, TestData);
        }
        [TestMethod]
        public void InvolvedClientOK()
        {
            //create an instance of the class we want to create
            clsCompany AClient = new clsCompany();
            //create some test data to assign to the property
            string ATestData = "Freddy";
            //assign the data to the property
            AClient.InvolvedClient = ATestData;
            //test to see the two values are the same
            Assert.AreEqual(AClient.InvolvedClient, ATestData);
        }
        [TestMethod]
        public void InvolvedProjectOK()
        {
            //create an instance of the class we want to create
            clsCompany AProject = new clsCompany();
            //create some test data to assign to the property
            string TestData = "MyProject";
            //assign the data to the property
            AProject.InvolvedProject = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProject.InvolvedProject, TestData);
        }
        [TestMethod]
        public void MobileNumberOK()
        {
            //create an instance of the class we want to create
            clsCompany AMobile = new clsCompany();
            //create some test data to assign to the property
            string TestData = "676767";
            //assign the data to the property
            AMobile.MobileNumber = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AMobile.MobileNumber, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCompany APhone = new clsCompany();
            //create some test data to assign to the property
            string TestData = "3345354";
            //assign the data to the property
            APhone.PhoneNumber = TestData;
            //test to see the two values are the same
            Assert.AreEqual(APhone.PhoneNumber, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestCompanyCodeFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.CompanyCode != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCompanyAddressFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.CompanyAddress != "TNovation")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.CompanyEmailAddress != "vijaymodhwadia@hotmail.co.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInvolvedClientFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.InvolvedClient != "Freddy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInvolvedProjectFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.InvolvedProject != "MyProject")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMobileNumberFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.MobileNumber != "676767")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyCode = 21;
            //invoke the method
            Found = ACompany.Find(CompanyCode);
            //check the company code
            if (ACompany.PhoneNumber != "3345354")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CompanyAddress = "13 Banner Street";
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "";//this should trigger an error
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CompanyAddressMin()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "a";//this should trigger an error
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "aa";//this should be ok
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "aaaa";//this should be ok
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyAddressMax()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "aaaaaa";//this should be ok
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyAddressMid()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "aaa";//this should be ok
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void CompanyAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create soem test data to pass out to the method
            string CompanyAddress = "aaaaaaa";//this should be ok
            string CompanyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            string InvolvedClient = "Callum Varle";
            string InvolvedProject = "TNovationProject";
            string MobileNumber = "654568";
            string PhoneNumber = "5457496";
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyEmailAddressMid()
        {
            //create an instance of the class we wnat to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CompanyAddress = "32a";
            string CompanyEmailAddress = "vijay45@gmail.com";
            string InvolvedClient = "Thomas";
            string InvolvedProject = "sdas";
            string MobileNumber = "354351568";
            string PhoneNumber = "5656561";
        }

        [TestMethod]
        public void CompanyEmailAddressExtremeMin()
        {
            //create an instance of the class we wnat to create
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CompanyAddress = "32a";
            string CompanyEmailAddress = "vijay45@gmail.com";
            string InvolvedClient = "Thomas";
            string InvolvedProject = "sdas";
            string MobileNumber = "354351568";
            string PhoneNumber = "5656561";
            //create a variable to store the test company email address data
            DateTime TestDate;
            // set the string to you email
            String = "myemail";
            //change the date to variable to a string variable
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CompanyEmailAddress = TestDate.ToString();
            //invoke the method
            OK = ACompany.Valid(CompanyAddress, CompanyEmailAddress, InvolvedClient, InvolvedProject, MobileNumber, PhoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
