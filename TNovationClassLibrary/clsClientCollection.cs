using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsClientCollection
    {
        //private data member for the list
        List<clsClient> clientList = new List<clsClient>();
        //private data member thisClient
        clsClient thisClient = new clsClient();

        //public property for the client list
        public List<clsClient> ClientList 
        {

            get 
            {
               //return the private data 
                  return clientList;
            }
            
           set
            {
               //set the private data
                clientList = value;

            }
        
        }

        //public property for count
        public int Count
        {
            get
            
            {
            //return the count of the list 
                return clientList.Count;
            }
            set
            {

            }
        }
        
        //public property for this client
        public clsClient ThisClient { 
            
            get {
                //return the private data
                return thisClient;

            }

            set
            {
                //set the private data
                thisClient = value;
            }
            
            
            }
        
        //public constructor for the class
        public clsClientCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblClient_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsClient AClient = new clsClient();
                //read in the fields from the current record
                AClient.ClientNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ClientNo"]);
                AClient.ClientName = Convert.ToString(DB.DataTable.Rows[Index]["ClientName"]);
                AClient.ClientEmail = Convert.ToString(DB.DataTable.Rows[Index]["ClientEmail"]);
                AClient.ClientPosition = Convert.ToString(DB.DataTable.Rows[Index]["ClientPosition"]);
                AClient.ClientQualification = Convert.ToString(DB.DataTable.Rows[Index]["ClientQualification"]);
                AClient.ClientService = Convert.ToString(DB.DataTable.Rows[Index]["ClientService"]);
                AClient.ClientAddress = Convert.ToString(DB.DataTable.Rows[Index]["ClientAddress"]);
                AClient.ClientTel = Convert.ToInt32(DB.DataTable.Rows[Index]["ClientTel"]);
                AClient.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AClient.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                clientList.Add(AClient);
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
            DB.AddParameter("@ClientNo", thisClient.ClientNo);
            DB.AddParameter("@ClientName", thisClient.ClientName);
            DB.AddParameter("@ClientEmail", thisClient.ClientEmail);
            DB.AddParameter("@ClientPosition", thisClient.ClientPosition);
            DB.AddParameter("@ClientQualification", thisClient.ClientQualification);
            DB.AddParameter("@ClientService", thisClient.ClientService);
            DB.AddParameter("@ClientAddress", thisClient.ClientAddress);
            DB.AddParameter("@ClientTel", thisClient.ClientTel);
            DB.AddParameter("@DateAdded", thisClient.DateAdded);
            DB.AddParameter("@Active", thisClient.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblClient_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisClient
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ClientNo", thisClient.ClientNo);
            //execute the stored procedure
            DB.Execute("sproc_tblClient_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisaddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ClientNo", thisClient.ClientNo);
            DB.AddParameter("@ClientName", thisClient.ClientName);
            DB.AddParameter("@ClientEmail", thisClient.ClientEmail);
            DB.AddParameter("@ClientPosition", thisClient.ClientPosition);
            DB.AddParameter("@ClientQualification", thisClient.ClientQualification);
            DB.AddParameter("@ClientService", thisClient.ClientService);
            DB.AddParameter("@ClientAddress", thisClient.ClientAddress);
            DB.AddParameter("@ClientTel", thisClient.ClientTel);
            DB.AddParameter("@DateAdded", thisClient.DateAdded);
            DB.AddParameter("@Active", thisClient.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblClient_Update");
        }
    }
}
