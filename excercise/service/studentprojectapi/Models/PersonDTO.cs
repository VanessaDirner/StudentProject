namespace studentprojectapi.Models
{
   
    public class PersonDTO
    {
        // don't need to to have a get set since we won't access it
        // TODO update database tables, rerun power tools reverse engineer, update DTOS
        // TODO add = null! for fields that should not be null

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int PhoneNumber { get; set; }
    
        public DateTime StartDate { get; set; }
    
        public DateTime EndDate { get; set; }

        public bool Active { get; set; } 
     
        public string CreatedBy { get; }
  
        public DateTime CreatedDate { get; }
    
        public string ModifiedDate { get; }

        public string ModifiedBy { get; }
    }

    public class getPersonDTO : PersonDTO
    {
        public Guid PersonId;
 
        public string Email { get; set; }

    }

    public class addPersonDTO : PersonDTO
    {
        public string CreatedBy { get; set;  } = null!;

        public DateTime CreatedDate { get; set;  }

    }

    public class updatePersonDTO : PersonDTO
    {
        public string ModifyByEmail { get; set; } = null!;

        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }
    }

    public class deletepersonDTO
    {
        public Guid DeleteByEmail { get; set; }

    }

}


