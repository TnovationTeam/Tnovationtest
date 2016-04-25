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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonConsultant_Click(object sender, EventArgs e)
        {
            new ConsultantList().Show();
            
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            new ListEvent().Show();
           
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            new ClientList().Show();
            
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            new CompanyList().Show();
            
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {

            new ProjectList().Show();
            

        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

      
    }
}
