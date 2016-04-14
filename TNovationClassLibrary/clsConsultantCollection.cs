using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNovationClassLibrary
{
    public class clsConsultantCollection
    {
        //private data member for the allConsultants list
        private List<clsConsultant> allConsultants = new List<clsConsultant>();

        //public property for count
        public int Count 
        { 
            get
            {

                //return the count property of the private list
                return allConsultants.Count;
            }

            
            
set
            {
             
              //we will look at this later
            }
}

        //public list for AllConsultants
        public List<clsConsultant> AllConsultants
        {
            //the getter sends data to request code
            get
            {
                //return the private data member
                return allConsultants;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                allConsultants = value;
            }


        }

    }
}
