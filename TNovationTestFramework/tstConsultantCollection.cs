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

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //Create an instance of the class we want to create
        //    clsConsultantCollection AllConsultants = new clsConsultantCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 0;
        //    //assign the data to the property
        //    AllConsultants.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllConsultants.Count, SomeCount);
        //}

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
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsConsultantCollection ConsultantList = new clsConsultantCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsConsultant> TestList = new List<clsConsultant>();
            //add an item to the list
            //create the item of the test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.Status = true;
            TestItem.ConsultantNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wayne";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Flat BC, 2 Cilantro Road";
            TestItem.Email = "Healthy@aol.com";
            TestItem.TelephoneNo = "07437320192";
            TestItem.EmergencyContact = "07528789924";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.HoursOfWork = 172;
            TestItem.EmploymentHistory = "None";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the item test list
            TestList.Add(TestItem);
            //assign the data to the property
            ConsultantList.AllConsultants = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(ConsultantList.Count, TestList.Count);

        }

        [TestMethod]
        public void ThisConsultantPropertyOK()
        {
            //create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.Status = true;
            TestItem.ConsultantNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wayne";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Flat BC, 2 Cilantro Road";
            TestItem.Email = "Healthy@aol.com";
            TestItem.TelephoneNo = "07437320192";
            TestItem.EmergencyContact = "07528789924";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.HoursOfWork = 172;
            TestItem.EmploymentHistory = "None";
            TestItem.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllConsultants.ThisConsultant = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllConsultants.ThisConsultant, TestItem);


        }

        [TestMethod]
        public void ConsultantListOK()
        {
            //create an instance of the class we want to create 
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsConsultant> TestList = new List<clsConsultant>();
            //add an item to the list
            //create the item of the test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.Status = true;
            TestItem.ConsultantNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wayne";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Flat BC, 2 Cilantro Road";
            TestItem.Email = "Healthy@aol.com";
            TestItem.TelephoneNo = "07437320192";
            TestItem.EmergencyContact = "07528789924";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.HoursOfWork = 172;
            TestItem.EmploymentHistory = "None";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllConsultants.ConsultantList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllConsultants.ConsultantList, TestList);


        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            clsConsultant TestItem = new clsConsultant();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Status = true;
            TestItem.ConsultantNo = 61;
            TestItem.FirstName = "James";
            TestItem.LastName = "Junior";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-17);
            TestItem.Address = "Flat C, Colly road";
            TestItem.Email = "Healthy@aol.com";
            TestItem.TelephoneNo = "07437320192";
            TestItem.EmergencyContact = "07528789924";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.HoursOfWork = 129;
            TestItem.EmploymentHistory = "None";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisConsultant to the test data
            AllConsultants.ThisConsultant = TestItem;
            //add the record
            PrimaryKey = AllConsultants.AddNew();
            //set the primary key of the test data
            TestItem.ConsultantNo = PrimaryKey;
            //find the record
            AllConsultants.ThisConsultant.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllConsultants.ThisConsultant, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            clsConsultant TestItem = new clsConsultant();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Status = true;
            TestItem.ConsultantNo = 46;
            TestItem.FirstName = "James";
            TestItem.LastName = "Junior";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-17);
            TestItem.Address = "Flat C, Basil road";
            TestItem.Email = "Healthy@aol.com";
            TestItem.TelephoneNo = "07528789965";
            TestItem.EmergencyContact = "07528789965";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.HoursOfWork = 129;
            TestItem.EmploymentHistory = "None";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisConsultant to the test data
            AllConsultants.ThisConsultant = TestItem;
            //add the record
            PrimaryKey = AllConsultants.AddNew();
            //set the primary key of the test data
            TestItem.ConsultantNo = PrimaryKey;
            //find the record
            AllConsultants.ThisConsultant.Find(PrimaryKey);
            //delete the record
            AllConsultants.Delete();
            //now find the record
            Boolean Found = AllConsultants.ThisConsultant.Find(PrimaryKey);
            //test to see that the record wasn't found
            Assert.IsFalse(Found);
        }



    }
}
