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

        public string ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }

    public class getPersonDTO : PersonDTO
    {
        public Guid PersonId;
 
        public string getEmail { get; set; }

    }

    public class addPersonDTO : PersonDTO
    {
        public string addEmail { get; set; }

    }

    public class updatePersonDTO : PersonDTO
    {
        public string ModifyByEmail { get; set; } = null!;

    }

    public class deletepersonDTO
    {
        public string DeleteByEmail { get; set; } = null!;

    }

}


