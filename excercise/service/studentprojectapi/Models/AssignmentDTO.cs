namespace studentprojectapi.Models
{
    public class AssignmentDTO
    {
        public Guid AssignmentID { get; }

        public Guid PersonID { get; set; }

        public Guid DeptID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }

    public class CreateAssignmentDTO : AssignmentDTO
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }


    }

    public class ModifyAssignmentDTO : AssignmentDTO
    {
        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class DeleteAssignmentDTO
    {
        public Guid AssignmentID {  get; set; }

    }

}
