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

        [TestMethod]    
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

        [TestMethod]
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


        [TestMethod]
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

       

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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


        [TestMethod]
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


        [TestMethod]
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



        [TestMethod]
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

        [TestMethod]
        public void ClientNoPropertyOK()
        {
            //create an instance of the class I want to create
            clsClient AClient = new clsClient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AClient.ClientNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientNo, TestData);

        }

        [TestMethod]
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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ClientNo = 1;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void TestClientNoFound()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClientNo = 1;
            //invoke the method
            Found = AClient.Find(ClientNo);
            //check the ClientNo
            if (AClient.ClientNo !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        }

     }

