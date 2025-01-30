using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentWindowsFormsApp
{
    public partial class AddEmployee : Form
    {

        // database object
        private readonly studentprojectEntities _studentprojectEntities;
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=studentproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";


        public AddEmployee()
        {
            InitializeComponent();
            // initialize the database object
            _studentprojectEntities = new studentprojectEntities();
        }

        private void AddEmployeetoDB(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              
                    connection.Open();
                    string query = "addemployee";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                        command.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                        command.Parameters.AddWithValue("@email", txt_email.Text);
                        command.Parameters.AddWithValue("@phonenumber", txt_phonenum.Text);
                        command.Parameters.AddWithValue("@startdate", dateTime_startdate.Value);
                        command.Parameters.AddWithValue("@enddate", dateTime_enddate.Value);
                        command.Parameters.AddWithValue("@activate", chkbox_activate.Checked);
                        command.Parameters.AddWithValue("@createdby", "admin");
                        command.Parameters.AddWithValue("@createdate", DateTime.Now);

                        command.ExecuteNonQuery();

                    }
              
            }
    }

        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {

            // process form
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            int phonenumber = int.Parse(txt_phonenum.Text);
            DateTime startdate = dateTime_startdate.Value;
            DateTime enddate = dateTime_enddate.Value;
            bool activate = chkbox_activate.Checked;

            //verify details from form before saving details

            // check if any fields are null
            // (except for any fields with defaults or non required fields)
            if ((string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(lastname) ||
                string.IsNullOrWhiteSpace(email)) ||
                startdate > enddate
                )
            {
                isvalid = false;
                MessageBox.Show("Required fields are empty." +
                    "Please double check and resubmit request.");
            }



            // if form filled out ok, process form and show confirmation of save
            if (isvalid)
            {
                
                try
                {
                    AddEmployeetoDB(connectionString);
                    // show confirmation of adding employee
                    MessageBox.Show($"Employee creation successful.\n\r" +
                        $"first name: {firstname} \n\r" +
                        $"last name: {lastname} \n\r" +
                        $"email: {email} \n\r" +
                        $"start date: {startdate}\n\r " +
                        $"end date: {enddate} \n\r" +
                        $"account activated: {activate} \n\r");

                    //TODO  reload datagrid with updated info

                }
                catch
                {
                    // if save is unsuccesful, show failure message
                    MessageBox.Show($"Employee creation unsuccesful.\n\r" +
                        $"Please modify your request and try again," +
                        $" or contact an administrator.");
                }

                //TODO reload datagrid


                //trying Taekwan's code
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        string query = $"FindEmployee";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                           
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@email", email);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show($"Found employee: {reader["firstname"]}. Full details of employee: {reader["email"]},{reader["lastname"]}");
                                }
                                else
                                {
                                    MessageBox.Show("Person not found!");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database connection failed: " + ex.Message);
                    }
                }


            }
        }
    }
}
