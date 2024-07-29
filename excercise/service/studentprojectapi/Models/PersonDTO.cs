namespace studentprojectapi.Models
{
    public class PersonDTO
    {
        // don't need to to have a get set since we won't access it
        public int PersonId;

        public string FirstName { get; set; } = null!;
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /*
         * 
         */
        public string Phone { get; set; }

        public string PhoneNumber { get; set; }



    }
}
