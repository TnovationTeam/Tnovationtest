using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsEvent
    {
        private Int32 eventCode;

        private string eventName;

        private string companyName;

        private string consultantAttending;

        private string contact;

        private DateTime startDate;

        private DateTime endDate;

        private  string guestSpeaker;

        private string location;

        private string typeOfEvent;




        public int EventCode
        {
            get
            {
                //return the private data
                return eventCode;
            }
            set
            {
                //set the value of the private data member
                eventCode = value;
            }
        }

        public string EventName
        {
            get
            {
                //return the private data
                return eventName;

            }
            set
            {
                //set the value of the private data member
                eventName = value;
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

        public string ConsultantAttending
        {
            get
            {
                //return the private data
                return consultantAttending;
            }
            set
            {
                //set the value of the private data member
                consultantAttending = value;
            }
        }

        public string Contact
        {
            get
            {
                //return the private data
                return contact;
            }
            set
            {
                //set the value of the private data member
                contact = value;
            }
        }


        public DateTime EndDate 
        { 
            get
            {
                //return the private data
                return endDate;
            }
            set
            {
                //set the value of the private data member
                endDate = value;
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

        public string GuestSpeaker 
        { 
            get
            {
                //return the private data
                return guestSpeaker;
            }
            set
            {
                //setr the value of the private data member
                guestSpeaker = value;
            }
        }

        public string Location 
        { 
            get

            {
                //return the private data
                return location;
            }
            set
            {
                //set the value of the private data member
                location = value;
            }
        }


        public string TypeOfEvent
        {
            get
            {
                //return the private data
                return typeOfEvent;
            }

            set
            {
                //set the value of the private data member
                typeOfEvent = value;
            }
        }


       

        public bool Find(int EventCode)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the event code to search for
            DB.AddParameter("EventCode", EventCode);
            //execute the stored procedure
            DB.Execute("sproc_tblEvent_FilterByEventCode");
            //if one record is found ,there should be either one or zero!
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                eventCode = Convert.ToInt32(DB.DataTable.Rows[0]["EventCode"]);
                eventName = Convert.ToString(DB.DataTable.Rows[0]["EventName"]);
                companyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                contact = Convert.ToString(DB.DataTable.Rows[0]["Contact"]);
                endDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EndDate"]);
                startDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                guestSpeaker = Convert.ToString(DB.DataTable.Rows[0]["GuestSpeaker"]);
                location = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                typeOfEvent = Convert.ToString(DB.DataTable.Rows[0]["TypeOfEvent"]);
                consultantAttending = Convert.ToString(DB.DataTable.Rows[0]["ConsultantAttending"]); 
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

        public bool Valid(string EventName, string CompanyName, string Contact, string EndDate, string StartDate, string GuestSpeaker, string Location, string TypeOfEvent, string ConsultantAttending)
        {
            Boolean OK = true;
            DateTime SomeDate;
            if (Location.Length == 0)
            {
                OK = false;
            }

            if (Location.Length > 30)
            {
                OK = false;
            }

            if (ConsultantAttending.Length == 0)
            {
                OK = false;
            }

            if (ConsultantAttending.Length > 30)
            {
                OK = false;
            }
            if (Contact.Length > 12)
            {
                OK = false;
            }

            if(Contact.Length < 9)
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
    
  

