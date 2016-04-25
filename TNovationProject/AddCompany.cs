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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            //create an instance of TNovation
            clsCompanyCollection TNovation = new clsCompanyCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisCompany.Valid(textBoxCompanyAddress.Text, textBoxCompanyEmailAddress.Text, textBoxInvolvedClient.Text, textBoxInvolvedProject.Text, textBoxMobileNumber.Text, textBoxPhoneNumber.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //get the data entered by the user
                TNovation.ThisCompany.CompanyCode = Convert.ToInt32(textBoxCompanyCode.Text);
                TNovation.ThisCompany.CompanyAddress = textBoxCompanyAddress.Text;
                TNovation.ThisCompany.CompanyEmailAddress = textBoxCompanyEmailAddress.Text;
                TNovation.ThisCompany.InvolvedClient = textBoxInvolvedClient.Text;
                TNovation.ThisCompany.InvolvedProject = textBoxInvolvedProject.Text;
                TNovation.ThisCompany.MobileNumber = textBoxMobileNumber.Text;
                TNovation.ThisCompany.PhoneNumber = textBoxPhoneNumber.Text;
                //add the record
                TNovation.Add();
            }
        }

        private void AddCompany_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           //add new record
            Add();
            //This line of code navigates to the Client list page when clicked on add button.
            new CompanyList().Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
