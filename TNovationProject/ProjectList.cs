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
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;

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
            DataGridViewProjects.DataSource = GetProjects();
            //update the listbox
            DisplayProjects();
            this.Refresh();

        }

        private DataTable GetProjects()
        {
            DataTable dtProjects = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["TNovationProject.Properties.Settings.TNovation"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblProject", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtProjects.Load(reader);
                }
            }

            return dtProjects;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

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
        }

        Int32 DisplayProjects()
        {
            return 1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void ProjectList_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetcompleted.tblProject' table. You can move, or remove it, as needed.
          
           
            
    

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

