using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstProject
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //test to see that it exists
            Assert.IsNotNull(AProject);
        }

        [TestMethod]
        public void ProjectCodePropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProject.ProjectCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.ProjectCode, TestData);

        }

        [TestMethod]
        public void ProjectNamePropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string TestData = "A Project";
            //assign the data to the property
            AProject.ProjectName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.ProjectName, TestData);

        }

        [TestMethod]
        public void CompanyNamePropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string TestData = "Tech Company";
            //assign the data to the property
            AProject.CompanyName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.CompanyName, TestData);

        }

        [TestMethod]
        public void ProjectConsultantPropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string TestData = "A person";
            //assign the data to the property
            AProject.ProjectConsultant = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.ProjectConsultant, TestData);

        }

        [TestMethod]
        public void CompanyContactPropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string TestData = "078218122";
            //assign the data to the property
            AProject.CompanyContact = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.CompanyContact, TestData);

        }

        [TestMethod]
        public void ExpectedEndDatePropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AProject.ExpectedEndDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.ExpectedEndDate, TestData);

        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AProject.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.StartDate, TestData);

        }

        [TestMethod]
        public void ProjectLocationPropertyOK()
        {
            //create an isntance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string TestData = "A Location";
            //assign the data to the property
            AProject.ProjectLocation = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProject.ProjectLocation, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestProjectCodeFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.ProjectCode != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProjectNameFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.ProjectName != "A Project")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestProjectConsultantFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.ProjectConsultant != "A person")
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
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.CompanyName != "Tech Company")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestExpectedEndDateFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.ExpectedEndDate != Convert.ToDateTime("30/04/2016 19:00:00"))
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
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.StartDate != Convert.ToDateTime("15/03/2016 13:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyLocationFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.ProjectLocation != " A Location")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCompanyContactFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProjectCode = 1;
            //invoke the method
            Found = AProject.Find(ProjectCode);
            //check the project code
            if (AProject.CompanyContact != "078218122")
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
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StartDateExtremeMinOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //create a variable to store the test date data
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //date changed to -100, this test should fail
            TestDate = TestDate.AddYears(-100);
            //convert date variable to string variable
            string StartDate = TestDate.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StartDateMinLessOneOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //variable to store date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //date changed to -100, this test should fail
            TestDate = TestDate.AddDays(-1);
            //convert date variable to string variable
            string StartDate = TestDate.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StartDateMinOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //variable to store date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //convert date variable to string variable
            string StartDate = TestDate.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StartDateMinPlusOneOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //variable to store date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //date changed to -100, this test should fail
            TestDate = TestDate.AddDays(1);
            //convert date variable to string variable
            string StartDate = TestDate.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StartDateExtremeMaxOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //variable to store date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //date changed to -100, this test should fail
            TestDate = TestDate.AddYears(100);
            //convert date variable to string variable
            string StartDate = TestDate.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StartDateInvalidOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "A Location";
            //variable to store date
            string StartDate = "A date";
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ProjectLocationMinlessoneOk()
        {

            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ProjectLocationMinOk()
        {

            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ProjectLocationMaxLessOneOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //creates  29 characters instead of writing many out
            ProjectLocation = ProjectLocation.PadRight(29, 'b');
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ProjectLocationMaxOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //creates  29 characters instead of writing many out
            ProjectLocation = ProjectLocation.PadRight(30, 'b');
            //variable to store date
            string startDate = DateTime.Now.Date.ToString();
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ProjectLocationMaxPlusOneOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //creates  29 characters instead of writing many out
            ProjectLocation = ProjectLocation.PadRight(31, 'b');
            //variable to store date

            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ProjectLocationMidOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //creates  29 characters instead of writing many out
            ProjectLocation = ProjectLocation.PadRight(15, 'b');
            //invoke method
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ProjectLocationExtremeMaxOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "A Project";
            string CompanyName = "Tech Company";
            string CompanyContact = "078218122";
            string ExpectedEndDate = DateTime.Now.Date.ToString();
            string StartDate = DateTime.Now.Date.ToString();
            string ProjectConsultant = "A person";
            string ProjectLocation = "";//testing location
            //creates  29 characters instead of writing many 
            ProjectLocation = ProjectLocation.PadRight(500, 'b');
            //variable to store date
            OK = AProject.Valid(ProjectName, CompanyName, CompanyContact, ExpectedEndDate, StartDate, ProjectConsultant, ProjectLocation);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


    }
}
