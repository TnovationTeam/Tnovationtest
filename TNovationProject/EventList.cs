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
        }
        private void buttonArchive_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Do you want to 'Archive' this event?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //this will delete the event from the list and archive it in the database
            }
            else if (result == DialogResult.No)
            {
                //this will cancel the request to archive
            }
            else
            {
                //
            } 
            //this will direct to the event form in which the user can archive the event
            EventForm Form = new EventForm();
            Form.Show();
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

       


        }


        }
    

