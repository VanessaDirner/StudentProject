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
    public partial class AddDepartment : Form
    {
       
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public AddDepartment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }


        // store connection string
        static private string GetConnectionString()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        // create sqlconnection object
        private static DataTable OpenSQLConnection(string connectionString, string command)
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
                        CommandType = CommandType.StoredProcedure,
                        Connection = connection,
                        CommandText = command // get text command from 
                    };

                    //open connection
                    connection.Open();

                     SqlParameter param = new SqlParameter
                     {
                            ParameterName = "@TableName", // parameter name defined in stored procedure
                            SqlDbType = SqlDbType.VarChar, // data type of parameter
                            Value = "Departments"
                     };
               


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



        private void btn_add_dept_submit_Click(object sender, EventArgs e)
        {

            // TODO handle creating department on click
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string DepartmentName = txt_deptName.Text; //.Text;
            string DepartmentAbbreviation = txt_deptabbrv.Text; // txtdeptabbr.Text;

            //verify details from form before saving details 

            // check if any fields are null
            // (except for any fields with defaults or non required fields)
            if ((string.IsNullOrWhiteSpace(DepartmentName) ||
                string.IsNullOrWhiteSpace(DepartmentAbbreviation)))
            {
                isvalid = false;
                MessageBox.Show("Required fields are empty." +
                    "Please double check and resubmit request.");
            }

            // if deptname or deptabbreviation is not empty (match found)
            // if departmentname or department abbreviation not unique, set valid to false, show message
            department doesdeptnameexist =  _studentprojectEntities.departments.SingleOrDefault(dept => dept.deptname == DepartmentName);
            string s = GetConnectionString();
            DataTable dtdoesdeptnameexist = OpenSQLConnection(s, DepartmentName);



            department doesdeptabbrexist = _studentprojectEntities.departments.SingleOrDefault(dept => dept.abbreviation == DepartmentAbbreviation);
            string a = GetConnectionString();
            DataTable dtdoesdeptabbrexist = OpenSQLConnection(s, DepartmentAbbreviation);


            if (dtdoesdeptnameexist != null && dtdoesdeptabbrexist != null) {
                if (DepartmentName == doesdeptnameexist.deptname)
                {
                    isvalid = false;
                    MessageBox.Show("DeptName already assigned to a department. Please pick a unique department name, or modify the existing department.");
                }
                if (DepartmentAbbreviation == doesdeptabbrexist.abbreviation)
                {
                    isvalid = false;
                    MessageBox.Show("Abbreviation already assigned to a department. Please pick a unique department abbreviation, or modify the existing department.");
                }
            }
          


            // if form filled out ok, process form and show confirmation of save
            if (isvalid)
            {

                // create employee object
                var department = new department();

                // assign variables from form to database object equivalents
                department.deptID = Guid.NewGuid();
                department.deptname = DepartmentName;
                department.abbreviation = DepartmentAbbreviation;
                department.createdate = DateTime.Now;
                department.modifieddate = DateTime.Now;
                department.createdby = "admin";
                department.modifiedby = "admin";

                // send details to database
                _studentprojectEntities.departments.Add(department);

                try
                {
                    // save changes to database
                    _studentprojectEntities.SaveChanges();

                    // show confirmation of adding employee
                    MessageBox.Show($"Department creation successful.\n\r" +
                        $"Department Name: {DepartmentName} \n\r" +
                        $"Department Abbreviation: {DepartmentAbbreviation} \n\r" +
                        $"Date Created: {department.createdate} \n\r" +
                        $"Created by: {department.createdby} \n\r");

                    

                    //TODO  reload datagrid with updated info



                }
                catch
                {
                    // if save is unsuccesful, show failure message
                    MessageBox.Show($"Department creation unsuccesful.\n\r" +
                        $"Please modify your request and try again," +
                        $" or contact an administrator.");
                }

            }
        }
    }
}

