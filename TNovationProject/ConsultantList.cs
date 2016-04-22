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
    public partial class ConsultantList : Form
    {
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

        }
    }
}
