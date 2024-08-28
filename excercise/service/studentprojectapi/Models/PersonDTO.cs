namespace studentprojectapi.Models
{
   
    public class PersonDTO
    {
        // TODO add = null! for fields that should not be null
        public Guid personID;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int PhoneNumber { get; set; }
    
        public DateTime StartDate { get; set; }
    
        public DateTime EndDate { get; set; }

        public bool Active { get; set; }

        //have an init instead of set since 'create' audit fields shouldn't be updated once set
        public string CreatedBy { get; init; } = null!;
            
        public DateTime CreatedDate { get; init; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }


    public class deletepersonDTO
    {
        public string DeleteByEmail { get; set; } = null!;

    }

}


