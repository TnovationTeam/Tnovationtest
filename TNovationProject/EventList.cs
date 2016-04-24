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
    public partial class EventList : Form
    {    
        Int32 EventCode;

        public EventList()
        {
            InitializeComponent();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            //update the listbox
            DisplayEvents();
            this.Refresh();
        }
        private void buttonArchive_Click(object sender, EventArgs e)
        {
            if (listboxEvent.SelectedIndex != -1)
            {

                //get the primary key value of the record to delete 
               EventCode = Convert.ToInt32(listboxEvent.SelectedValue);
                DeleteEvent();
                //update the listbox
                DisplayEvents();
                new EventList().Show();
                this.Hide();
                this.Refresh();

            }
            else //if no record has been selected 
            {
                //display an error
                labelError.Text = "Please select a record to delete from the list";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            //redirect to the data entry page
            new EventForm().Show();
            this.Hide();
        }

        Int32 DisplayEvents()
        {

            //create an instance of the event collection
            clsEventCollection Events = new clsEventCollection();
            //see the data source to the list of events in the collection
            listboxEvent.DataSource = Events.EventList;
            //set the name of the primary key value
            listboxEvent.ValueMember = "EventCode";
            //set the data field to be displayed
            listboxEvent.DisplayMember = "EventCode";
            //return the count of records in the list
            return Events.Count;
        }

        private void listBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
            DisplayEvents();
        }

        void DeleteEvent()
        {
            //function to delete the selected record

            //create a new instance of the event book
            clsEventCollection TNovation = new clsEventCollection();
            //find the record to delete 
            TNovation.ThisEvent.Find(EventCode);
            //delete the record
            TNovation.Delete();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            new EventForm().Show();
            this.Hide();
        }
       


        }


        }
    

