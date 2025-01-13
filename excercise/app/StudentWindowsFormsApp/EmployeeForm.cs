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

        // store connection string?
        static private string GetConnectionString()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        // create sqlconnection object
        private static void OpenSQLConnection(string connectionString)
        {
            // create the sqlcommand object by passing the stored procedure name and connection object as parameters
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SelectAllEmployees", connection)
                    {
                        // specifiy command type as stored procedure
                        CommandType = CommandType.StoredProcedure
                    };

                    //open connection
                    connection.Open();
                    Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                    Console.WriteLine("State: {0}", connection.State);

                    // execute the command - the stored procedure

                    //sqldatareader requires active and open connection
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                      
                        //
                        Console.WriteLine(sdr["PersonID"]);

                        // put contents of read into DataTable
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        //return dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error on read of db {ex.Message}");
                    connection.Close();
                }
             
            }
        }

       /* public DataTable GetEmployees(employee e)
        {
            DataTable employeeTable;

            return employeeTable;
        }*/

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            string s = GetConnectionString();

             OpenSQLConnection(s);

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