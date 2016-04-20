using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TNovationClassLibrary;


namespace TNovationClassLibrary
{
    public class clsEventCollection
    {

        //private data member for the allEvents list
        private List<clsEvent> allEvents = new List<clsEvent>();

        //private data member thisEvent
        clsEvent thisEvent = new clsEvent();



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
                return allEvents.Count;
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
            //create an instance of the county class to store a county
             clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
             DB.Execute("sproc_tblEvent_SelectAll");
            //get the count of records
              Int32 RecordCount = DB.Count;
            //set up the index for the loop
              Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an isntance of the event class
                clsEvent AEvent = new clsEvent();
                //get the event code
                AEvent.EventCode = Convert.ToInt32(DB.DataTable.Rows[Index]["EventCode"]);
                //get the event name 
                AEvent.EventName = DB.DataTable.Rows[Index]["EventName"].ToString();
                //add the event to the array list
                allEvents.Add(AEvent);
                //increment index
                Index++;
            }
          }

    
        public int Add()
        {
            //adds a new record to the database based on the values of thisEvent
            //set the primary key value pof the new record
            thisEvent.EventCode = 1;
            //return the primary key of the new record
            return thisEvent.EventCode;
        }

 
    }
}
