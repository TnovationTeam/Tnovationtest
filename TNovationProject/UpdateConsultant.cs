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
    public partial class UpdateConsultant : Form
    {
       // Int32 ConsultantNo;

        public UpdateConsultant()
        {
            InitializeComponent();
        }

        private void UpdateConsultant_Load(object sender, EventArgs e)
        {
            ////get the number of the consultant to be processed
            //ConsultantNo = Convert.ToInt32("ConsultantNo");
            ////Display consultants
            //DisplayTheConsultant();
            //if (ConsultantNo != -1)
            //{

            //    DisplayTheConsultant();
            //}
        }

        //void DisplayTheConsultant()
        //{

        //    //create an instance of Consultantslist
        //    clsConsultantCollection Consultantslist = new clsConsultantCollection();
        //    //find the record to update
        //    Consultantslist.ThisConsultant.Find(ConsultantNo);
        //    //display the data for this record
        //    textBoxNo.Text = Consultantslist.ThisConsultant.ConsultantNo.ToString();
        //    textBoxfirstName.Text = Consultantslist.ThisConsultant.FirstName;
        //    textBoxlastName.Text = Consultantslist.ThisConsultant.LastName;
        //    textBoxDOB.Text = Consultantslist.ThisConsultant.DateOfBirth.ToString();
        //    textBoxAddress.Text = Consultantslist.ThisConsultant.Address;
        //    textBoxEmail.Text = Consultantslist.ThisConsultant.Email;
        //    textBoxTelno.Text = Consultantslist.ThisConsultant.TelephoneNo;
        //    textBoxEmerg.Text = Consultantslist.ThisConsultant.EmergencyContact;
        //    textBoxDate.Text = Consultantslist.ThisConsultant.EmploymentDate.ToString();
        //    textBoxEhist.Text = Consultantslist.ThisConsultant.EmploymentHistory;
        //    textBoxDateAdded.Text = Consultantslist.ThisConsultant.DateAdded.ToString();


        //}

        void UpdateConsultants()
        {
            //create an instance of TNovation
            clsConsultantCollection TNovation = new clsConsultantCollection();
            //validate the data on the webform
            Boolean OK = TNovation.ThisConsultant.Valid(textBoxfirstName.Text, textBoxlastName.Text, textBoxAddress.Text, textBoxEmail.Text, textBoxEhist.Text, textBoxDOB.Text);
            //if the data is OK then add it to the object
            if (OK == true)
            {
                //get the data entered by the user
                TNovation.ThisConsultant.ConsultantNo = Convert.ToInt32(textBoxNo.Text);
                TNovation.ThisConsultant.FirstName = textBoxfirstName.Text;
                TNovation.ThisConsultant.LastName = textBoxlastName.Text;
                TNovation.ThisConsultant.DateOfBirth = Convert.ToDateTime(textBoxDOB.Text);
                TNovation.ThisConsultant.Address = textBoxAddress.Text;
                TNovation.ThisConsultant.Email = textBoxEmail.Text;
                TNovation.ThisConsultant.TelephoneNo = textBoxTelno.Text;
                TNovation.ThisConsultant.EmergencyContact = textBoxEmerg.Text;
                TNovation.ThisConsultant.EmploymentDate = Convert.ToDateTime(textBoxDate.Text);
                TNovation.ThisConsultant.HoursOfWork = Convert.ToInt32(textBoxHours.Text);
                TNovation.ThisConsultant.EmploymentHistory = textBoxEhist.Text;
                TNovation.ThisConsultant.DateAdded = Convert.ToDateTime(textBoxDateAdded.Text);

                //update the record
                TNovation.Update();
            }
            else
            {
                //report an error 
                labelErrorUpdate.Text = "The ConsultantNo entered is invalid";
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update new record
            UpdateConsultants();
            //show msg
            labelUpdated.Text = "The Consultant details have been updated";
            //This line of code navigates to the ConsultantList page when update button is clicked
            new ConsultantList().Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
