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
    public partial class ConsultantList : Form
    {
        Int32 ConsultantNo;

        public ConsultantList()
        {
            InitializeComponent();
        }

        private void labelTnovation_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //This line of code will open the AddConsultant form
            new AddConsultant().Show();
            this.Hide();
        }

        private void ConsultantList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetcompleted.tblConsultant' table. You can move, or remove it, as needed.
            this.tblConsultantTableAdapter3.Fill(this.tNovationDataSetcompleted.tblConsultant);
            //update the listbox
            DisplayConsultants();
            this.Refresh();
           

        }

        void DeleteConsultant()
        {
            //function to delete the selected record

            //create a new instance of the Consultant book
            clsConsultantCollection TNovation = new clsConsultantCollection();
            //find the record to delete 
            TNovation.ThisConsultant.Find(ConsultantNo);
            //delete the record
            TNovation.Delete();

        }



        Int32 DisplayConsultants()
        {

            //create an instance of the Consultant collection class
            clsConsultantCollection Consultants = new clsConsultantCollection();
            //see the data source to the list of Consultants in the collection
            listBoxConsultant.DataSource = Consultants.ConsultantList;
            //set the name of the primary key value
            listBoxConsultant.ValueMember = "ConsultantNo";
            //set the data field to be displayed
            listBoxConsultant.DisplayMember = "FirstName";
            //return the count of records in the list
            return Consultants.Count;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            //if a record has been selected from the list
            if (listBoxConsultant.SelectedIndex != -1)
            {

                //get the primary key value of the record to delete 
                ConsultantNo = Convert.ToInt32(listBoxConsultant.SelectedValue);
                DeleteConsultant();
                //update the listbox
                DisplayConsultants();
                new ConsultantList().Show();
                this.Hide();
                this.Refresh();

            }
            else //if no record has been selected 
            {
                //display an error
                labelError.Text = "Please select a record to delete";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //This line of code takes the user to the form that updates the consultant
            new UpdateConsultant().Show();
            this.Hide();
        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
            //Update the listbox
            DisplayConsultants();
        }

        private void listBoxConsultant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
