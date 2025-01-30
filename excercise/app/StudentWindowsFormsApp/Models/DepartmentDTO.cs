using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    public class DepartmentDTO
    {
        public Guid DeptID { get; }

        public string DeptName { get; set; }

        public string Abbreviation { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }

    public class DeleteDepartmentDTO : DepartmentDTO
    {
        public string deletebyEmail { get; set; }



    }
}
