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
    public partial class CompanyList : Form
    {
        public CompanyList()
        {
            InitializeComponent();
        }

        private void CompanyList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetLATESTAPRIL.tblCompany' table. You can move, or remove it, as needed.
            this.tblCompanyTableAdapter1.Fill(this.tNovationDataSetLATESTAPRIL.tblCompany);
            // TODO: This line of code loads data into the 'tNovationDataSetFinalHandIN.tblCompany' table. You can move, or remove it, as needed.
            this.tblCompanyTableAdapter.Fill(this.tNovationDataSetFinalHandIN.tblCompany);

        }
    }
}
