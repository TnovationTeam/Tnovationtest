using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Windows.Forms.Control.get;


namespace TNovationProject
{

    public partial class LogInConsultant : Form
    {
        public LogInConsultant()
        {
            InitializeComponent();
        }

        //Connection String
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TNovation.mdf;Integrated Security=True;";
        //btn_Submit Click event

        private void LogInConsultant_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from TblConsultantLogIn where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //make the form visible
            new ConsultantList().Show();
        }
    }
}
