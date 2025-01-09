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
namespace StudentWindowsFormsApp
{
    public partial class AssignmentsForm : DevExpress.XtraBars.Ribbon.RibbonForm
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

                                  join department in _studentprojectEntities.departments
                                  on assignment.deptID equals department.deptID

                                  select new { employee.email, employee.firstname, employee.lastname, department.abbreviation, department.deptname }).ToList();
          
           /*
           equivalent database query to get details
           select employee.email, employee.firstname, employee.lastname, department.deptname, department.abbreviation
           from employee
           join assignment
           on employee.personID = assignment.personID
           join department
           on department.deptID = assignment.deptID;
          */




            viewAssignments.DataSource = allassignments;
        }


        /// <summary>
        ///  swap to employee or department forms
        /// </summary>
        private void btn_frmassign_toemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var empform = new EmployeeForm();
            empform.Show();
            this.Hide();
        }

        private void btn_frmdassgn_todept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var deptform = new DepartmentsForm();
            deptform.Show();
            this.Hide();
        }

        /// <summary>
        /// open modify popup forms
        /// </summary>
        private void btn_addassignment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addassignmentform = new AddAssignment();
            addassignmentform.Show();
        }

        private void btn_editassignment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editassignmentform = new EditAssignment();
            editassignmentform.Show();
        }

        private void btn_deleteassignment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var deleteassignmentform = new DeleteAssignment();
            deleteassignmentform.Show();
        }







    }

}