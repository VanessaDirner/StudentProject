using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevExpress.XtraGrid.Scrolling;


namespace StudentWindowsFormsApp
{
    public partial class EmployeeForm : Form
    {
        private readonly studentprojectEntities _studentprojectEntities;

        public EmployeeForm()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            DateTime startdate = dateTime_startdate.Value;
            DateTime enddate = dateTime_enddate.Value;
            bool activate = chkbox_activate.Checked;

            //verify details from form before saving details

            // check if any fields are null
            // (except for any fields with defaults or non required fields)
            if ((string.IsNullOrWhiteSpace(firstname) || 
                string.IsNullOrWhiteSpace(lastname) || 
                string.IsNullOrWhiteSpace(email)) ||
                startdate > enddate                
                )
                {
                    isvalid = false;
                    MessageBox.Show("Required fields are empty." +
                        "Please double check and resubmit request.");
                }
            
            

            // if form filled out ok, process form and show confirmation of save
            if (isvalid)
            {

                // create employee object
                var employee = new employee();

                // assign variables from form to database object equivalents
                employee.firstname = firstname;
                employee.lastname = lastname;  
                employee.email = email;
                employee.startdate = startdate; 
                employee.enddate = enddate;
                

                // send details to database
                _studentprojectEntities.employees.Add(employee);

                try
                {
                    // save changes to database
                    _studentprojectEntities.SaveChanges();

                    // show confirmation of adding employee
                    MessageBox.Show($"Employee creation successful.\n\r" +
                        $"first name: {firstname} \n\r" +
                        $"last name: {lastname} \n\r" +
                        $"email: {email} \n\r" +
                        $"start date: {startdate}\n\r " +
                        $"end date: {enddate} \n\r" +
                        $"account activated: {activate} \n\r");
                }
                catch 
                {
                    // if save is unsuccesful, show failure message
                    MessageBox.Show($"Employee creation unsuccesful.\n\r" +
                        $"Please modify your request and try again," +
                        $" or contact an administrator.");
                }

            }

            
        }

        // action when form loads on page
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // get employees from database from database object
            var employees = _studentprojectEntities.employees.ToList();
            viewEmployees.DataSource = employees;
            
        }

   
    }
    
}