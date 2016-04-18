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
    public partial class AddConsultant : Form
    {
        public AddConsultant()
        {
            InitializeComponent();
        }

        private void AddConsultant_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            //create an instance of TNovation
            clsConsultantCollection TNovation = new clsConsultantCollection();
            //this line of code validates the data on the webform
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
                //add the new entry
                TNovation.AddNew();
            }
       

        }


    }
}
