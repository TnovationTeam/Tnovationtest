using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNovationClassLibrary;
namespace TNovationProject
{
    public partial class ProjectList : Form
    {
        public ProjectList()
        {
            InitializeComponent();
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            //update the listbox
            DisplayProjects();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Archive this Project?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //this will delete the event from the list and archive it in the database
            }
            else if (result == DialogResult.No)
            {
                //this will cancel the request to archive
            }
            else
            {
                //
            }
            //this will direct to the event form in which the user can archive the event
            EventForm Form = new EventForm();
            Form.Show();
        }

        Int32 DisplayProjects()
        {

            //create an instance of the client collection
            clsProjectCollection Projects = new clsProjectCollection();
            //see the data source to the list of projects in the collection
            //listboxProject.DataSource = Projects.ProjectList;
            //set the name of the primary key value
            //listboxProject.ValueMember = "ProjectCode";
            //set the data field to be displayed
            //listboxProject.DisplayMember = "ProjectCode";
            //return the count of records in the list
            return Projects.Count;
        }
    }
}

