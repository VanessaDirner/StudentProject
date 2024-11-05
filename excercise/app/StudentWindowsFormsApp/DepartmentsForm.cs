using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class DepartmentsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DepartmentsForm()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            // load database table and save to a variable, assign variable names to the data and create a list to hold it all
            // var department = _studentprojectEntities.departments.ToList();
            var department = _studentprojectEntities.departments.Select(items => new
            {
                DeptName = items.deptname,
                deptabbr = items.abbreviation,
                datecreated = items.createdate,
                datemodified = items.modifieddate,
                createdby = items.createdby,
                modifiedby = items.modifiedby
            }).ToList();


            // maybe todo resize grid for data, or change it's background


            // set the viewDepartments object's datasource to the variable we just created
            viewDepartments.DataSource = department;
        }


        private void btnDeptSubmit_Click(object sender, EventArgs e)
        {
            // TODO handle creating department on click
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string DepartmentName = txt_deptname.Text;
            string DepartmentAbbreviation = txtdeptabbr.Text;

            //verify details from form before saving details

            // check if any fields are null
            // (except for any fields with defaults or non required fields)
            if ((string.IsNullOrWhiteSpace(DepartmentName) ||
                string.IsNullOrWhiteSpace(DepartmentAbbreviation) ) )                             
            {
                isvalid = false;
                MessageBox.Show("Required fields are empty." +
                    "Please double check and resubmit request.");
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

                //TODO reload datagrid

            }


        }
    }

}