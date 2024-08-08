namespace studentprojectapi.Models
{
    public class DepartmentDTO
    {
        public Guid DeptID { get; }

        public string DeptName {  get; set; }

        public string Abbreviation { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }

    public class CreateDepartmentDTO : DepartmentDTO
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

    }

    public class ModifyDepartmentDTO : DepartmentDTO
    {
        public Guid modifyDeptID { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class DeleteDepartmentDTO : DepartmentDTO
    {
        public Guid DeptID { get; set; }

    }
}
