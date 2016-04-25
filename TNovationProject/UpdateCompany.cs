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
    public partial class UpdateCompany : Form
    {
        //var to store the primary key value of the record to be deleted
        //Int32 ClientNo;

        public UpdateCompany()
        {
            InitializeComponent();
        }

        void UpdateUser()
        {
            //create an instance of TNovation
            clsCompanyCollection TNovation = new clsCompanyCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisCompany.Valid(textBoxCompanyAddress.Text, textBoxCompanyEmailAddress.Text, textBoxInvolvedClient.Text, textBoxInvolvedProject.Text, textBoxMobileNumber.Text, textBoxPhoneNumber.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //find the record to update
                //TNovation.ThisClient.Find(ClientNo);
                //get the data entered by the user
                TNovation.ThisCompany.CompanyCode = Convert.ToInt32(textBoxCompanyCode.Text);
                TNovation.ThisCompany.CompanyAddress = textBoxCompanyAddress.Text;
                TNovation.ThisCompany.CompanyEmailAddress = textBoxCompanyEmailAddress.Text;
                TNovation.ThisCompany.InvolvedClient = textBoxInvolvedClient.Text;
                TNovation.ThisCompany.InvolvedProject = textBoxInvolvedProject.Text;
                TNovation.ThisCompany.MobileNumber = textBoxMobileNumber.Text;
                TNovation.ThisCompany.PhoneNumber = textBoxPhoneNumber.Text;
                //update the record
                TNovation.Update();
            }
            else
            {
                //report an error 
                labelUpdateError.Text = "The CompanyCode entered does not exist. Return to Client List box to find the CompanyCode to update.";
            }


        }

        private void UpdateCompany_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update new record
            UpdateUser();
            //show msg
            labelUpdateSuccess.Text = "The Company record has been updated";
            //This line of code navigates to the Client list page when clicked on update button.
            new CompanyList().Show();
            this.Hide();
        }
    }
}
