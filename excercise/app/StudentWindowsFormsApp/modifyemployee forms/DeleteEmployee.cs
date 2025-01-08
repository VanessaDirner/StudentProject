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
    public partial class DeleteEmployee : Form
    {


        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DeleteEmployee()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_deleteemployee_Click(object sender, EventArgs e)
        {
           bool isvalid = true;

            // find employee by email given from form
            employee employeeobject =  _studentprojectEntities.employees.SingleOrDefault(delemp => delemp.email == txtbox_empemail_todelete.Text);


            // empty result when searching for account
            if (employeeobject == null)
            {
                isvalid = false;
                MessageBox.Show("No account with that email address was found. Please double check and resubmit request.");
            }

            // check if employee is assigned to a department
            assignment existingassignment =  _studentprojectEntities.assignments.SingleOrDefault(assign => assign.personID == employeeobject.personID);

            if (existingassignment != null)
            {
                isvalid = false;
                MessageBox.Show("Employee is assigned to a department. Please remove the assignment before deleting employee.");
            }

            if (isvalid)
            {
                try
                {
                    // delete account
                    _studentprojectEntities.employees.Remove(employeeobject);

                    _studentprojectEntities.SaveChangesAsync();

                    MessageBox.Show("Employee removed.");
                }
                catch
                {
                    MessageBox.Show("Employee not removed. Please check the details entered and try again.");
                }
            }
   
        }
    }
}
