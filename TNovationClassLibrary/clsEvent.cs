using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsEvent
    {
        public int EventCode { get; set; }

        public string EventName { get; set; }

        public string CompanyName { get; set; }

        public string ConsultantAttending { get; set; }

        public string Contact { get; set; }

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
