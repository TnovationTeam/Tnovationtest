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
    public partial class UpdateClient : Form
    {
        //var to store the primary key value of the record to be deleted
        Int32 ClientNo; 

        public UpdateClient()
        {
            InitializeComponent();
        }




        void UpdateUser()
        {
            //create an instance of TNovation
            clsClientCollection TNovation = new clsClientCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisClient.Valid(textboxClientName.Text, textboxClientEmail.Text, textboxClientAddress.Text, textboxClientPosition.Text, textboxClientQualification.Text, textboxClientTel.Text, textboxClientService.Text, textboxDate.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //find the record to update
                TNovation.ThisClient.Find(ClientNo);
                //get the data entered by the user
                TNovation.ThisClient.ClientNo = Convert.ToInt32(textboxClientNo.Text);
                TNovation.ThisClient.ClientName = textboxClientName.Text;
                TNovation.ThisClient.ClientEmail = textboxClientEmail.Text;
                TNovation.ThisClient.ClientAddress = textboxClientAddress.Text;
                TNovation.ThisClient.ClientPosition = textboxClientPosition.Text;
                TNovation.ThisClient.ClientQualification = textboxClientQualification.Text;
                TNovation.ThisClient.ClientTel = Convert.ToInt32(textboxClientTel.Text);
                TNovation.ThisClient.ClientService = textboxClientService.Text;
                TNovation.ThisClient.DateAdded = Convert.ToDateTime(textboxDate.Text);
                TNovation.ThisClient.Active = checkBoxActive.Checked;
                //update the record
                TNovation.Update();
            }
            else
            {
                //report an error 
                labelUpdateError.Text = "The ClientNo entered does not exist. Return to Client List box to find the ClientNo to update.";
            }


        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
                       
                //update new record
                UpdateUser();
                //show msg
                labelUpdateSuccess.Text = "The Client record has been updated";
            
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void textboxClientNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUpdateSuccess_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Client list page when clicked on cancel button.
            new ClientList().Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Client list page when clicked on cancel button.
            new ClientList().Show();
            this.Hide();
        }
    }
}
