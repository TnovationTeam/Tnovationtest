using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNovationProject
{
    public partial class UpdateCompany : Form
    {
        public UpdateCompany()
        {
            InitializeComponent();
        }

        void UpdateUser()
        {
            //create an instance of TNovation
            clsCompanyCollection TNovation = new clsCompanyCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisCompany.Valid(textboxCompanyAddress.Text, textboxCompanyEmail.Text, textboxCompanyAddress.Text, textboxCompanyPosition.Text, textboxCompanyQualification.Text, textboxCompanyTel.Text, textboxCompanyService.Text, textboxDate.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //find the record to update
                //TNovation.ThisCompany.Find(CompanyCode);
                //get the data entered by the user
                TNovation.ThisCompany.CompanyCode = Convert.ToInt32(textboxCompanyCode.Text);
                TNovation.ThisCompany.CompanyAddress = textboxCompanyAddress.Text;
                TNovation.ThisCompany.CompanyEmailAddress = textboxCompanyEmailAddress.Text;
                TNovation.ThisCompany.CompanyPosition = textboxCompanyPosition.Text;
                TNovation.ThisCompany.CompanyQualification = textboxCompanyQualification.Text;
                TNovation.ThisCompany.CompanyTel = Convert.ToInt32(textboxCompanyTel.Text);
                TNovation.ThisCompany.CompanyService = textboxCompanyService.Text;
                TNovation.ThisCompany.DateAdded = Convert.ToDateTime(textboxDate.Text);
                TNovation.ThisCompany.Active = checkBoxActive.Checked;
                //update the record
                TNovation.Update();
            }
            else
            {
                //report an error 
                labelUpdateError.Text = "The CompanyCode entered does not exist. Return to Company List box to find the CompanyCode to update.";
            }


        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
