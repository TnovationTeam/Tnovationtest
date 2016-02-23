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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the event code to search for
            DB.AddParameter("CompanyCode", CompanyCode);
            //execute the stored procedure
            DB.Execute("sproc_tblEvent_FilterByCompanyCode");
            //if one record is found ,there should be either one or zero!
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                companyCode = Convert.ToInt32(DB.DataTable.Rows[0]["CompanyCode"]);
                companyAddress = Convert.ToString(DB.DataTable.Rows[0]["CompanyAddress"]);
                companyEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CompanyEmailAddress"]);
                involvedClient = Convert.ToString(DB.DataTable.Rows[0]["InvolvedClient"]);
                involvedProject = Convert.ToString(DB.DataTable.Rows[0]["InvolvedProject"]);
                mobileNumber = Convert.ToString(DB.DataTable.Rows[0]["MobileNumber"]);
                phoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            { 
            //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string CompanyAddress, string CompanyEmailAddress, string InvolvedClient, string InvolvedProject, string MobileNumber, string PhoneNumber)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //if the CompanyAddress is blank
            if (CompanyAddress.Length==0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Company Address is greater than 6 characters
            if (CompanyAddress.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }

            //return the value true of OK
            return OK;
        }
    }
}
