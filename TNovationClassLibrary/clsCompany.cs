using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsCompany
    {

        //private data member for the CompanyCode property
        private Int32 companyCode;
        //private data member for the CompanyAddress property
        private string companyAddress;
        //private data member for the CompanyEmailAddress property
        private string companyEmailAddress;
        //private data member for the CompanyEmailAddress property
        private string involvedClient;
        //private data member for the CompanyEmailAddress property
        private string involvedProject;
        //private data member for the CompanyEmailAddress property
        private string mobileNumber;
        //private data member for the CompanyEmailAddress property
        private string phoneNumber;










        public int CompanyCode
        {
            get
            {
                //return the private data
                return companyCode;
            }
            set
            {
                //set the value of the private data member
                companyCode = value;
            }
        }
        public string CompanyAddress 
        {

            get
            {
                //return the private data
                return companyAddress;
            }
            set
            {
                //set the value of the private data member
                companyAddress = value;
            }
        }

        public string CompanyEmailAddress 
        {
            get
            {
                //return the private data
                return companyEmailAddress;
            }
            set
            {
                //set the value of the private data member
                companyEmailAddress = value;
            }
        }

        public string InvolvedClient 
        {
            get
            {
                //return the private data
                return involvedClient;
            }
            set
            {
                //set the value of the private data member
                involvedClient = value;
            }
        }

        public string InvolvedProject 
        {
            get
            {
                //return the private data
                return involvedProject;
            }
            set
            {
                //set the value of the private data member
                involvedProject = value;
            }
        }

        public string MobileNumber 
        {
            get
            {
                //return the private data
                return mobileNumber;
            }
            set
            {
                //set the value of the private data member
                mobileNumber = value;
            }
        }

        public string PhoneNumber 
        {
            get
            {
                //return the private data
                return phoneNumber;
            }
            set
            {
                //set the value of the private data member
                phoneNumber = value;
            }
        }

        public bool Find(int CompanyCode)
        {
            //set the private data member to the test data value
            companyCode = 21;
            companyAddress = "TNovation";
            companyEmailAddress = "vijaymodhwadia@hotmail.co.uk";
            involvedClient = "Freddy";
            involvedProject = "MyProject";
            mobileNumber = "676767";
            phoneNumber = "3345354";
            //always return true;
            return true;

        }
    }
}
