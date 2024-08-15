using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

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

 
        // write function to add a person
        public async Task<employee> AddEmployeeAsync(addPersonDTO addperson)
        {

            // add check to see whether person already exists with a temp object
            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(emp => emp.email == addperson.Email);

            if (employeeobject != null)
            {

                throw new Exception("Employee with that email already exists. Pick another email to create a new account. Or, modify existing account.");
            }

            // map personDTO to employee from generated model so it can be added to database
            employee newemployeeobject = new employee();

            newemployeeobject.personID = Guid.NewGuid();
            newemployeeobject.firstname = addperson.FirstName;
            newemployeeobject.lastname = addperson.LastName;
            newemployeeobject.email = addperson.Email;
            newemployeeobject.phonenumber = addperson.PhoneNumber;
            newemployeeobject.startdate = addperson.StartDate;
            newemployeeobject.enddate = addperson.EndDate;
            newemployeeobject.active = addperson.Active;
            newemployeeobject.createdby = addperson.CreatedBy;
            newemployeeobject.createdate = DateTime.Now;
            newemployeeobject.modifieddate = DateTime.Now;
            newemployeeobject.modifiedby = addperson.ModifiedBy;
            // then add to database
            _database_context.employees.Add(newemployeeobject);

            // save changes to database
            await _database_context.SaveChangesAsync();

            return newemployeeobject;
        }

    

        //write function to modify a person
       public async Task<employee> ModifyEmployeeService(updatePersonDTO updateperson)
        {

            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(emp => emp.email == updateperson.ModifyByEmail);

            // throw exception so that ID can't be invalid so that return employee can't be null
            if (updateperson == null)
            {
                throw new Exception("Please provide email address and details to be modified when submitting request.");
            }
            else if (employeeobject == null)
            {
                throw new Exception("Invalid employee email address. Please supply the email address of the account to modify.");
            }

            employeeobject.firstname = updateperson.FirstName;
            employeeobject.lastname = updateperson.LastName;
            employeeobject.email = updateperson.Email;
            employeeobject.phonenumber= updateperson.PhoneNumber;
            employeeobject.startdate = updateperson.StartDate;
            employeeobject.enddate = updateperson.EndDate;
            employeeobject.active = updateperson.Active;
            employeeobject.modifieddate = DateTime.Now;
            employeeobject.modifiedby = updateperson.ModifiedBy;

            _database_context.Entry(employeeobject).State = EntityState.Modified;

            await _database_context.SaveChangesAsync();

            return employeeobject;

        }


        // write function to remove a person
        // get details by ID?
        // delete row
        public async Task DeleteEmployeeService(deletepersonDTO deleteperson)
        {
            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(delemp => delemp.email == deleteperson.DeleteByEmail);

            //empty body
            if (deleteperson.DeleteByEmail == null)
            {
                throw new Exception("Please provide a valid employee email so that the account can be found and deleted.");
            }
            // empty result when searching for account
            else if (employeeobject == null)
            {
                throw new Exception("No account with that email address was found. Please double check and resubmit request.");
            } 
            
            // delete account
            _database_context.employees.Remove(employeeobject);


            await _database_context.SaveChangesAsync();

        }
    }
}
