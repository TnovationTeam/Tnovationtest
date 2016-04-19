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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //create an instance of TNovation
            clsProjectCollection TNovation = new clsProjectCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisProject.Valid(textBoxProjectName.Text, textBoxCompanyName.Text, textBoxProjectConsultant.Text, textBoxCompanyContact.Text, textBoxExpectedEndDate.Text, textBoxStartDate.Text, textBoxProjectLocation.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //get the data entered by the user
                TNovation.ThisProject.ProjectCode = Convert.ToInt32(textBoxProjectCode.Text);
                TNovation.ThisProject.ProjectName = textBoxProjectName.Text;
                TNovation.ThisProject.CompanyName = textBoxCompanyName.Text;
                TNovation.ThisProject.ProjectConsultant = textBoxProjectConsultant.Text;
                TNovation.ThisProject.CompanyContact = textBoxCompanyContact.Text;
                TNovation.ThisProject.ExpectedEndDate = Convert.ToDateTime(textBoxExpectedEndDate.Text);
                TNovation.ThisProject.StartDate = Convert.ToDateTime(textBoxStartDate.Text);
                TNovation.ThisProject.ProjectLocation = textBoxProjectLocation.Text;
                //add the record
                TNovation.Add();
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with the data entered";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
