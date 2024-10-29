using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using StudentWindowsFormsApp.Models;

namespace StudentWindowsFormsApp
{
    public partial class AssignmentsForm : Form
    {
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public AssignmentsForm()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void AssignemntsForm_Load(object sender, EventArgs e)
        {
            var employeestable = _studentprojectEntities.employees;
            var assignmenttable = _studentprojectEntities.assignments;
            var departmentstable = _studentprojectEntities.departments;

            var allassignments = (from employee in _studentprojectEntities.employees
                                  join assignment in _studentprojectEntities.assignments
                                  on employee.personID equals assignment.personID
                                  // join department in _ on equals
                                  select new { employee.email }).ToList();


            var assignments = _studentprojectEntities.assignments.Select(assignment => new
            {
                assignment.assignmentID,
                employeeid = assignment.personID,
                departmentid = assignment.deptID,
                datecreated = assignment.createdate,
                assignment.modifieddate,
                assignment.createdby,
                assignment.modifiedby
            }).ToList();

            viewAssignments.DataSource = assignments;

            //viewAssignments.DataSource = allassignments;

            /*
            equivalent database query to get details
            select employee.email, employee.firstname, employee.lastname, department.deptname, department.abbreviation
            from employee
            join assignment
            on employee.personID = assignment.personID
            join department
            on department.deptID = assignment.deptID;
           */
        }

        private async void btn_assign_submit_Click(object sender, EventArgs e)
        {
            // set defaults for some variables for checking form
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


            }


        }




        private async void Delete()
        {
           

            // find dept ID based on dept name
            var deptname = txt_assign_deptname.Text;
            department department = await _studentprojectEntities.departments.FindAsync(deptname);

            // find employee id based on email
            var employee_email = txt_assign_email.Text;
            employee employee = await _studentprojectEntities.employees.FindAsync(employee_email);

            // find assignment id based on employee and dept id
            var assignmentid = await _studentprojectEntities.assignments.FindAsync();
         
            /*

            assignment assignment = await _studentprojectEntities.assignments.Where(x => _ == employee.personID .);

            if (assignment == null)
            {
                throw new Exception("invalid assignment ID");
            }
            
            _studentprojectEntities.assignments.Remove(assignment);

            await _studentprojectEntities.SaveChangesAsync();
            */
        }



    }

}