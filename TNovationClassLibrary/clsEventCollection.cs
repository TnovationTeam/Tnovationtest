using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TNovationClassLibrary;


namespace TNovationClassLibrary
{
    public class clsEventCollection
    {
        //private data member for the list
        List<clsEvent> eventList = new List<clsEvent>();
        //private data member thisEvent
        clsEvent thisEvent = new clsEvent();
        //private data member for the allEvents list
        private List<clsEvent> allEvents = new List<clsEvent>();

       
        

         //public property for the client list
        public List<clsEvent> EventList
        {

            get
            {
                //return the private data 
                return eventList;
            }

            set
            {
                //set the private data
                eventList = value;

            }
        }
        //public property for ThisEvent
        public clsEvent ThisEvent
        {
            get
            {
                //return the private data
                return thisEvent;
            }
            set
            {
                //set the private data
                thisEvent = value;
            }
        }

        //public property for the count
        public int Count 
        { 
            get
            {
                //return the propety of the private list
                return eventList.Count;
            }
            
            set
            {
                //.....
            }
        }


        //public property for all events
          public List<clsEvent> AllEvents 
          {
              //getter sends the data to th erequesting code
              get
              {
                  //return the private data member
                  return allEvents;
              }
                  
                 //setter accepts the data from other objects 
              set
              {
                //assign the incomingvalue to the private data member
                  allEvents = value;
              }

          }


        //public constructor for the class
        public clsEventCollection()
          {
              Int32 Index = 0;
              //var to store the record count
              Int32 RecordCount = 0;
              //object for data connection
              clsDataConnection DB = new clsDataConnection();
              //execute the stored procedure
              DB.Execute("sproc_tblEvent_SelectAll");
              //get the count of records
              RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an isntance of the event class
                clsEvent AnEvent = new clsEvent();
                //get the event code
                AnEvent.EventCode = Convert.ToInt32(DB.DataTable.Rows[Index]["EventCode"]);
                //get the event name 
                AnEvent.EventName = Convert.ToString(DB.DataTable.Rows[Index]["EventName"]);
                //
                AnEvent.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["CompanyName"]);
                //
                AnEvent.ConsultantAttending = Convert.ToString(DB.DataTable.Rows[Index]["ConsultantAttending"]);
                //
                AnEvent.Contact = Convert.ToString(DB.DataTable.Rows[Index]["Contact"]);
                //
                AnEvent.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //
                AnEvent.GuestSpeaker = Convert.ToString(DB.DataTable.Rows[Index]["GuestSpeaker"]);
                //
                AnEvent.Location= Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                //
                AnEvent.TypeOfEvent = Convert.ToString(DB.DataTable.Rows[Index]["TypeOfEvent"]);
                //add the event to the array list
                eventList.Add(AnEvent);
                //increment index
                Index++;
            }
          }

    
        public int Add()
        {
            //adds a new record to the database based on the values of thisEvent
            //set the primary key value pof the new record
            clsDataConnection DB = new clsDataConnection();

           //set the parameters for the stored procedure
            DB.AddParameter("@EventCode", thisEvent.EventCode);
            DB.AddParameter("@EventName", thisEvent.EventName);
            DB.AddParameter("@CompanyName", thisEvent.CompanyName);
            DB.AddParameter("@ConsultantAttending", thisEvent.ConsultantAttending);
            DB.AddParameter("@Contact", thisEvent.Contact);
            DB.AddParameter("@StartDate", thisEvent.StartDate);
            DB.AddParameter("@GuestSpeaker", thisEvent.GuestSpeaker);
            DB.AddParameter("@Location", thisEvent.Location);
            DB.AddParameter("@TypeOfEvent", thisEvent.TypeOfEvent);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblEvent_Insert");
        }

 
    }
}
