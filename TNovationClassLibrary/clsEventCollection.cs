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
                //increment index
                Index++;
            }
          }

       //   Int32 DisplayEvents()
     //     {
              //create an instance of the event class
       //       clsEvent AEvent = new clsEvent();
              //var to store the event primary key
     //         string EventCode;
              //var to store the name of the event
      //        string EventName;
      //        //var to store the index for the loop
      //        Int32 Index = 0;
              //while the index is less than the number of records to process
//while (Index < AEvent.Count)
      //        {
                  //get the event code from the database
        //          EventCode = Convert.ToString(AEvent.AllEvents[Index].EventCode);
                  //get the event name from the databse
         //         EventName = Convert.ToString(AEvent.AllEvents[Index].EventName);
                  //set up the new row to be added to the list
         //         ListItem NewEvent = new ListItem(EventCode, EventName);
                  //add the new row to the list
          //        ddlEvent.Items.Add(NewEvent);
                  //increment the index to the next record
          //        Index++;


       //       }
              //return the number of records found
       //       return AEvent.Count;


       //   }




 
    }
}
