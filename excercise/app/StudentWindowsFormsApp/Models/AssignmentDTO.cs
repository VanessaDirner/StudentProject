using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    public class AssignmentDTO
    {
        public Guid AssignmentID { get; }

        //why init for email and department?
        //no point in changing assigned department, just delete assignment and create another

        // this is our unique key to get an account

        public Guid PersonID { get; set; }

        public Guid DeptID { get; set; }

        public string EmployeeEmail { get; set; }

        // this is our unique key to get department
        public string DepartmentName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }


    public class DeleteAssignmentDTO
    {
        public Guid AssignmentID { get; set; }

        public string EmployeeEmail { get; }

        public string DepartmentName { get; }

    }
}
