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
        Int32 ProjectCode;

        public ProjectList()
        {
            InitializeComponent();
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            //update the listbox
            DisplayProjects();
        }

        void DeleteProject()
        {
            //function to delete the selected record

            //create a new instance of the project book
            clsProjectCollection TNovation = new clsProjectCollection();
            //find the record to delete 
            TNovation.ThisProject.Find(ProjectCode);
            //delete the record
            TNovation.Delete();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the edit project page when clicked on edit project button.
            new UpdateProject().Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddProject().Show();
            this.Hide();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Archive this Project?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //if a record has been selected from the list
                if (listboxProjects.SelectedIndex != -1)
                {

                    //get the primary key value of the record to delete 
                    ProjectCode = Convert.ToInt32(listboxProjects.SelectedValue);
                    DeleteProject();
                    //update the listbox
                    DisplayProjects();
                    new ProjectList().Show();
                    this.Hide();
                    this.Refresh();

                }
                else //if no record has been selected 
                {
                    //display an error
                    labelError.Text = "Please select a record to delete from the list";
                }
            }
            else if (result == DialogResult.No)
            {
                //this will cancel the request to archive
            }
            else
            {
                //
            }
        }

        private void ProjectList_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetcompleted.tblProject' table. You can move, or remove it, as needed.
            this.tblProjectTableAdapter3.Fill(this.tNovationDataSetcompleted.tblProject);
            // TODO: This line of code loads data into the 'tNovationDataSetTIMING.tblProject' table. You can move, or remove it, as needed.
            this.tblProjectTableAdapter2.Fill(this.tNovationDataSetTIMING.tblProject);
        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
            //update the listbox
            DisplayProjects();
        }

        Int32 DisplayProjects()
        {

            //create an instance of the project collection
            clsProjectCollection Projects = new clsProjectCollection();
            //see the data source to the list of projects in the collection
            listboxProjects.DataSource = Projects.ProjectList;
            //set the name of the primary key value
            listboxProjects.ValueMember = "ProjectCode";
            //set the data field to be displayed
            listboxProjects.DisplayMember = "ProjectName";
            //return the count of records in the list
            return Projects.Count;
        }
    }
}

