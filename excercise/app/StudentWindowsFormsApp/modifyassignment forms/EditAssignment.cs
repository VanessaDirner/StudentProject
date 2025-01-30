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
            employee existingemployee = _studentprojectEntities.employees.SingleOrDefault(x => x.email == txt_empemail.Text);

            // find existing dept by name
            department existingdept = _studentprojectEntities.departments.SingleOrDefault(x => x.deptname == txt_currentdeptname.Text);

            // find new dept by name
            department newdept = _studentprojectEntities.departments.SingleOrDefault(x => x.deptname == txt_newdeptname.Text);

            assignment findassignment;

            if (existingemployee != null && existingdept != null)
            {
                // check if employee already assigned to new dept
                findassignment = _studentprojectEntities.assignments.SingleOrDefault(x => x.deptID == existingdept.deptID && x.personID == existingemployee.personID);


                // is there an assignment?
                if (findassignment != null)
                {
                    isvalid = false;
                    // if not, nothing to modify
                    MessageBox.Show("No existing assignment of the employee to this department. Please use the add assignment option instead.");


                }
                else
                {
                    isvalid = false;
                    // if there is, check if there's an assignment with newdept
                    assignment istherethenewassignment = _studentprojectEntities.assignments.SingleOrDefault(x => x.deptID == newdept.deptID && x.personID == existingemployee.personID);

                }


                if (isvalid)
                {
                    try
                    {
                        // remove from old department in assignments
                        _studentprojectEntities.assignments.Remove(findassignment);
                        _studentprojectEntities.SaveChangesAsync();


                    }
                    catch
                    {
                        isvalid = false;
                        MessageBox.Show("Could not delete old assignment. Please try again or attempt an add and delete instead. Cancelling add.");
                    }

                    if (isvalid) try
                        {

                            // create the new assignment
                            assignment createassignmentobject = new assignment();

                            createassignmentobject.assignmentID = Guid.NewGuid();
                            createassignmentobject.personID = existingemployee.personID;
                            createassignmentobject.deptID = newdept.deptID;
                            createassignmentobject.createdby = "admin";
                            createassignmentobject.modifiedby = "admin";
                            createassignmentobject.createdate = DateTime.Now;
                            createassignmentobject.modifieddate = DateTime.Now;

                            // add to db
                            _studentprojectEntities.assignments.Add(createassignmentobject);

                            // save changes
                            _studentprojectEntities.SaveChangesAsync();


                            MessageBox.Show("Employee now assigned to new department, old assignment removed.");

                        }
                        catch
                        {
                            // add to new department in assignments
                            MessageBox.Show("Old department removed, but new department not added. Please try an add assignment request. Thanks!");
                        }
                }



            }


        }
    }
}
