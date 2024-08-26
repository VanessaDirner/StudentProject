namespace studentprojectapi.Models
{

    public class AssignmentDTO 
    {
        public Guid AssignmentID { get; }

        //why init for email and department?
        //no point in changing assigned department, just delete assignment and create another

        // this is our unique key to get an account

        public Guid PersonID { get; init; }

        public Guid DeptID { get; init; }

        public string EmployeeEmail { get; init; }

        // this is our unique key to get department
        public string DepartmentName { get; init; }

        public string CreatedBy { get; init; }

        public DateTime CreatedDate { get; init; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
 
   
    public class DeleteAssignmentDTO
    {
        public Guid AssignmentID {  get; set; }

        public string EmployeeEmail { get; }

        public string DepartmentName { get; }

    }

}
