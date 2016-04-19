using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsProjectCollection
    {
        //private data member for the list
        List<clsProject> projectList = new List<clsProject>();
        //private data member thisProject
        clsProject thisProject = new clsProject();

        //public property for the Project list
        public List<clsProject> ProjectList
        {

            get
            {
                //return the private data 
                return projectList;
            }

            set
            {
                //set the private data
                projectList = value;

            }

        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list 
                return projectList.Count;
            }
            set
            {

            }
        }

        //public property for this project
        public clsProject ThisProject
        {

            get
            {
                //return the private data
                return thisProject;

            }

            set
            {
                //set the private data
                thisProject = value;
            }


        }

        //public constructor for the class
        public clsProjectCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProject_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsProject AProject = new clsProject();
                //read in the fields from the current record
                AProject.ProjectCode = Convert.ToInt32(DB.DataTable.Rows[Index]["ProjectCode"]);
                AProject.ProjectName = Convert.ToString(DB.DataTable.Rows[Index]["ProjectName"]);
                AProject.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["CompanyName"]);
                AProject.ProjectConsultant = Convert.ToString(DB.DataTable.Rows[Index]["ProjectConsultant"]);
                AProject.CompanyContact = Convert.ToString(DB.DataTable.Rows[Index]["CompanyContact"]);
                AProject.ExpectedEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpectedEndDate"]);
                AProject.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AProject.ProjectLocation = Convert.ToString(DB.DataTable.Rows[Index]["ProjectLocation"]);
                //add the record to the private data member
                projectList.Add(AProject);
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
            DB.AddParameter("@ProjectCode", thisProject.ProjectCode);
            DB.AddParameter("@ProjectName", thisProject.ProjectName);
            DB.AddParameter("@CompanyName", thisProject.CompanyName);
            DB.AddParameter("@ProjectConsultant", thisProject.ProjectConsultant);
            DB.AddParameter("@CompanyContact", thisProject.CompanyContact);
            DB.AddParameter("@ExpectedEndDate", thisProject.ExpectedEndDate);
            DB.AddParameter("@StartDate", thisProject.StartDate);
            DB.AddParameter("@ProjectLocation", thisProject.ProjectLocation);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProject_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisProject
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProjectCode", thisProject.ProjectCode);
            //execute the stored procedure
            DB.Execute("sproc_tblProject_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisaddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProjectCode", thisProject.ProjectCode);
            DB.AddParameter("@ProjectName", thisProject.ProjectName);
            DB.AddParameter("@CompanyName", thisProject.CompanyName);
            DB.AddParameter("@ProjectConsultant", thisProject.ProjectConsultant);
            DB.AddParameter("@CompanyContact", thisProject.CompanyContact);
            DB.AddParameter("@ExpectedEndDate", thisProject.ExpectedEndDate);
            DB.AddParameter("@StartDate", thisProject.StartDate);
            DB.AddParameter("@ProjectLocation", thisProject.ProjectLocation);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblProject_Update");
        }
    }
}