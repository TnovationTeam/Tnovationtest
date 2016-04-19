using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;
using System.Collections.Generic;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstConsultantCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //test to see that it exists
            Assert.IsNotNull(AllConsultants);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllConsultants.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllConsultants.Count, SomeCount);
        }

        [TestMethod]
        public void AllConsultantsOK()
        {
            //Create an instance of the class we want to create
            clsConsultantCollection Consultants = new clsConsultantCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsConsultant> TestList = new List<clsConsultant>();
            //add an item to the list 
            //create an item of test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.ConsultantNo = 1;
            TestItem.FirstName = "James";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Consultants.AllConsultants = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Consultants.AllConsultants, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsConsultantCollection Consultants = new clsConsultantCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsConsultant> TestList = new List<clsConsultant>();
            //add an item to the list
            //create the item of test data
            clsConsultant TestItem = new clsConsultant();
            //set its operties
            TestItem.ConsultantNo = 1;
            TestItem.FirstName = "James";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Consultants.AllConsultants = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Consultants.Count, TestList.Count);



        }



        //[TestMethod]
        //public void TwoConsultantsPresent()
        //{
        //    //Create an instance of the class we want to create
        //    clsConsultantCollection Consultants = new clsConsultantCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Consultants.Count, 2);
        //}

        
}
}
