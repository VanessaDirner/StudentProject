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
    public partial class EditEmployee : Form
    {


        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public EditEmployee()
        {
            InitializeComponent();

            _studentprojectEntities = new studentprojectEntities();
        }

        private void btnEmpEditSubmit_Click(object sender, EventArgs e)
        {


            // todo get input from fields, use email to search for employee to edit

            var employeeobject =  _studentprojectEntities.employees.SingleOrDefault(emp => emp.email == updateperson.Email);

            // throw exception so that ID can't be invalid so that return employee can't be null
            if (updateperson == null)
            {
                throw new Exception("Please provide email address and details to be modified when submitting request.");
            }
            else if (employeeobject == null)
            {
                throw new Exception("Email address is not associated with an account. Please supply the email address of the account to modify.");
            }
            //todo
            //map manually instead of with mapper 
            employee updateemployeeobject = _mapper.Map<employee>(updateperson);

            employeeobject.modifieddate = DateTime.Now;

            _studentprojectEntities.Entry(employeeobject).State = EntityState.Modified;

             _studentprojectEntities.SaveChangesAsync();
        }
    }
}
