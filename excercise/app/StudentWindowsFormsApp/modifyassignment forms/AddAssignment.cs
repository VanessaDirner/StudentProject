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
 

        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public AddAssignment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }




        private void btn_addassignment_Click(object sender, EventArgs e)
        {
             // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables

            string employeemail = txt_emp_email.Text;
            string departmentname = txt_deptname_toassign.Text;

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
                department departmentobject =  _studentprojectEntities.departments.SingleOrDefault(dept => dept.deptname == departmentname);
                // throw exception so that ID can't be invalid so that return employee can't be null
                if (departmentobject == null)
                {
                    throw new Exception("invalid department to assign to");

                }

                // check that employee exists and get ID
                employee employee =  _studentprojectEntities.employees.SingleOrDefault(emp => emp.email == employeemail);
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


                List<assignment> doesassignmentexist =  (from row in _studentprojectEntities.assignments
                                                              where row.personID.Equals(personID)
                                                              && row.deptID == deptID
                                                              select row).ToList();


                // if we get a column back then there's already an assignment
                bool isempty = !doesassignmentexist.Any();

                if ((isempty))
                {
                    Console.WriteLine($"{doesassignmentexist} is null ");

                    assignment createassignmentobject = new assignment();

                    createassignmentobject.assignmentID = Guid.NewGuid();
                    createassignmentobject.personID = personID;
                    createassignmentobject.deptID = deptID;
                    createassignmentobject.createdby = "admin";
                    createassignmentobject.modifiedby = "admin";
                    createassignmentobject.createdate = DateTime.Now;
                    createassignmentobject.modifieddate = DateTime.Now;

                    _studentprojectEntities.assignments.Add(createassignmentobject);

                    try
                    {
                        // save changes to database
                        _studentprojectEntities.SaveChangesAsync();

                        // show confirmation of adding employee
                        MessageBox.Show($"Assignment creation successful.\n\r" +
                            $"Department Name: {departmentname} \n\r" +
                            $"Employee Email: {employeemail} \n\r" +
                            $"Date Created: {createassignmentobject.createdate} \n\r" +
                            $"Created by: {createassignmentobject.createdby} \n\r");
                    }
                    catch
                    {
                        MessageBox.Show($"Assignment creation unsuccessful. \n\r Please check your input and try again.");
                    }




                }
                else {
                    MessageBox.Show($"Assignment creation unsuccessful. \n\r Employee is already assigned to this department, check for assignment " );
                    
                }
                    

             
             
        }



        }
    }
}


