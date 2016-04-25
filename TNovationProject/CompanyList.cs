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

namespace TNovationProject
{
    public partial class CompanyList : Form
    {
        Int32 CompanyCode;
        string searchString;
        public CompanyList()
        {
            InitializeComponent();
        }


        private void CompanyList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNovationDataSetFinalHandIN.tblClient' table. You can move, or remove it, as needed.
            this.tblCompanyTableAdapter.Fill(this.tNovationDataSetFinalHandIN.tblCompany);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //This line of code navigates to the Add Client page when clicked on Add client button.
            new AddCompany().Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            
            //if a record has been selected from the list
            if (listboxCompany.SelectedIndex != -1)
            {
                
                //get the primary key value of the record to delete 
                CompanyCode = Convert.ToInt32(listboxCompany.SelectedValue);
                DeleteCompany();
                //update the listbox
                DisplayCompanies();
                new CompanyList().Show();
                this.Hide();
                this.Refresh();
              
            }
            else //if no record has been selected 
            {
                //display an error
                labelError.Text = "Please select a record to delete from the list";
            }

            }

        void DeleteCompany()
        {
            //function to delete the selected record

            //create a new instance of the client book
            clsCompanyCollection TNovation = new clsCompanyCollection();
            //find the record to delete 
            TNovation.ThisCompany.Find(CompanyCode);
            //delete the record
            TNovation.Delete();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            //This line of code navigates to the edit Client page when clicked on edit client button.
            new UpdateCompany().Show();
            this.Hide();

           
        
        }

        private void buttonCompanyDet_Click(object sender, EventArgs e)
        {

            listboxCompany.ClearSelected();

            searchString = textBoxCompanyDet.Text;
            listboxCompany.SelectionMode = SelectionMode.MultiExtended;
            int x = -1;


            if (searchString.Length != 0)
            {
                do
                {

                    x = listboxCompany.FindString(searchString, x);
                    if (x != -1)
                    {

                        if (listboxCompany.SelectedIndices.Count > 0)
                        {
                            if (x == listboxCompany.SelectedIndices[0])
                                return;
                        }

                        listboxCompany.SetSelected(x, true);
                    }
                }
                while (x != -1);
            }
        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {

        }

        Int32 DisplayCompanies()
        {

            //create an instance of the client collection
            clsCompanyCollection Companies = new clsCompanyCollection();
            //see the data source to the list of clients in the collection
            listboxCompany.DataSource = Companies.CompanyList;
            //set the name of the primary key value
            listboxCompany.ValueMember = "CompanyCode";
            //set the data field to be displayed
            listboxCompany.DisplayMember = "CompanyAddress";
            //return the count of records in the list
            return Companies.Count;
        }
        }

    }
    
