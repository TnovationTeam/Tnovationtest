﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNovationClassLibrary;

namespace TNovationProject
{
    public partial class ClientList : Form
    {
        Int32 ClientNo;

        public ClientList()
        {
            InitializeComponent();
        }

        //this function handles the load event of the page
        private void ClientList_Load(object sender, EventArgs e)
        {
                //update the listbox
                DisplayClients();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Add Client page when clicked on Add client button.
            new AddClient().Show();
            this.Hide();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            
            //if a record has been selected from the list
            if (listboxClient.SelectedIndex != -1)
            {
                
                //get the primary key value of the record to delete 
                ClientNo = Convert.ToInt32(listboxClient.SelectedValue);
                DeleteClient();
                labelError.Text = "The record has been deleted";
                //update the listbox
                DisplayClients();
            }
            else //if no record has been selected 
            {
                //display an error
                labelError.Text = "Please select a record to delete from the list";
            }

            }


        void DeleteClient()
        {
            //function to delete the selected record
            
            //create a new instance of the client book
            clsClientCollection TNovation = new clsClientCollection();
            //find the record to delete 
            TNovation.ThisClient.Find(ClientNo);
            //delete the record
            TNovation.Delete();
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
                //This line of code navigates to the edit Client page when clicked on edit client button.
                new UpdateClient().Show();
                this.Hide();

           
            
        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
             //update the listbox
            DisplayClients();
        }
        
        Int32 DisplayClients()
        {

            //create an instance of the client collection
            clsClientCollection Clients = new clsClientCollection();
            //see the data source to the list of clients in the collection
            listboxClient.DataSource = Clients.ClientList;
            //set the name of the primary key value
            listboxClient.ValueMember = "ClientNo";
            //set the data field to be displayed
            listboxClient.DisplayMember = "ClientNo";
            //return the count of records in the list
            return Clients.Count;
        }

      


    }
}
