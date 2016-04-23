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
    public partial class UpdateProject : Form
    {
        public UpdateProject()
        {
            InitializeComponent();
        }

        void UpdateProjectConfirm()
        {
            //create an instance of TNovation
            clsProjectCollection TNovation = new clsProjectCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisProject.Valid(textBoxProjectName.Text, textBoxCompanyName.Text, textBoxProjectConsultant.Text, textBoxCompanyContact.Text, textBoxExpectedEndDate.Text, textBoxStartDate.Text, textBoxProjectLocation.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //find the record to update
                //TNovation.ThisProject.Find(ProjectCode);
                //get the data entered by the user
                TNovation.ThisProject.ProjectCode = Convert.ToInt32(textBoxProjectCode.Text);
                TNovation.ThisProject.ProjectName = textBoxProjectName.Text;
                TNovation.ThisProject.CompanyName = textBoxCompanyName.Text;
                TNovation.ThisProject.ProjectConsultant = textBoxProjectConsultant.Text;
                TNovation.ThisProject.CompanyContact = textBoxCompanyContact.Text;
                TNovation.ThisProject.ExpectedEndDate = Convert.ToDateTime(textBoxExpectedEndDate.Text);
                TNovation.ThisProject.StartDate = Convert.ToDateTime(textBoxStartDate.Text);
                TNovation.ThisProject.ProjectLocation = textBoxProjectLocation.Text;
                //update the record
                TNovation.Update();
            }
            else
            {
                //report an error 
                labelUpdateError.Text = "The ProjectCode entered does not exist. Return to Project List box to find the ProjectCode to update.";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            {
                //update new record
                UpdateProjectConfirm();
                //show msg
                labelUpdateSuccess.Text = "The Project record has been updated";
                //This line of code navigates to the Project list page when clicked on update button.
                new ProjectList().Show();
                this.Hide();

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
                //This line of code navigates to the Project list page when clicked on cancel button.
                new ProjectList().Show();
                this.Hide();
        }
    }
}
