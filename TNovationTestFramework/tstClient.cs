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
        

     }

    }

