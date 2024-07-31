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

        //
        public PersonService(studentprojectContext context) { _database_context = context; }

        // write function to get list of people
         public async Task<List<employee>> GetEmployeesAsync() {
            List<employee> ListofEmployees = await (from row in _database_context.employees select row).ToListAsync();

            return ListofEmployees;
         }

        // write function to add a person

        public async Task AddEmployeeAsync(PersonDTO person)
        {
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

        }

        // write function to remove a person

        //write function to modify a person




    }
}
