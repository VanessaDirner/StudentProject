namespace studentprojectapi.Models
{
    public class reportAssignmentDTO
    {
        public Guid AssignmentID { get; }

        public Guid PersonID { get;  }

        public Guid DeptID { get;  }

       
        public string FirstName { get; } = null!;
        /// <summary>
        /// last name of employee
        /// </summary>
        public string LastName { get; } = null!;
        /// <summary>
        /// email on record for employee
        /// </summary>
        public string Email { get; } = null!;
        /// <summary>
        /// phone on record
        /// </summary>
        public int PhoneNumber { get; }
        /// <summary>
        /// start date 
        /// </summary>

        public bool Active { get; }

        public string DeptName { get; }

        public string Abbreviation { get; }

    }

}
