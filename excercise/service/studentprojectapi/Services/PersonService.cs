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
        // 

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

           // return employee.personID?
        }

    

        //write function to modify a person
       public async Task ModifyEmployeeService(updatePersonDTO updateperson)
        {

            employee? employee = await _database_context.employees.FindAsync(updateperson.UpdateID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (employee == null)
            {
                throw new Exception("invalid person ID");
            }

            employee.firstname = updateperson.FirstName;
            employee.lastname = updateperson.LastName;
            employee.email = updateperson.Email;
            employee.phonenumber= updateperson.PhoneNumber;
            employee.startdate = updateperson.StartDate;
            employee.enddate = updateperson.EndDate;
            employee.active = updateperson.Active;
            employee.modifieddate = DateTime.Now;
            employee.modifiedby = updateperson.ModifiedBy;

            _database_context.Entry(employee).State = EntityState.Modified;

            await _database_context.SaveChangesAsync();



        }


        // write function to remove a person
        // get details by ID?
        // delete row
        public async Task DeleteEmployeeService(deletepersonDTO deleteperson)
        {
            employee? employee = await _database_context.employees.FindAsync(deleteperson.deleteID);

            if (deleteperson == null)
            {
                throw new Exception("invalid person ID");
            }

          //  var deleteemployee = from employee in _database_context.employees where employee.personID == deleteperson.deleteID select employee;

            _database_context.employees.Remove(employee);


            await _database_context.SaveChangesAsync();

        }
    }
}
