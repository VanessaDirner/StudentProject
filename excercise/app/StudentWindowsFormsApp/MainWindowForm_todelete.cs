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
    public partial class MainWindowForm_todelete : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainWindowForm_todelete()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            // TODO check if form already open
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.MdiParent = this;
            employeeForm.Show();           
        }

        private void assignmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // TODO  check if form already open
            AssignmentsForm assignemntsForm = new AssignmentsForm();
            assignemntsForm.MdiParent = this;
            assignemntsForm.Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO  check if form already open
            DepartmentsForm departmentsForm = new DepartmentsForm();
            departmentsForm.MdiParent = this;
            departmentsForm.Show();
        }
    }
}
