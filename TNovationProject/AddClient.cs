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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void labelHeading_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }



        void Add()
        {
            //create an instance of TNovation
            clsClientCollection TNovation = new clsClientCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisClient.Valid(textboxClientName.Text, textboxClientEmail.Text, textboxClientAddress.Text, textboxClientPosition.Text, textboxClientQualification.Text, textboxClientTel.Text, textboxClientService.Text, textboxDate.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
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
              //add the record
                TNovation.Add();
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with the data entered";
            }
       

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //add new record
            Add();
            lblError.Text = "The data record is entered to the database! Click back to return to the clients list page.";

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Client list page when clicked on cancel button.
            new ClientList().Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            //This line of code navigates to the Client list page when clicked on cancel button.
            new ClientList().Show();
            this.Hide();
        }








    }
}
