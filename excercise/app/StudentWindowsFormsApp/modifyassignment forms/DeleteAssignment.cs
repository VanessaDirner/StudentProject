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
    public partial class DeleteAssignment : Form
    {

        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();
        

        public DeleteAssignment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_delassignment_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            
            // find dept ID based on dept name
            var deptname = txt_deptname_todelete.Text;
            department department =  _studentprojectEntities.departments.FirstOrDefault(s => s.deptname == deptname);
            MessageBox.Show($"{department.deptID}");

            // find employee id based on email
            var employee_email = txt_empassign_todelete.Text;
            employee employee =  _studentprojectEntities.employees.FirstOrDefault(s => s.email == employee_email);
            MessageBox.Show($"{employee.personID}");

            // find assignment id based on employee and dept id
            assignment assignmentid =  _studentprojectEntities.assignments.Where(x => x.deptID == department.deptID && x.employee.personID == employee.personID).FirstOrDefault();
            MessageBox.Show($"{assignmentid}");
          
            if (assignmentid == null)
            {
                isvalid = false;
                MessageBox.Show("No assignment found of this employee to this department.");
            }

            if (isvalid)
            {
                try
                {
                    _studentprojectEntities.assignments.Remove(assignmentid);

                    _studentprojectEntities.SaveChangesAsync();

                    MessageBox.Show("Assignment deleted succesfully");
                }
                catch
                {
                    MessageBox.Show("Assignment not deleted. Please check the details and try again later");
                }
        }
              

        }


    }
}
