namespace studentprojectapi.Models
{
   
    public class PersonDTO
    {
        // don't need to to have a get set since we won't access it
        // TODO update database tables, rerun power tools reverse engineer, update DTOS
        // TODO add = null! for fields that should not be null

        public Guid PersonId { get; }
        /// <summary>
        /// first name of employee
        /// </summary>

        public string FirstName { get; set; } = null!;
        /// <summary>
        /// last name of employee
        /// </summary>
        public string LastName { get; set; } = null!;
        /// <summary>
        /// email on record for employee
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// phone on record
        /// </summary>
        public int PhoneNumber { get; set; }
        /// <summary>
        /// start date 
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// whether employee account is active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// account that created the employee user
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// date that user account was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// account that modified the user account
        /// </summary>
        public string ModifiedBy  { get; set; }
        /// <summary>
        /// Date user was modified
        /// </summary>
        public DateTime  ModifiedDate { get; set; } 
        

    }
}
