using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;
using System.Collections.Generic;


namespace TNovationTestFramework
{
    [TestClass]
    public class tstProjectCollection
    {
        [TestMethod]
        public void InstanceOKCollection()
        {
            //create an instance of the class we want to create
            clsProjectCollection ProjectList = new clsProjectCollection();
            //test to see that it exists
            Assert.IsNotNull(ProjectList);
        }

        [TestMethod]
        public void CountProperty()
        {
            //create an instance of the class we want to create
            clsProjectCollection ProjectList = new clsProjectCollection();
            //create some test dat to ssign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            ProjectList.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(ProjectList.Count, SomeCount);

        }


        [TestMethod]
        public void ProjectListOK()
        {
            //create an instance of the class we want to create
            clsProjectCollection Projects = new clsProjectCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProject> TestList = new List<clsProject>();
            //add an item to the list
            //create item to test the data
            clsProject TestItem = new clsProject();
            //set its properties
            TestItem.ProjectCode = 1;
            TestItem.ProjectName = "London";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Projects.ProjectList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Projects.ProjectList, TestList);



        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsProjectCollection Projects = new clsProjectCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProject> TestList = new List<clsProject>();
            //add an item to the list
            //create item to test the data
            clsProject TestItem = new clsProject();
            //set its properties
            TestItem.ProjectCode = 1;
            TestItem.ProjectName = "London";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Projects.ProjectList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Projects.Count, TestList.Count);



        }

        ////[TestMethod]
        //public void TwoProjectsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsProjectCollection Projects = new clsProjectCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Projects.Count, 2);
        //}
    }
}
