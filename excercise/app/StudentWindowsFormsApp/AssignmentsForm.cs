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
    public partial class AssignmentsForm : Form
    {
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public AssignmentsForm()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private async void AssignemntsForm_Load(object sender, EventArgs e)
        {
            // get assignment deptID and personID
            //  get person's email
            // get department name
            /*
            var assignments = _studentprojectEntities.assignments;
            var departments = _studentprojectEntities.departments;
            var employees = _studentprojectEntities.employees;

            var query = await(from assignment in assignments
                                            join assignments
                                            on employees.personID = assignments.personID
                                            //&& row.deptID == departments.deptID
                                            select assignment).ToListAsync();




            
             *  from department in departments
            join teacher in teachers on department.TeacherID equals teacher.ID
            
             * 
            List<assignment> doesassignmentexist = await  (from row in _database_context.assignments
                                         where row.personID.Equals(personID)
                                         && row.deptID == deptID
                                         select row).ToListAsync();
             * 
                select employee.email, employee.firstname, employee.lastname, department.deptname, department.abbreviation
                from employee
                join assignment
                on employee.personID = assignment.personID
                join department
                on department.deptID = assignment.deptID;

            var query = from student in students
            join department in departments on student.DepartmentID equals department.ID
            select new { Name = $"{student.FirstName} {student.LastName}", DepartmentName = department.Name };
            */
        }

        private void btn_assign_submit_Click(object sender, EventArgs e)
        {

        }\
    }
}
