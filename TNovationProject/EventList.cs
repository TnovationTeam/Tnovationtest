using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNovationProject
{
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Do you want to 'Archive' this event?", "Confirmation", MessageBoxButtons.YesNoCancel);
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
        }
    }
}
