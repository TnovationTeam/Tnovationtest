﻿using System;
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


        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public string GuestSpeaker { get; set; }

        public string Location { get; set; }

        public string TypeOfEvent { get; set; }

        public bool Valid(string ConsultantAttending, string Contact, string EventName, string GuestSpeakers, string Location, string TypeOfEvent)
        {
            return true;
        }

        public bool Find(int EventCode)
        {
            return true;
        }
    }
}
