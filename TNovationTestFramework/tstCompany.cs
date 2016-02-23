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
            Assert.IsTrue(OK);
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














    }
}
