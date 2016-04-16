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




        void Update()
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
                TNovation.ThisClient.ClientName = textboxClientName.Text;
                TNovation.ThisClient.ClientEmail = textboxClientEmail.Text;
                TNovation.ThisClient.ClientAddress = textboxClientAddress.Text;
                TNovation.ThisClient.ClientPosition = textboxClientNo.Text;
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
            //add new record
            Update();
            //all done so redirect back to the client list form 
            //Response.Redirect("ClientList.cs");
            labelUpdateSuccess.Text = "The Client record has been updated";
        }
    }
}
