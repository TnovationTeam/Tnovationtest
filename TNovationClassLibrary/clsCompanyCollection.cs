using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsCompanyCollection
    {
        //private data member for the list
        List<clsCompany> companyList = new List<clsCompany>();
        //private data member thisCompany
        clsCompany thisCompany = new clsCompany();

        //public property for the client list
        public List<clsCompany> CompanyList
        {

            get
            {
                //return the private data 
                return companyList;
            }

            set
            {
                //set the private data
                companyList = value;

            }

        }

        //public property for count
        public int Count
        {
            get

            {
                //return the count of the list 
                return companyList.Count;
            }
            set
            {

            }
        }

        //public property for this client
        public clsCompany ThisCompany {

            get
            {
                //return the private data
                return thisCompany;

            }

            set
            {
                //set the private data
                thisCompany = value;
            }


        }

        //public constructor for the class
        public clsCompanyCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCompany_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsClient ACompany = new clsClient();
                //read in the fields from the current record
                ACompany.CompanyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["CompanyCode"]);
                ACompany.CompanyAddress = Convert.ToString(DB.DataTable.Rows[Index]["CompanyAddress"]);
                ACompany.CompanyEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CompanyEmailAddress"]);
                ACompany.InvolvedClient = Convert.ToString(DB.DataTable.Rows[Index]["InvolvedClient"]);
                ACompany.InvolvedProject = Convert.ToString(DB.DataTable.Rows[Index]["InvolvedProject"]);
                ACompany.MobileNumber = Convert.ToString(DB.DataTable.Rows[Index]["MobileNumber"]);
                ACompany.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                //add the record to the private data member
                companyList.Add(ACompany);
                //point at the next record
                Index++;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisaddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CompanyCode", thisCompany.CompanyCode);
            DB.AddParameter("@CompanyAddress", thisCompany.CompanyAddress);
            DB.AddParameter("@CompanyEmailAddress", thisCompany.CompanyEmailAddress);
            DB.AddParameter("@InvolvedClient", thisCompany.InvolvedClient);
            DB.AddParameter("@InvolvedProject", thisCompany.InvolvedProject);
            DB.AddParameter("@MobileNumber", thisCompany.MobileNumber);
            DB.AddParameter("@PhoneNumber", thisCompany.PhoneNumber);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblClient_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCompany
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CompanyCode", thisCompany.CompanyCode);
            //execute the stored procedure
            DB.Execute("sproc_tblClient_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisaddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ClientNo", thisCompany.ClientNo);
            DB.AddParameter("@ClientName", thisCompany.ClientName);
            DB.AddParameter("@ClientEmail", thisCompany.ClientEmail);
            DB.AddParameter("@ClientPosition", thisCompany.ClientPosition);
            DB.AddParameter("@ClientQualification", thisCompany.ClientQualification);
            DB.AddParameter("@ClientService", thisCompany.ClientService);
            DB.AddParameter("@ClientAddress", thisCompany.ClientAddress);
            DB.AddParameter("@ClientTel", thisCompany.ClientTel);
            DB.AddParameter("@DateAdded", thisCompany.DateAdded);
            DB.AddParameter("@Active", thisCompany.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblClient_Update");
        }
    }
}
