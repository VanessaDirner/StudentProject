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
                department department =  _studentprojectEntities.departments.SingleOrDefault(s => s.deptname == deptname);

                // find employee id based on email
                var employee_email = txt_empassign_todelete.Text;
                employee employee =  _studentprojectEntities.employees.SingleOrDefault(s => s.email == employee_email);

                // find assignment id based on employee and dept id
                var assignmentid =  _studentprojectEntities.assignments.Find();

                // find assignment base on person id ?? // when to use a .where ?
                assignment assignment =  _studentprojectEntities.assignments.SingleOrDefault(x => x.personID == employee.personID);
                
                if (assignment == null)
                {
                    throw new Exception("invalid assignment ID");
                }

                if (isvalid)
                {
                    try
                    {
                        _studentprojectEntities.assignments.Remove(assignment);

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
