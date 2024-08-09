namespace studentprojectapi.Models
{
    public class AssignmentDTO
    {
        public Guid AssignmentID { get; set; }

        public Guid PersonID { get ; set; }

        public Guid DeptID { get; set; }

        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateOnly ModifiedDate { get; set; }

    }

    public class CreateAssignmentDTO : AssignmentDTO
    {
        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

        public string DeptName { get; set; } = null!;

        public string Email { get; set; } = null!;

    }

    public class ModifyAssignmentDTO : AssignmentDTO
    {
        public string ModifiedBy { get; set; }

        public DateOnly ModifiedDate { get; set; }
    }

    public class DeleteAssignmentDTO : AssignmentDTO
    {
        public Guid AssignmentID {  get; set; }

    }

}
