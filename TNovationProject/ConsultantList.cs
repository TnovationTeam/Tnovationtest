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
            // TODO: This line of code loads data into the 'tNovationDataSetTIMING.tblConsultant' table. You can move, or remove it, as needed.
            this.tblConsultantTableAdapter2.Fill(this.tNovationDataSetTIMING.tblConsultant);
            //update the listbox
            DisplayConsultants();
            this.Refresh();
           

        }

        void DeleteConsultant()
        {
            //function to delete the selected record

            //create a new instance of the client book
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


    }
}
