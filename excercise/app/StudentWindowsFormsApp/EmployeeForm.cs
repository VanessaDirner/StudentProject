using Microsoft.Data.SqlClient;
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

        static private string GetConnectionString()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        private static void OpenSQLConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            string s = GetConnectionString();

            OpenSQLConnection(s);


            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.Add()
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

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

            viewEmployees.DataSource = cmd;

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