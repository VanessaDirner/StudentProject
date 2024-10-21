﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Scrolling;
using StudentWindowsFormsApp.Person;


namespace StudentWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add a xyz like person

            // call api here
            
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/assignment");
            var response =  client.SendAsync(request);
            
           /// response.EnsureSuccessStatusCode();
           // Console.WriteLine( response.Content.ReadAsStringAsync());
            
        }

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

        private void button1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
