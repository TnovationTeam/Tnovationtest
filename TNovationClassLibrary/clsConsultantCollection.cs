using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsConsultantCollection
    {
        //private data member for the allConsultants list
        private List<clsConsultant> allConsultants = new List<clsConsultant>();
        //private data member for ThisConsultant
        clsConsultant thisConsultant = new clsConsultant();

        //public property for count
        public int Count 
        { 
            get
            {

                //return the count property of the private list
                return allConsultants.Count;
            }

            
            
set
            {
             
              //we will look at this later
            }
}

        //public list for AllConsultants
        public List<clsConsultant> AllConsultants
        {
            //the getter sends data to request code
            get
            {
                //return the private data member
                return allConsultants;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                allConsultants = value;
            }


        }

        //public property for Consultant
        public clsConsultant ThisConsultant
        {

            get
            {
                //return the private data
                return thisConsultant;

            }

            set
            {
                //set the private data
                thisConsultant = value;
            }


        }

        //Public property for add
        public int AddNew()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConsultantNo", thisConsultant.ConsultantNo);
            DB.AddParameter("@FirstName", thisConsultant.FirstName);
            DB.AddParameter("@LastName", thisConsultant.LastName);
            DB.AddParameter("@DateOfBirth", thisConsultant.DateOfBirth);
            DB.AddParameter("@Address", thisConsultant.Address);
            DB.AddParameter("@Email", thisConsultant.Email);
            DB.AddParameter("@TelephoneNo", thisConsultant.TelephoneNo);
            DB.AddParameter("@EmergencyContact", thisConsultant.EmergencyContact);
            DB.AddParameter("@EmploymentDate", thisConsultant.EmploymentDate);
            DB.AddParameter("@HoursOfWork", thisConsultant.HoursOfWork);
            DB.AddParameter("@EmploymentHistory", thisConsultant.EmploymentHistory);

            //execute the stored procedure to insert data 
            return DB.Execute("sproc_tblConsultant_Insert");
        }

        //public constructor for the class
        public clsConsultantCollection()
        {
            //create an instance of the county class to store a county
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblConsultant_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the Consultant class
                clsConsultant AConsultant = new clsConsultant();
                //get the ConsultantNo
                AConsultant.ConsultantNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsultantNo"]);
                //get the Consultant name 
                AConsultant.FirstName = DB.DataTable.Rows[Index]["FirstName"].ToString();
                //add the Consultant to the array list
                allConsultants.Add(AConsultant);
                //increment index
                Index++;
            }
        }

    }
}
