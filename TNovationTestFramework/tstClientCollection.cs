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
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsClientCollection AllClients = new clsClientCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assignt the data to the property
            AllClients.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllClients.Count, SomeCount);
            
        }




















    }

















}
