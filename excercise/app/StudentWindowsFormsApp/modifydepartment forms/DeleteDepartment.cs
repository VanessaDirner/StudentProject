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
    public partial class DeleteDepartment : Form
    {


        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public DeleteDepartment()
        {
            InitializeComponent();

            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_deletedept_Click(object sender, EventArgs e)
        {
            bool isvalid = true;

           string depttodelete = txt_deptname_todelete.Text;
            department department = _studentprojectEntities.departments.SingleOrDefault(x => x.deptname == depttodelete);

            if (department == null)
            {
                isvalid = false;
                MessageBox.Show("Department not found, please verify your entry.");
            }
            // if person is assigned to department, cannot delete department


            if (isvalid)
            {
                try
                {
                    _studentprojectEntities.departments.Remove(department);

                    _studentprojectEntities.SaveChangesAsync();

                    MessageBox.Show("Department has been removed succesfully.");
                }
                catch
                {
                    MessageBox.Show("Department was not removed. Please check your request and try again later.");
                }



            }
        }

     
    }
}
