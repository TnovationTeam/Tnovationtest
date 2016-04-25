using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNovationClassLibrary;

namespace TNovationProject
{
    public partial class ListEvent : Form
    {
        Int32 EventCode;
        string searchString;
        public ListEvent()
        {
            InitializeComponent();
        }

        private void listBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetFinalHandIN.tblEvent' table. You can move, or remove it, as needed.
            this.tblEventTableAdapter.Fill(this.tNovationDataSetFinalHandIN.tblEvent);
            //update the listbox
            DisplayEvents();
            this.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddEvent().Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            new UpdateEvent().Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
              //if a record has been selected from the list
            if (listBoxEvent.SelectedIndex != -1)
            {
                
                //get the primary key value of the record to delete 
                EventCode = Convert.ToInt32(listBoxEvent.SelectedValue);
                DeleteEvent();
                //update the listbox
                DisplayEvents();
                new ListEvent().Show();
                this.Hide();
                this.Refresh();
              
            }
            else //if no record has been selected 
            {
                //display an error
               // labelError.Text = "Please select a record to delete from the list";
            }

            }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
            //update the listbox
            DisplayEvents();
        }
        

       


         void DeleteEvent()
        {
            //function to delete the selected record
            
            //create a new instance of the client book
            clsEventCollection TNovation = new clsEventCollection();
            //find the record to delete 
            TNovation.ThisEvent.Find(EventCode);
            //delete the record
            TNovation.Delete();
            
        }

        Int32 DisplayEvents()

        {
            //create an instance of the event collection
            clsEventCollection Events = new clsEventCollection();
            //see the data source to the list of eventin the collection
            listBoxEvent.DataSource =Events.EventList;
            //set the name of the primary key value
            listBoxEvent.ValueMember = "EventCode";
            //set the data field to be displayed
            listBoxEvent.DisplayMember = "EventName";
            //return the count of records in the list
            return Events.Count;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
             listBoxEvent.ClearSelected();

            searchString = textBoxSearch.Text;
            listBoxEvent.SelectionMode = SelectionMode.MultiExtended;
            int x = -1;
            

            if (searchString.Length != 0)
            {
                do
                {
                    
                    x =  listBoxEvent.FindString(searchString, x);
                    if (x != -1)
                    {
                        
                        if ( listBoxEvent.SelectedIndices.Count > 0)
                        {
                            if (x ==  listBoxEvent.SelectedIndices[0])
                                return;
                        }
                   
                         listBoxEvent.SetSelected(x, true);
                    }
                }
                while (x != -1);
            }
           
        }
        }
       




        }

        
    


    

