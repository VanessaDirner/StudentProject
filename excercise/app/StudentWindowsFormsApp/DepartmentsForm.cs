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
    public partial class DepartmentsForm : Form
    {
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DepartmentsForm()
        {
           InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btnDeptSubmit_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            // load database table and save to a variable, assign variable names to the data and create a list to hold it all
            // var department = _studentprojectEntities.departments.ToList();
            var department = _studentprojectEntities.departments.Select(items => new { DeptName = items.deptname, deptabbr = items.abbreviation }).ToList();
           
            // set the viewDepartments object's datasource to the variable we just created
            viewDepartments.DataSource = department;
        }
    }
}
