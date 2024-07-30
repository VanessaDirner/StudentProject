namespace studentprojectapi.Models
{
    public class PersonDTO
    {
        // don't need to to have a get set since we won't access it
        public Guid PersonId;

        public string FirstName { get; set; } = null!;
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PhoneNumber { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateOnly CreatedDate { get; set; }

        public string ModifiedBy  { get; set; }

        public DateOnly ModifiedDate { get; set; } 
 

    }
}
