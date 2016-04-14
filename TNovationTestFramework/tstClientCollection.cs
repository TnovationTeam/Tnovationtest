using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;
using System.Collections.Generic;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstClientCollection
    {
        [TestMethod]
        public void InstanceOK()
            
            {
            //create an instance of the class we want to create 
                clsClientCollection AllClients = new clsClientCollection();
            //test to see that it exists
                Assert.IsNotNull(AllClients);


            }

        [TestMethod]
        public void ClientListOK()
        {
            //create an instance of the class we want to create 
            clsClientCollection AllClients = new clsClientCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsClient> TestList = new List<clsClient>();
            //add an item to the list
            //create the item of the test data
            clsClient TestItem = new clsClient();
            //set its properties
            TestItem.Active = true;
            TestItem.ClientAddress = "21b";
            TestItem.ClientEmail = "freddy@gmail.com";
            TestItem.ClientName = "freddy";
            TestItem.ClientNo = 21;
            TestItem.ClientPosition = "CEO";
            TestItem.ClientQualification = "degree";
            TestItem.ClientService = "IT support for company";
            TestItem.ClientTel = 783763;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the item test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClients.ClientList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClients.ClientList, TestList);
           
        }

        


        [TestMethod]
        public void ThisClientPropertyOK()
        {
            //create an instance of the class we want to create 
            clsClientCollection AllClients = new clsClientCollection();
            //create some test data to assign to the property
            clsClient TestClient = new clsClient();
            //set the properties of the test object
            TestClient.Active = true;
            TestClient.ClientAddress = "21b";
            TestClient.ClientEmail = "freddy@gmail.com";
            TestClient.ClientName = "freddy";
            TestClient.ClientNo = 21;
            TestClient.ClientPosition = "CEO";
            TestClient.ClientQualification = "degree";
            TestClient.ClientService = "IT support for company";
            TestClient.ClientTel = 783763;
            TestClient.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllClients.ThisClient = TestClient;
            //test to see that the two values are the same
            Assert.AreEqual(AllClients.ThisClient, TestClient);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsClientCollection AllClients = new clsClientCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsClient> TestList = new List<clsClient>();
            //add an item to the list
            //create the item of the test data
            clsClient TestItem = new clsClient();
            //set its properties
            TestItem.Active = true;
            TestItem.ClientAddress = "21b";
            TestItem.ClientEmail = "freddy@gmail.com";
            TestItem.ClientName = "freddy";
            TestItem.ClientNo = 21;
            TestItem.ClientPosition = "CEO";
            TestItem.ClientQualification = "degree";
            TestItem.ClientService = "IT support for company";
            TestItem.ClientTel = 783763;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the item test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClients.ClientList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClients.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsClientCollection AllClients = new clsClientCollection();
            //create the item of the test data
            clsClient TestItem = new clsClient();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ClientAddress = "21b";
            TestItem.ClientEmail = "freddy@gmail.com";
            TestItem.ClientName = "freddy";
            TestItem.ClientNo = 21;
            TestItem.ClientPosition = "CEO";
            TestItem.ClientQualification = "degree";
            TestItem.ClientService = "IT support for company";
            TestItem.ClientTel = 783763;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllClients.ThisClient = TestItem;
            //add the record
            PrimaryKey = AllClients.Add();
            //set the primary key of the test data
            TestItem.ClientNo = PrimaryKey;
            //find the record
            AllClients.ThisClient.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllClients.ThisClient, TestItem);

        }















    }

















}
