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
        
        public clsClient ThisClient { get; set; }
        
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
    }
}
