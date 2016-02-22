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
            clsCompany ACode = new clsCompany();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACode.CompanyCode = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACode.CompanyCode, TestData);
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
































    }
}
