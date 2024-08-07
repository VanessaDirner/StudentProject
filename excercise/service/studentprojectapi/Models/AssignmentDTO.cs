namespace studentprojectapi.Models
{
    public class AssignmentDTO
    {
        public Guid AssignmentID;

        public Guid PersonID;

        public Guid DeptID;
    }

    public class CreateAssignmentDTO : AssignmentDTO
    {
        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

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
