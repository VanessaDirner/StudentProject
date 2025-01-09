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
    public partial class DeleteDepartment : Form
    {


        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DeleteDepartment()
        {
            InitializeComponent();

            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_deletedept_Click(object sender, EventArgs e)
        {
            bool isvalid = true;

           string depttodelete = txt_deptname_todelete.Text;
            department departmentobject = _studentprojectEntities.departments.SingleOrDefault(x => x.deptname == depttodelete);

            if (depttodelete == null)
            {
                isvalid = false;
                MessageBox.Show("Department not found, please verify your entry.");
            }

            // if person is assigned to department, cannot delete department
            // if a department is in the assignments table, then it does have someone assigned to it
            assignment deptfoundinassignments = _studentprojectEntities.assignments.FirstOrDefault(x => x.deptID == departmentobject.deptID);
            if (deptfoundinassignments != null)
            {
                isvalid = false;
                MessageBox.Show("Department has one or more employees assigned to it. Please unassign employees before attempting to delete the department.");
            }


            if (isvalid)
            {
                try
                {
                    _studentprojectEntities.departments.Remove(departmentobject);

                    _studentprojectEntities.SaveChangesAsync();

                    MessageBox.Show("Department has been removed succesfully.");
                }
                catch
                {
                    MessageBox.Show("Department was not removed. Please check your request and try again later.");
                }



            }
        }

     
    }
}
