using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    public class PersonDTO
    {
        // TODO add = null! for fields that should not be null
        public Guid personID;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Active { get; set; }

        //have an init instead of set since 'create' audit fields shouldn't be updated once set
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }


    public class deletepersonDTO
    {
        public string DeleteByEmail { get; set; }

    }
}
