using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultantClassLibrary
{
    public class clsConsultant
    {
        //private data member for the Address property
        private string address;
        //private data member for the ConsultantNo property
        private int consultantNo;
        //private data member for the Date of Birth property
        private DateTime dateOfBirth;
        //private data member for the Email property
        private string email;
        //private data member for the Emergency contact property
        private string emergencyContact;
        //private data member for the Employment date property
        private DateTime employmentDate;
        //private data member for the hours of work property
        private int hoursOfWork;
        //private data member for the Job description property
        private string jobDescription;
        //private data member for the Name property
        private string name;
        //private data member for the Status property
        private Boolean status;
        //private data member for the Telephone Number property
        private string telephoneNo;
        //private data member for the Work History property
        private string workHistory;



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

        //public property for Job description
        public string JobDescription
        {
            get
            {
                //return the private data
                return jobDescription;

            }

            set
            {
                //set the private data
                jobDescription = value;
            }
        }

        //public property for Name
        public string Name
        {
            get
            {
                //return the private data
                return name;

            }

            set
            {
                //set the private data
                name = value;
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

        //public property for Work History
        public string WorkHistory
        {
            get
            {
                //return the private data
                return workHistory;

            }

            set
            {
                //set the private data
                workHistory = value;
            }
        }

        public bool Find(int ConsultantNo)
        {
            throw new NotImplementedException();
        }
    }
}
