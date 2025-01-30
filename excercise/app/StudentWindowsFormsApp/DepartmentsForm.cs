using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StudentWindowsFormsApp
{
    public partial class DepartmentsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public DepartmentsForm()
        {
            InitializeComponent();
        }


        // store connection string?
        static private string GetConnectionString()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        // create sqlconnection object
        private static DataTable OpenSQLConnection(string connectionString, string cmdtext)
        {
            DataTable dt = new DataTable();
            // create the sqlcommand object by passing the stored procedure name and connection object as parameters
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        // specifiy command type as stored procedure
                        CommandType = CommandType.Text,
                        Connection = connection,
                        CommandText = cmdtext
                    };

              
                    //open connection
                    connection.Open();

                    // execute the command - the sql query

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

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            string s = GetConnectionString();
            string query = "SELECT * FROM department;";

            DataTable dt = OpenSQLConnection(s, query);

            // get employees from database from database object
            // var employees = _studentprojectEntities.employees.ToList();
            


            // maybe todo resize grid for data, or change it's background


            // set the viewDepartments object's datasource to the variable we just created
            departmentgridcontrol.DataSource = dt;
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
            var editdeptform = new EditDepartment();
            editdeptform.Show();
        }

        private void barbtn_dept_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // open up delete dept popup
            var deletedeptform = new DeleteDepartment();
            deletedeptform.Show();
        }

        private void barBtn_frmdept_toempl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var employeesform = new EmployeeForm();
            employeesform.Show();
            this.Hide(); // switch to close somehow later? have to make sure new form doesn't close along with it
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