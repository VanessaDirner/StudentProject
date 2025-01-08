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

       

                // find dept ID based on dept name
                var deptname = txt_deptname_todelete.Text;
                department department =  _studentprojectEntities.departments.Find(deptname);

                // find employee id based on email
                var employee_email = txt_empassign_todelete.Text;
                employee employee =  _studentprojectEntities.employees.Find(employee_email);

                // find assignment id based on employee and dept id
                var assignmentid =  _studentprojectEntities.assignments.Find();


                assignment assignment =  _studentprojectEntities.assignments.Where(x => _ == employee.personID .);

                if (assignment == null)
                {
                    throw new Exception("invalid assignment ID");
                }

                _studentprojectEntities.assignments.Remove(assignment);

                 _studentprojectEntities.SaveChangesAsync();

          


        }


    }
}
