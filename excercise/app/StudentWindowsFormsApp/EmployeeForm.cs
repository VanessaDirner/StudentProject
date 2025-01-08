using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class EmployeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // database object
        private readonly studentprojectEntities _studentprojectEntities;

        public EmployeeForm()
        {
            InitializeComponent();
            // initialize the database object
            _studentprojectEntities = new studentprojectEntities();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // get employees from database from database object
            // var employees = _studentprojectEntities.employees.ToList();
            var employees = _studentprojectEntities.employees.Select(item => new
            {
                firstname = item.firstname,
                lastname = item.lastname,
                email = item.email,
                startdate = item.startdate,
                enddate = item.enddate,
                createdby = item.createdby,
                modifiedby = item.modifiedby,
                phone = item.phonenumber,
                id = item.personID,
                active = item.active
            }).ToList();

            viewEmployees.DataSource = employees;

        }

     

        private void barBtn_fromemp_todept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var deptform = new DepartmentsForm();
            deptform.Show();
            this.Hide();
        }

        private void barBtn_frmemp_toreport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var reportform = new AssignmentsForm();
            reportform.Show();
            this.Hide();
        }

        private void barbtn_addemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addempform = new AddEmployee();
            addempform.Show();
          
        }

        private void barbtn_editemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editempform = new EditEmployee();
            editempform.Show();
        }

        private void barBtn_deleteemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var deldeptform = new DeleteEmployee();
            deldeptform.Show();
        }



        // action when form loads on page



    }
    
}