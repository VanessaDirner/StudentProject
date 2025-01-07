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
    public partial class DepartmentsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DepartmentsForm()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'studentprojectDataSet00000000layout.department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this.studentprojectDataSet00000000layout.department);
            // load database table and save to a variable, assign variable names to the data and create a list to hold it all
            // var department = _studentprojectEntities.departments.ToList();
            var department = _studentprojectEntities.departments.Select(items => new
            {
                DeptName = items.deptname,
                deptabbr = items.abbreviation,
                datecreated = items.createdate,
                datemodified = items.modifieddate,
                createdby = items.createdby,
                modifiedby = items.modifiedby
            }).ToList();


            // maybe todo resize grid for data, or change it's background


            // set the viewDepartments object's datasource to the variable we just created
           // viewDepartments.DataSource = department;
        }

        


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy(this.studentprojectDataSet00000000layout.department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // handle adding newrow to db using the grid iew, give default data
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            // ex. 
           // gridView1.SetRowCellValue(e.RowHandle, "modifieddate", DateTime.Now.Date);
        }

        private void btn_departments_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // open up add new dept popup
            var myadddeptform = new AddDepartment();
            myadddeptform.Show();


        }

        private void barbtn_deptedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // open up edit dept popup
        }

        private void barbtn_dept_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // open up delete dept popup

        }

        private void barBtn_frmdept_toempl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var employeesform = new EmployeeForm();
            employeesform.Show();
            this.Hide();
        }

        private void barBtn_frmdept_toreport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var assignmentsform = new AssignmentsForm();
            assignmentsform.Show();
            this.Hide();
        }

        // add handler to add or delete row on click
    }

}