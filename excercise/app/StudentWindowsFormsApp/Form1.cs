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
//using DevExpress.XtraGrid.Scrolling;
using StudentWindowsFormsApp.Person;


namespace StudentWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // refreshdata();
        }

        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
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
            if (isvalid == true)
            {
                // send details to database

                // save changes to database


                // show confirmation of adding employee
                MessageBox.Show($"Employee creation successful.\n\r" +
                    $"first name: {firstname} \n\r" +
                    $"last name: {lastname} \n\r" +
                    $"email: {email} \n\r" +
                    $"start date: {startdate}\n\r " +
                    $"end date: {enddate} \n\r" +
                    $"account activated: {activate} \n\r");
            }

            
        }
    }
    
}




        /*

   // on click add person

   // call api here to update the data

  // var client = new HttpClient();
   //var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/assignment");
   //var response =  client.SendAsync(request);

  /// response.EnsureSuccessStatusCode();
  // Console.WriteLine( response.Content.ReadAsStringAsync());


private void refreshdata()
{
   try
   {
       IEnumerable<PersonDTO> empobj = null;
       HttpClient hc = new HttpClient();
       hc.BaseAddress = new Uri("http://localhost:5110/api/");



       var consumeapi = hc.GetAsync("Person");
       consumeapi.Wait();

       var readdata = consumeapi.Result;

       if (readdata.IsSuccessStatusCode)
       {
           var displaydata = readdata.Content.ReadAsAsync<IList<PersonDTO>>();
           displaydata.Wait();

           empobj = displaydata.Result;

           gridControl1.DataSource = empobj;
           label1.Visible = false;
       }
   }
   catch
   {
       label1.Text = "Please check whether web api is running or not";
   }
}






*/