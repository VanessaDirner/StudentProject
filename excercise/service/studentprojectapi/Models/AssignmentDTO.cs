namespace studentprojectapi.Models
{
    public class AssignmentDTO
    {
        public Guid AssignmentID;

        public Guid PersonID;

        public Guid DeptID;

        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateOnly ModifiedDate { get; set; }

    }
}
