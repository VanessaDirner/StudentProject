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

        public EmployeeForm()
        {
            InitializeComponent();
        }

        // store connection string?
        static private string GetConnectionString()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        // create sqlconnection object
        private static DataTable OpenSQLConnection(string connectionString)
        {
            DataTable dt = new DataTable();
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

                    while (!sdr.IsClosed)
                    {
                        // put contents of read into DataTable
                        dt.Load(sdr);
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error on read of db {ex.Message}");
                        connection.Close();
                    }
                    return dt;
            }
        }



        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            string s = GetConnectionString();

            DataTable dt =  OpenSQLConnection(s);

            // get employees from database from database object
            // var employees = _studentprojectEntities.employees.ToList();
            viewEmployees.DataSource = dt;

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