namespace studentprojectapi.Models
{
    public class DepartmentDTO
    {
        public Guid DeptID;

        public string DeptName {  get; set; }

        public string Abbreviation { get; set; }

        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateOnly ModifiedDate { get; set; }
    }
}
