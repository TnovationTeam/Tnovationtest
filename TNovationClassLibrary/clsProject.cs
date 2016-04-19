using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsProject
    {
        public int projectCode;

        public string projectName;

        public string companyName;

        public string projectConsultant;

        public string companyContact;

        public DateTime expectedEndDate;

        public DateTime startDate;

        public string projectLocation;

        public int ProjectCode
        {
            get
            {
                //return the private data
                return projectCode;
            }
            set
            {
                //set the value of the private data member
                projectCode = value;
            }
        }

        public string ProjectName
        {
            get
            {
                //return the private data
                return projectName;

            }
            set
            {
                //set the value of the private data member
                projectName = value;
            }
        }



        public string CompanyName
        {
            get
            {
                //return the private data
                return companyName;
            }
            set
            {
                //set the value of the private data member
                companyName = value;
            }

        }

        public string ProjectConsultant
        {
            get
            {
                //return the private data
                return projectConsultant;
            }
            set
            {
                //set the value of the private data member
                projectConsultant = value;
            }
        }

        public string CompanyContact
        {
            get
            {
                //return the private data
                return companyContact;
            }
            set
            {
                //set the value of the private data member
                companyContact = value;
            }
        }


        public DateTime ExpectedEndDate
        {
            get
            {
                //return the private data
                return expectedEndDate;
            }
            set
            {
                //set the value of the private data member
                expectedEndDate = value;
            }
        }


        public DateTime StartDate
        {
            get
            {
                //return the private data
                return startDate;
            }
            set
            {
                //set the value of the private data member
                startDate = value;
            }
        }

        public string ProjectLocation
        {
            get
            {
                //return the private data
                return projectLocation;
            }
            set
            {
                //setr the value of the private data member
                projectLocation = value;
            }
        }

        public bool Find(int ProjectCode)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the event code to search for
            DB.AddParameter("ProjectCode", ProjectCode);
            //execute the stored procedure
            DB.Execute("sproc_tblProject_FilterByProjectCode");
            //if one record is found ,there should be either one or zero!
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                ProjectCode = Convert.ToInt32(DB.DataTable.Rows[0]["ProjectCode"]);
                ProjectName = Convert.ToString(DB.DataTable.Rows[0]["ProjectName"]);
                CompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                ProjectConsultant = Convert.ToString(DB.DataTable.Rows[0]["ProjectConsultant"]);
                CompanyContact = Convert.ToString(DB.DataTable.Rows[0]["CompanyContact"]);
                ExpectedEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpectedEndDate"]);
                StartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                ProjectLocation = Convert.ToString(DB.DataTable.Rows[0]["ProjectLocation"]);
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

        public bool Valid(string ProjectName, string CompanyName, string CompanyContact, string ExpectedEndDate, string StartDate, string ProjectConsultant, string ProjectLocation)
        {
            Boolean OK = true;
            DateTime SomeDate;
            if (ProjectName.Length == 0)
            {
                OK = false;
            }

            if (ProjectLocation.Length > 30)
            {
                OK = false;
            }

            if (ProjectConsultant.Length == 0)
            {
                OK = false;
            }

            if (ProjectConsultant.Length > 30)
            {
                OK = false;
            }
            if (CompanyContact.Length > 12)
            {
                OK = false;
            }

            if (CompanyContact.Length < 9)
            {
                OK = false;

            }

            if (ProjectName.Length == 0)
            {
                OK = false;
            }

            if (ProjectName.Length > 30)
            {
                OK = false;
            }

            if (CompanyName.Length == 0)
            {
                OK = false;
            }

            if (CompanyName.Length > 30)
            {
                OK = false;
            }


            if (CompanyName.Length < 3)
            {
                OK = false;
            }

            try
            {
                SomeDate = Convert.ToDateTime(StartDate);

                if (SomeDate < DateTime.Now.Date)
                {
                    OK = false;
                }
                if (SomeDate > DateTime.Now.Date)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false; // returns flag ok

            }
            return OK;

        }
    }
}
