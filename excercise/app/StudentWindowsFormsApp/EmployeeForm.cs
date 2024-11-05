﻿using System;
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
            if (isvalid)
            {

                // create employee object
                var employee = new employee();

                // assign variables from form to database object equivalents
                employee.personID = Guid.NewGuid();
                employee.firstname = firstname;
                employee.lastname = lastname;  
                employee.email = email;
                employee.startdate = startdate; 
                employee.enddate = enddate;
                employee.createdate = DateTime.Now;
                employee.modifieddate = DateTime.Now;
                employee.createdby = "admin";
                employee.modifiedby = "admin";

                // send details to database
                _studentprojectEntities.employees.Add(employee);

                try
                {
                    // save changes to database
                    _studentprojectEntities.SaveChanges();

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


            }

            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        // action when form loads on page



    }
    
}