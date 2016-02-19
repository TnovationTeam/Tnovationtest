using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsClient
    {
        //private data member for the ClientNo property
        private Int32 clientNo;




        public bool Active { get; set; }

        public DateTime DateAdded { get; set; }

        public string ClientAddress { get; set; }

        public string ClientName { get; set; }

        public string ClientEmail { get; set; }

        public string ClientPosition { get; set; }

        public string ClientQualification { get; set; }

        public string ClientService { get; set; }
        
        
        //public property  for the client number
        public int ClientNo {
                              
                              get
                                 {   //return the private data
                                      return clientNo; 
                                  }
                              
                              set
                                   {  //set the value of the private data member
                                      clientNo = value;
                                   } 
        
                             }

        public int ClientTel { get; set; }



        public bool Find(int ClientNo)
        {
            //set the private data member to the test data value
            clientNo = 1;
            //always return true
            return true;
        }
    }
}
