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
    public partial class ClientList : Form
    {
        //var to store the primary key value of the record to be deleted
        Int32 ClientNo;

        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Add Client page when clicked on Add client button.
            new AddClient().Show();
            this.Hide();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 ClientNo;
            //if a record has been selected from the list
            if (listboxClient.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete 
                ClientNo = Convert.ToInt32(listboxClient.SelectedValue);
                DeleteClient();
                

            }
            else //if no record has been selected 
            {
                //display an error
                labelError.Text = "Please select a record to delete from the list";
            }

            }


        void DeleteClient()
        {
            //function to delete the selected record
            
            //create a new instance of the client book
            clsClientCollection TNovation = new clsClientCollection();
            //find the record to delete 
            TNovation.ThisClient.Find(ClientNo);
            //delete the record
            TNovation.Delete();

        }
    }
}
