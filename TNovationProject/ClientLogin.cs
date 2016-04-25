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
    public partial class ClientLogin : Form
    {
        public ClientLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the  Client loginpage when clicked on Add client button.
            new ClientList().Show();
            this.Hide();
        }
    }
}
