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
        public DeleteAssignment()
        {
            InitializeComponent();
        }

        private void btn_delassignment_Click(object sender, EventArgs e)
        {

        }


        /*

        /// <summary>
        ///  delete a person from a department
        /// </summary>
        private async void Delete()
        {

            /*

            // find dept ID based on dept name
            var deptname = txt_assign_deptname.Text;
            department department = await _studentprojectEntities.departments.FindAsync(deptname);

            // find employee id based on email
            var employee_email = txt_assign_email.Text;
            employee employee = await _studentprojectEntities.employees.FindAsync(employee_email);

            // find assignment id based on employee and dept id
            var assignmentid = await _studentprojectEntities.assignments.FindAsync();


            assignment assignment = await _studentprojectEntities.assignments.Where(x => _ == employee.personID .);

            if (assignment == null)
            {
                throw new Exception("invalid assignment ID");
            }

            _studentprojectEntities.assignments.Remove(assignment);

            await _studentprojectEntities.SaveChangesAsync();

        }*/


    }
}
