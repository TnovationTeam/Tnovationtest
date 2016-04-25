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
    public partial class AddCompanyList : Form
    {
        public AddCompanyList()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Add Client page when clicked on Add client button.
            new AddCompany().Show();
            this.Hide();
        }
    }
}
