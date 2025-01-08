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
    public partial class EditDepartment : Form
    {

        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public EditDepartment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_editdepartment_Click(object sender, EventArgs e)
        {

            // TODO handle creating department on click
            // set defaults for some variables for checking form
            bool isvalid = true;

            // send items from form into variables
            string DepartmentName = txt_editdeptname.Text; //.Text;
            string DepartmentAbbreviation = txt_editdeptabbrv.Text; // txtdeptabbr.Text;

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

            // if form filled out ok, process form and show confirmation of save
            if (isvalid)
            {

                // create employee object
                var department = new department();

                // assign variables from form to database object equivalents
                department.deptname = DepartmentName;
                department.abbreviation = DepartmentAbbreviation;
                department.createdate = DateTime.Now;
                department.modifieddate = DateTime.Now;
                department.createdby = "admin";
                department.modifiedby = "admin";


                try
                {


                    // send details to database
                    //_studentprojectEntities.departments.


                    // save changes to database
                    _studentprojectEntities.SaveChanges();

                    // show confirmation of adding employee
                    MessageBox.Show($"Department modification successful.\n\r" +
                        $"Department Name: {DepartmentName} \n\r" +
                        $"Department Abbreviation: {DepartmentAbbreviation} \n\r" +
                        $"Date Modified: {department.modifieddate} \n\r" +
                        $"Modified by: {department.modifiedby} \n\r");



                    //TODO  reload datagrid with updated info



                }
                catch
                {
                    // if save is unsuccesful, show failure message
                    MessageBox.Show($"Department modification unsuccesful.\n\r" +
                        $"Please modify your request and try again," +
                        $" or contact an administrator.");
                }

            }
        }
    }
}