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
    public partial class EditAssignment : Form
    {

        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();

        public EditAssignment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_updatedept_Click(object sender, EventArgs e)
        {
            bool isvalid = true;

            // find employee by email

            // find existing dept by name

            // find new dept by name

            // check if employee already assigned to new dept

            // remove from old department in assignments

            // add to new department in assignments
        }
    }
}
