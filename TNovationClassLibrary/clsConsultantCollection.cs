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
        //private data member for the list
        List<clsConsultant> consultantList = new List<clsConsultant>();

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

        //public list for AllConsultants
        public List<clsConsultant> ConsultantList
        {
            //the getter sends data to request code
            get
            {
                //return the private data member
                return consultantList;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                consultantList = value;
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
            DB.AddParameter("@Status", thisConsultant.Status);
            DB.AddParameter("@DateAdded", thisConsultant.DateAdded);
            //execute the stored procedure to insert data 
            return DB.Execute("sproc_tblConsultant_Insert");
        }

        //public constructor for the class
        public clsConsultantCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblConsultant_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Consultant
                clsConsultant AConsultant = new clsConsultant();
                //read in the fields from the current record
                AConsultant.ConsultantNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsultantNo"]);
                AConsultant.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AConsultant.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AConsultant.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AConsultant.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AConsultant.TelephoneNo = Convert.ToString(DB.DataTable.Rows[Index]["TelephoneNo"]);
                AConsultant.EmergencyContact = Convert.ToString(DB.DataTable.Rows[Index]["EmergencyContact"]);
                AConsultant.HoursOfWork = Convert.ToInt32(DB.DataTable.Rows[Index]["HoursOfWork"]);
                AConsultant.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AConsultant.EmploymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmploymentDate"]);
                AConsultant.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Status"]);
                AConsultant.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                //add the record to the private data member
                ConsultantList.Add(AConsultant);
                //point at the next record
                Index++;
            }

        }



        public void Delete()
        {
            //deletes the record pointed to by thisconsultant
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConsultantNo", thisConsultant.ConsultantNo);
            //execute the stored procedure
            DB.Execute("sproc_tblConsultant_Delete");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
