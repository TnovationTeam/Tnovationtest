﻿using System;
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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //add new record
            Add();
            new ListEvent().Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //This line of code navigates to listEvent form
            new ListEvent().Show();
            this.Hide();
        }

        void Add()
        {
            //create an instance of TNovation
            clsEventCollection TNovation = new clsEventCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisEvent.Valid(textBoxEventName.Text, textBoxCompanyName.Text,textBoxContact.Text, textBoxStartDate.Text, textBoxGuestSpeaker.Text, textBoxLocation.Text, textBoxTypeOfEvent.Text, textBoxConsultantAttending.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //get the data entered by the user
                TNovation.ThisEvent.EventCode = Convert.ToInt32(textBoxEventCode.Text);
                TNovation.ThisEvent.EventName = textBoxEventName.Text;
                TNovation.ThisEvent.CompanyName = textBoxCompanyName.Text;
               
                TNovation.ThisEvent.Contact = textBoxContact.Text;
                TNovation.ThisEvent.StartDate = Convert.ToDateTime(textBoxStartDate.Text);
                TNovation.ThisEvent.GuestSpeaker = textBoxGuestSpeaker.Text;
                TNovation.ThisEvent.Location = textBoxLocation.Text;
                TNovation.ThisEvent.TypeOfEvent = textBoxTypeOfEvent.Text;
                TNovation.ThisEvent.ConsultantAttending = textBoxConsultantAttending.Text;
                //add the record
                TNovation.Add();
            }
            else
            {
                //report an error 
               // lblError.Text = "There were problems with the data entered";
            }




        }
    }
}
