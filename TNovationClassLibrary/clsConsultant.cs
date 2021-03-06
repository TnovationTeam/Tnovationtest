﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsConsultant
    {

        //private data member for the ConsultantNo property
        private Int32 consultantNo;
        //private data member for the Date of Birth property
        private DateTime dateOfBirth;
        //private data member for the Date of Birth property
        private DateTime dateAdded;
        //private data member for the Address property
        private string address;
        //private data member for the Email property
        private string email;
        //private data member for the Emergency contact property
        private string emergencyContact;
        //private data member for the Employment date property
        private DateTime employmentDate;
        //private data member for the hours of work property
        private int hoursOfWork;
        //private data member for the Name property
        private string firstName;
        //private data member for the Name property
        private string lastName;
        //private data member for the Status property
        private Boolean status;
        //private data member for the Telephone Number property
        private string telephoneNo;
        //private data member for the Employment History property
        private string employmentHistory;


        //public property for Address
        public string Address
        {
            get
            {
                //return the private data
                return address;
            }
            set
            {
                //set the private data
                address = value;
            }
        }

        //public property for ConsultantNo
        public int ConsultantNo
        {
            get
            {
                //return the private data
                return consultantNo;
            }
            set
            {
                //set the private data
                consultantNo = value;
            }
        }

        //public property for Date of birth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return dateOfBirth;
            }
            set
            {
                //set the private data
                dateOfBirth = value;
            }
        }

        //public property for Date Added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return dateAdded;
            }
            set
            {
                //set the private data
                dateAdded = value;
            }
        }

        //public property for Email
        public string Email
        {
            get
            {
                //return the private data
                return email;
            }
            set
            {
                //set the private data
                email = value;
            }
        }

        //public property Emergency contact
        public string EmergencyContact
        {
            get
            {
                //return the private data
                return emergencyContact;

            }
            set
            {
                //set the private data
                emergencyContact = value;
            }
        }

        //public property for Employment date
        public DateTime EmploymentDate
        {
            get
            {
                //return the private data
                return employmentDate;

            }
            set
            {
                //set the private data
                employmentDate = value;
            }
        }

        //public property for Hours of work
        public int HoursOfWork
        {
            get
            {
                //return the private data
                return hoursOfWork;

            }
            set
            {
                hoursOfWork = value;
            }
        }



        //public property for Name
        public string FirstName
        {
            get
            {
                //return the private data
                return firstName;

            }

            set
            {
                //set the private data
                firstName = value;
            }
        }

        //public property for Name
        public string LastName
        {
            get
            {
                //return the private data
                return lastName;

            }

            set
            {
                //set the private data
                lastName = value;
            }
        }

        //public property for Status
        public bool Status
        {
            get
            {
                //return the private data
                return status;

            }

            set
            {
                //set the private data
                status = value;
            }
        }

        //public property for Telephone No
        public string TelephoneNo
        {
            get
            {
                //return the private data
                return telephoneNo;

            }

            set
            {
                //set the private data
                telephoneNo = value;
            }
        }

        //public property for Employment History
        public string EmploymentHistory
        {
            get
            {
                //return the private data
                return employmentHistory;

            }

            set
            {
                //set the private data
                employmentHistory = value;
            }
        }



        public bool Find(int ConsultantNo)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the clientno to search for
            DB.AddParameter("ConsultantNo", ConsultantNo);
            //execute the stored procedure
            DB.Execute("sproc_tblConsultant_FilterByConsultantNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                consultantNo = Convert.ToInt32(DB.DataTable.Rows[0]["ConsultantNo"]);
                firstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                lastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                telephoneNo = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNo"]);
                emergencyContact = Convert.ToString(DB.DataTable.Rows[0]["EmergencyContact"]);
                employmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EmploymentDate"]);
                hoursOfWork = Convert.ToInt32(DB.DataTable.Rows[0]["HoursOfWork"]);
                employmentHistory = Convert.ToString(DB.DataTable.Rows[0]["EmploymentHistory"]);
                status = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                dateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
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






        public bool Valid(string FirstName, string LastName, string Address, string Email, string EmploymentHistory, string DateAdded)
        {
            //createa a Boolean variable to flag the error
            Boolean OK = true;
            //create a temp variable to store the date values
            DateTime DateTemp;
            //if the FirstName is blank
            if (FirstName.Length == 0)
            {
                //set the flag OK to false
                OK = false;


            }

            //if the FirstName is greater than 50 characters
            if (FirstName.Length == 50)
            {
                //set the flag OK to false
                OK = false;

            }

            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateOfBirth value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see ifthe date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;

                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;

                }
            }

            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }

            //is the lastname blank
            if (LastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;

            }

            //if the lastname is too long
            if (LastName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the address blank
            if (Address.Length == 0)
            {
                //set the flag OK to false
                OK = false;

            }

            //if the address is too long
            if (Address.Length > 60)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the email  3 characters or less
            if (Email.Length == 3)
            {
                //set the flag OK to false
                OK = false;

            }

            //if the email is too long
            if (Email.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the EmploymentHistory is 3 characters or more
            if (EmploymentHistory.Length == 3)
            {
                //set the flag OK to false
                OK = false;

            }

            //if the email is too long
            if (EmploymentHistory.Length > 150)
            {
                //set the flag OK to false
                OK = false;
            }


            //return the value of OK
            return OK;




        }

    }

}

