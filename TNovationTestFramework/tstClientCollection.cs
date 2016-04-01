using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TNovationClassLibrary;

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





















    }

















}
