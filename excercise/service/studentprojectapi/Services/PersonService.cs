using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;

// this whole thing is how to create a personservice object that we can use to query database
namespace studentprojectapi.Services
{
    public class PersonService
    {   // CONTEXT IS DATABASE
        // this is an object of studentprojectcontext class
        private readonly studentprojectContext _database_context;

        // we're using this to work with our database
        public PersonService(studentprojectContext context) { _database_context = context; }

        // write function to get list of people
         public async Task<List<employee>> GetEmployeesAsync() {
            List<employee> ListofEmployees = await (from row in _database_context.employees select row).ToListAsync();

            return ListofEmployees;
         }

        // write function to person by ID
        public async Task<List<employee>> GetEmployeeByIDAsync(Guid personID)
        {
           
           // select * from employee where personID = '00000000-0000-0000-0000-000000000000'
         //   var employee = await _database_context.employees.FindAsync(personID); 
            var employee2 = await (from row in _database_context.employees where row.personID == personID select row ).ToListAsync();

            return employee2;
        }

        // write function to add a person

        public async Task AddEmployeeAsync(PersonDTO person)
        {
            // how do I add a person?
            // get details from input on user
            // check for existing user in db
            // add the user and return details or would the be no return/void?

            // map personDTO to employee from generated model so it can be added to database
            employee employeeobject = new employee();

            employeeobject.personID = Guid.NewGuid();
            employeeobject.firstname = person.FirstName;
            employeeobject.lastname = person.LastName;
            employeeobject.email = person.Email;
            employeeobject.phonenumber = person.PhoneNumber;
            employeeobject.startdate = person.StartDate;
            employeeobject.enddate = person.EndDate;
            employeeobject.active = person.Active;
            employeeobject.createdby = person.CreatedBy;
            employeeobject.createdate = DateTime.Now;
            employeeobject.modifiedby = person.ModifiedBy;
            employeeobject.modifieddate = DateTime.Now;

                        // then add to database
            _database_context.employees.Add(employeeobject);

            // save changes to database
            await _database_context.SaveChangesAsync();

           // return employee.personID?

        }

    

        //write function to modify a person
       public async Task ModifyEmployee (PersonDTO person)
        {
            employee employeeobject = new employee();
            

            // what to do for ID?
            employeeobject.modifieddate= DateTime.Now;
            employeeobject.modifiedby= person.ModifiedBy;
            employeeobject.active= person.Active;



        }

        // write function to remove a person

    }
}
