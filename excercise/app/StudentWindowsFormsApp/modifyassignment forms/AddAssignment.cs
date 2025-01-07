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
    public partial class AddAssignment : Form
    {
        public AddAssignment()
        {
            InitializeComponent();
        }

        private void btn_addassignment_Click(object sender, EventArgs e)
        {

        }
    }
}



/*
        /// <summary>
        /// assign a person to a department
        /// </summary>
        private async void btn_assign_submit_Click(object sender, EventArgs e)
        {
            


            }


        }
 * // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables

            string employeemail = txt_assign_email.Text;
            string departmentname = txt_assign_deptname.Text;

            //verify details from form before saving details

            // check if any fields are null
            // (except for any fields with defaults or non required fields)
            if ((string.IsNullOrWhiteSpace(employeemail) ||
                string.IsNullOrWhiteSpace(departmentname)))
            {
                isvalid = false;
                MessageBox.Show("Required fields are empty." +
                    "Please double check and resubmit request.");
            }



            // if form filled out ok, process form and show confirmation of save
            if (isvalid)
            {
                // check that department exists and get ID
                department departmentobject = await _studentprojectEntities.departments.SingleOrDefaultAsync(dept => dept.deptname == departmentname);
                // throw exception so that ID can't be invalid so that return employee can't be null
                if (departmentobject == null)
                {
                    throw new Exception("invalid department to assign to");

                }

                // check that employee exists and get ID
                employee employee = await _studentprojectEntities.employees.SingleOrDefaultAsync(emp => emp.email == employeemail);
                // throw exception so that ID can't be invalid so that return employee can't be null
                if (employee == null)
                {
                    throw new Exception("invalid person to assign");
                }
                else if (employee.active == false) // inactive people should not be available for selection
                {
                    throw new Exception("Cannot assign an inactive employee to department");
                }

                // if the deptID and personID already exist in an assignment row, then this would be a duplicate request

                Guid deptID = departmentobject.deptID;
                Guid personID = employee.personID;


                // check for dept and person ID


                List<assignment> doesassignmentexist = await (from row in _studentprojectEntities.assignments
                                                              where row.personID.Equals(personID)
                                                              && row.deptID == deptID
                                                              select row).ToListAsync();


                // if we get a column back then there's already an assignment
                bool isempty = !doesassignmentexist.Any();

                if ((isempty))
                {
                    Console.WriteLine($"{doesassignmentexist} is null ");

                    assignment createassignmentobject = new assignment();


                    createassignmentobject.personID = personID;
                    createassignmentobject.deptID = deptID;
                    createassignmentobject.createdby = "admin";
                    createassignmentobject.modifiedby = "admin";
                    createassignmentobject.createdate = DateTime.Now;
                    createassignmentobject.modifieddate = DateTime.Now;

                    _studentprojectEntities.assignments.Add(createassignmentobject);

                    // save changes to database
                    await _studentprojectEntities.SaveChangesAsync();

                }
                else
                    throw new Exception("Employee is already assigned to this department, check for assignment ");


                //TODO reload datagrid
                */