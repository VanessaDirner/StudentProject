using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class EditEmployee : Form
    {


        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public EditEmployee()
        {
            InitializeComponent();

            _studentprojectEntities = new studentprojectEntities();
        }

        private void btnEmpEditSubmit_Click(object sender, EventArgs e)
        {

            // process form
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string firstname = txt_editfirstname.Text;
            string lastname = txt_editlastname.Text;
            string email = txt_editemail.Text;
            DateTime startdate = dateTime_editstartdate.Value;
            DateTime enddate = dateTime_editenddate.Value;
            bool activate = chkbox_editactivate.Checked;


            // todo get input from fields, use email to search for employee to edit

            var employeeobject =  _studentprojectEntities.employees.SingleOrDefault(emp => emp.email == email);

            // throw exception so that ID can't be invalid so that return employee can't be null
            if (email == null)
            {
                MessageBox.Show("Please provide email address and details to be modified when submitting request.");
            }
            else if (employeeobject == null)
            {
                MessageBox.Show("Email address is not associated with an account. Please supply the email address of the account to modify.");
            }
            //todo
            //map manually instead of with mapper 


            employeeobject.modifieddate = DateTime.Now;
            employeeobject.modifiedby = "admin";
            

            try
            {

                _studentprojectEntities.SaveChangesAsync();

                // show confirmation of adding employee
                MessageBox.Show($"Employee modification successful.\n\r" +
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
                MessageBox.Show($"Employee modification unsuccesful.\n\r" +
                    $"Please modify your request and try again," +
                    $" or contact an administrator.");
            }

        }
    }
}
