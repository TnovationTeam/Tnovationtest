using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsClient
    {
        //private data member for the ClientNo property
        private Int32 clientNo;
        //private data member for the ClientName property
        private string clientName;
        //private data member for the ClientEmail property
        private string clientEmail;
        //private data member for the ClientPosition property
        private string clientPosition;
        //private data member for the ClientQualification property
        private string clientQualification;
        //private data member for the ClientService property
        private string clientService;
        //private data member for the ClientAddress property
        private string clientAddress;
        //private data member for the ClientTel property
        private Int32 clientTel;
        //private data member for the DateAdded property
        private DateTime dateAdded;
        //private data member for the Active property
        private Boolean active;





        public bool Active
        {
            get
            {
                //return the private data
                return active;
            }

            set
            {
                //set the value of the private data member
                active = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return dateAdded;
            }

            set
            {
                //set the value of the private data member
                dateAdded = value;
            }
        }

        public string ClientAddress
        {
            get
            {
                //return the private data
                return clientAddress;
            }

            set
            {
                //set the value of the private data member
                clientAddress = value;
            }
        }

        public string ClientName
        {
            get
            {
                //return the private data
                return clientName;
            }

            set
            {
                //set the value of the private data member
                clientName = value;
            }

        }

        public string ClientEmail
        {

            get
            {
                //return the private data
                return clientEmail;
            }

            set
            {
                //set the value of the private data member
                clientEmail = value;
            }

        }

        public string ClientPosition
        {

            get
            {
                //return the private data
                return clientPosition;
            }

            set
            {
                //set the value of the private data member
                clientPosition = value;
            }

        }

        public string ClientQualification
        {


            get
            {
                //return the private data
                return clientQualification;
            }

            set
            {
                //set the value of the private data member
                clientQualification = value;
            }

        }

        public string ClientService
        {
            get
            {
                //return the private data
                return clientService;
            }

            set
            {
                //set the value of the private data member
                clientService = value;
            }
        }


        //public property  for the client number
        public int ClientNo
        {

            get
            {
                //return the private data
                return clientNo;
            }

            set
            {
                //set the value of the private data member
                clientNo = value;
            }

        }

        public int ClientTel
        {
            get
            {
                //return the private data
                return clientTel;
            }

            set
            {
                //set the value of the private data member
                clientTel = value;
            }
        }



        public bool Find(int ClientNo)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the clientno to search for
            DB.AddParameter("ClientNo", ClientNo);
            //execute the stored procedure
            DB.Execute("sproc_tblClient_FilterByClientNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //set the private data member to the test data value
                clientNo = Convert.ToInt32(DB.DataTable.Rows[0]["ClientNo"]);
                clientName = Convert.ToString(DB.DataTable.Rows[0]["ClientName"]);
                clientEmail = Convert.ToString(DB.DataTable.Rows[0]["ClientEmail"]);
                clientPosition = Convert.ToString(DB.DataTable.Rows[0]["ClientPosition"]);
                clientQualification = Convert.ToString(DB.DataTable.Rows[0]["ClientQualification"]);
                clientService = Convert.ToString(DB.DataTable.Rows[0]["ClientService"]);
                clientAddress = Convert.ToString(DB.DataTable.Rows[0]["ClientAddress"]);
                clientTel = Convert.ToInt32(DB.DataTable.Rows[0]["ClientTel"]);
                dateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public bool Valid(string ClientName, string ClientEmail, string ClientPosition, string ClientQualification, string ClientService, string ClientAddress, string ClientTel, string DateAdded)
        {   
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the ClientName is blank
            if (ClientName.Length ==0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if ClientName is greater than 50 characters
            if (ClientName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //copy the DateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(DateAdded);
            //check to see if the date is less than todays date
            if (DateTemp < DateTime.Now.Date)
            {
                //set the flag OK to false
                OK = false;
            }
            
            //check to see if the date is greater than todays date
            if (DateTemp > DateTime.Now.Date)
            {
                 //set the flag ok to false 
                OK = false;
            }

            //if the client email is blank
            if (ClientEmail.Length == 0)
            {
                //set the flag ok to false 
                OK = false;
               
            }

            //if the clientemail is too long
            if (ClientEmail.Length > 50)
            {
                //set the flag ok to false 
                OK = false;
            }
            //return the value of OK
            return OK;
        }
    }

}
