using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstClient
   
    {
                
        /*THIS TEST IS TO CREATE THE clsCLIENT CLASS*/
        //
        //
        //
        //

        [TestMethod]    //create an instance of the clsClient class
        public void InstanceOK()

        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //test to see if that exists
            Assert.IsNotNull(AClient);
        }
        
        //
        //
        //
        //
        /*THE BELOW TESTS IS TO CREATE THE PROPERTIES FOR THE clsCLIENT CLASS*/
        //
        //
        //
        //

        [TestMethod] //create Active property in clsClient
        public void ActivePropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AClient.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.Active, TestData);
                        
        }


        [TestMethod] //create DateAdded property in clsClient
        public void DateAddedPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AClient.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.DateAdded, TestData);

        }



        [TestMethod] //create ClientAddress property in clsClient
        public void ClientAddressPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AClient.ClientAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientAddress, TestData);

        }

        [TestMethod] //create Client name property in clsClient
        public void ClientNamePropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "freddy";
            //assign the data to the property
            AClient.ClientName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientName, TestData);

        }

        [TestMethod] //create Client email property in clsClient
        public void ClientEmailPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "freddy@gmail.com";
            //assign the data to the property
            AClient.ClientEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientEmail, TestData);

        }


        [TestMethod] //create Client position property in clsClient
        public void ClientPositionOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "CEO";
            //assign the data to the property
            AClient.ClientPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientPosition, TestData);

        }


        [TestMethod] //create Client qualification property in clsClient
        public void ClientQualificationOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "degree";
            //assign the data to the property
            AClient.ClientQualification = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientQualification, TestData);

        }



        [TestMethod] //create Client Service property in clsClient
        public void ClientServiceOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            string TestData = "IT support for company";
            //assign the data to the property
            AClient.ClientService = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientService, TestData);

        }

        [TestMethod] //create Client number property in clsClient
        public void ClientNoPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AClient.ClientNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientNo, TestData);

        }

        [TestMethod] //create client telephone property in clsClient
        public void ClientTelPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            Int32 TestData = 783763;
            //assign the data to the property
            AClient.ClientTel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientTel, TestData);

        }

        //
        //
        //
        //
        
        /*THE BELOW TESTS IS TO CREATE THE METHODS FOR THE clsCLIENT CLASS*/
        //FIND METHOD AND VALID METHOD
        //
        //
        //
        //

        /*Testing for FIND METHOD*/


        [TestMethod] //create Find method in clsClient
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }


        [TestMethod] //create ClientNo Found method in clsClient
        public void TestClientNoFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientNo !=21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod] //create ClientName Found method in clsClient
        public void TestClientNameFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientName != "freddy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        [TestMethod] //create ClientEmail Found method in clsClient
        public void TestClientEmailFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientEmail != "freddy@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }



        [TestMethod] //create ClientPosition Found method in clsClient
        public void TestClientPositionFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientPosition != "CEO")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        [TestMethod] //create ClientQualification Found method in clsClient
        public void TestClientQualificationFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientQualification != "degree")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        [TestMethod] //create ClientService Found method in clsClient
        public void TestClientServiceFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientService != "IT support for company")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }



        [TestMethod] //create ClientAddress Found method in clsClient
        public void TestClientAddressFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientAddress != "21b")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        [TestMethod] //create ClientTel Found method in clsClient
        public void TestClientTelFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientTel != 783763)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }



        [TestMethod] //create DateAdded Found method in clsClient
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the property
            if (AClient.DateAdded != Convert.ToDateTime("20/02/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod] //create Active Found method in clsClient
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 21;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the property
            if (AClient.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod] //create Valid method in clsClient
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
            
        }

        ///////////////////////////////////////////////////// Test plan for ClientName Validation 


        //ClientName Validation for Min-1
        [TestMethod] //testing for Validating Clientname --> Min-1 ie 0 characters 
        public void ClientNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientName Validation for Min
        [TestMethod] //testing for Validating Clientname --> Min ie 1 character
        public void ClientNameMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "a";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }



        //ClientName Validation for Min+1
        [TestMethod] //testing for Validating Clientname --> Min+1 ie 2 character
        public void ClientNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "aa";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        //ClientName Validation for Max-1 ie 49 characters
        [TestMethod] //testing for Validating Clientname --> Max-1 ie 49 characters
        public void ClientNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            ClientName = ClientName.PadRight(49, 'a');
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientName Validation for Max ie 50 characters
        [TestMethod] //testing for Validating Clientname --> Max 50 characters
        public void ClientNameMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            ClientName = ClientName.PadRight(50, 'a');
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientName Validation for Mid ie 25 characters
        [TestMethod] //testing for Validating Clientname --> Mid 25 characters
        public void ClientNameMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            ClientName = ClientName.PadRight(25, 'a');
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        //ClientName Validation for Max+1 ie 51 characters
        [TestMethod] //testing for Validating Clientname --> Max 51 characters
        public void ClientNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            ClientName = ClientName.PadRight(51, 'a');
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientName Validation for extreme Max ie 500 characters
        [TestMethod] //testing for Validating Clientname --> Extreme Max 500 characters
        public void ClientNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "";
            ClientName = ClientName.PadRight(500, 'a');
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }



        ///////////////////////////////////////////////////// Test plan for DateAdded Validation 


        //DateAdded Validation for extreme Min ie todays date less 100 years
        [TestMethod] //testing for Validating dateadded --> Extreme Min  todays date less 100 years
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //DateAdded Validation for Min less one ie yesterdays date 
        [TestMethod] //testing for Validating dateadded --> Min less one yesterdays date
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //DateAdded Validation for Min ie todays date 
        [TestMethod] //testing for Validating dateadded --> todays date
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //DateAdded Validation for Min plus one ie tommorows date 
        [TestMethod] //testing for Validating dateadded --> Min plus one tommorows date
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        //DateAdded Validation for ExtremeMax ie todays date 
        [TestMethod] //testing for Validating dateadded --> extreme max todays date
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the todays date 
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        ///////////////////////////////////////////////////// Test plan for ClientEmail Validation 




        //ClientEmail Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientEmail --> Min less one ie blank
        public void ClientEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientEmail Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientEmail --> Min  ie one character
        public void ClientEmailMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "l";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientEmail Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientEmail --> Min  ie two characters
        public void ClientEmailMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "ll";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientEmail Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientEmail --> MaxLessOne  ie 49 characters
        public void ClientEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "";
            ClientEmail = ClientEmail.PadRight(49, 'l');
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientEmail Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientEmail --> Max  ie 50 characters
        public void ClientEmailMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "";
            ClientEmail = ClientEmail.PadRight(50, 'l');
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientEmail Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientEmail --> Max  ie 51 characters
        public void ClientEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "";
            ClientEmail = ClientEmail.PadRight(51, 'l');
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientEmail Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientEmail --> Mid  ie 25 characters
        public void ClientEmailMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "";
            ClientEmail = ClientEmail.PadRight(25, 'l');
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }




        ///////////////////////////////////////////////////// Test plan for ClientPosition Validation 




        //ClientPosition Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientPosition --> Min less one ie blank
        public void ClientPositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientPosition Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientPosition --> Min  ie one character
        public void ClientPositionMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "C";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientPosition Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientPosition --> Min  ie two characters
        public void ClientPositionMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CE";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientPosition Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientPosition --> MaxLessOne  ie 49 characters
        public void ClientPositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "";
            ClientPosition = ClientPosition.PadRight(49, 'c');
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientPosition Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientPosition --> Max  ie 50 characters
        public void ClientPositionMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "";
            ClientPosition = ClientPosition.PadRight(50, 'c');
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientPosition Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientPosition --> Max  ie 51 characters
        public void ClientPositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "";
            ClientPosition = ClientPosition.PadRight(51, 'c');
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientPosition Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientPosition --> Mid  ie 25 characters
        public void ClientPositionMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "";
            ClientPosition = ClientPosition.PadRight(25, 'c');
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        ///////////////////////////////////////////////////// Test plan for ClientQualification Validation 




        //ClientQualification Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientQualification --> Min less one ie blank
        public void ClientQualificationMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientQualification Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientQualification --> Min  ie one character
        public void ClientQualificationMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "d";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientQualification Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientQualification --> Min  ie two characters
        public void ClientQualificationMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "de";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientQualification Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientQualification --> MaxLessOne  ie 49 characters
        public void ClientQualificationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "";
            ClientQualification = ClientQualification.PadRight(49, 'd');
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientQualification Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientQualification --> Max  ie 50 characters
        public void ClientQualificationMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "";
            ClientQualification = ClientQualification.PadRight(50, 'd');
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientQualification Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientQualification --> Max  ie 51 characters
        public void ClientQualificationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "";
            ClientQualification = ClientQualification.PadRight(51, 'd');
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientQualification Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientQualification --> Mid  ie 25 characters
        public void ClientQualificationMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "";
            ClientQualification = ClientQualification.PadRight(25, 'd');
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }







        ///////////////////////////////////////////////////// Test plan for ClientService Validation 




        //ClientService Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientService --> Min less one ie blank
        public void ClientServiceMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientService Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientService --> Min  ie one character
        public void ClientServiceMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "I";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientService Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientService --> Min  ie two characters
        public void ClientServiceMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT";
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientService Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientService --> MaxLessOne  ie 49 characters
        public void ClientServiceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "";
            ClientService = ClientService.PadRight(49, 'I');
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientService Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientService --> Max  ie 50 characters
        public void ClientServiceMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "";
            ClientService = ClientService.PadRight(50, 'I');
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientService Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientService --> Max  ie 51 characters
        public void ClientServiceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "";
            ClientService = ClientService.PadRight(51, 'I');
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientService Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientService --> Mid  ie 25 characters
        public void ClientServiceMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "";
            ClientService = ClientService.PadRight(25, 'd');
            string ClientAddress = "21b";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }





        ///////////////////////////////////////////////////// Test plan for ClientAddress Validation 




        //ClientAddress Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientAddress --> Min less one ie blank
        public void ClientAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientAddress Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientAddress --> Min  ie one character
        public void ClientAddressMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "2";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientAddress Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientAddress --> Min  ie two characters
        public void ClientAddressMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21";
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientAddress Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientAddress --> MaxLessOne  ie 49 characters
        public void ClientAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "";
            ClientAddress = ClientAddress.PadRight(49, '2');
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientAddress Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientAddress --> Max  ie 50 characters
        public void ClientAddressMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "";
            ClientAddress = ClientAddress.PadRight(50, '2');
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientAddress Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientAddress --> Max  ie 51 characters
        public void ClientAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "";
            ClientAddress = ClientAddress.PadRight(51, '2');
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientAddress Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientAddress --> Mid  ie 25 characters
        public void ClientAddressMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "";
            ClientAddress = ClientAddress.PadRight(25, '2');
            string ClientTel = "783763";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        ///////////////////////////////////////////////////// Test plan for ClientTel Validation 




        //ClientTel Validation for Min less one ie no characters 
        [TestMethod] //testing for Validating ClientTel --> Min less one ie blank
        public void ClientTelMinLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientTel Validation for Min  ie one characters 
        [TestMethod] //testing for Validating ClientTel --> Min  ie one character
        public void ClientTelMin()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "7";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientTel Validation for MinplusOne  ie two characters 
        [TestMethod] //testing for Validating ClientTel --> Min  ie two characters
        public void ClientTelMinplusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "78";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientTel Validation for MaxLessOne  ie 49 characters 
        [TestMethod] //testing for Validating ClientTel --> MaxLessOne  ie 49 characters
        public void ClientTelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "";
            ClientTel = ClientTel.PadRight(49, '7');
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientTel Validation for Max  ie 50 characters 
        [TestMethod] //testing for Validating ClientTel --> Max  ie 50 characters
        public void ClientTelMax()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "";
            ClientTel = ClientTel.PadRight(50, '7');
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        //ClientTel Validation for MaxPlusOne  ie 51 characters 
        [TestMethod] //testing for Validating ClientTel --> Max  ie 51 characters
        public void ClientTelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "";
            ClientTel = ClientTel.PadRight(51, '7');
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        //ClientTel Validation for Mid  ie 25 characters 
        [TestMethod] //testing for Validating ClientTel --> Mid  ie 25 characters
        public void ClientTelMid()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ClientName = "freddy";
            string ClientEmail = "freddy@gmail.com";
            string ClientPosition = "CEO";
            string ClientQualification = "degree";
            string ClientService = "IT support for company";
            string ClientAddress = "21b";
            string ClientTel = "";
            ClientTel = ClientTel.PadRight(25, '7');
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AClient.Valid(ClientName, ClientEmail, ClientPosition, ClientQualification, ClientService, ClientAddress, ClientTel, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }






















     }

    }

