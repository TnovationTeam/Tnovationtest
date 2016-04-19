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
    }
}

