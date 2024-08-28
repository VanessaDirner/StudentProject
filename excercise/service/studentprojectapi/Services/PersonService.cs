using AutoMapper;
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
        private readonly IMapper _mapper;

        // we're using this to work with our database
        //  this is a constructor
        // we specify that we need to parameters here - mapper and database context
        public PersonService(studentprojectContext context, IMapper mapper) { _database_context = context; _mapper = mapper; }

        // write function to get list of people
         public async Task<List<employee>> GetEmployeesAsync() {
            List<employee> ListofEmployees = await (from row in _database_context.employees select row).ToListAsync();

            return ListofEmployees;
         }

 
        // write function to add a person
        public async Task<employee> AddEmployeeAsync(PersonDTO addperson)
        {

            // add check to see whether person already exists with a temp object
            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(emp => emp.email == addperson.Email);

            if (employeeobject != null)
            {

                throw new Exception("Employee with that email already exists. Pick another email to create a new account. Or, modify existing account.");
            }

            // map personDTO to employee from generated model so it can be added to database
            //   employee newemployeeobject = new employee();


            employee newemployeeobject = _mapper.Map<employee>(addperson);

            newemployeeobject.createdate = DateTime.Now;
            newemployeeobject.modifieddate = DateTime.Now;
 

            
            // then add to database
            _database_context.employees.Add(newemployeeobject);

            // save changes to database
            await _database_context.SaveChangesAsync();

            return newemployeeobject;
        }

    

        //write function to modify a person
       public async Task<employee> ModifyEmployeeService(PersonDTO updateperson)
        {

            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(emp => emp.email == updateperson.Email);

            // throw exception so that ID can't be invalid so that return employee can't be null
            if (updateperson == null)
            {
                throw new Exception("Please provide email address and details to be modified when submitting request.");
            }
            else if (employeeobject == null)
            {
                throw new Exception("Email address is not associated with an account. Please supply the email address of the account to modify.");
            }
                       
            employee updateemployeeobject = _mapper.Map<employee>(updateperson);

            employeeobject.modifieddate = DateTime.Now;

            _database_context.Entry(employeeobject).State = EntityState.Modified;

            await _database_context.SaveChangesAsync();

            return employeeobject;

        }


        // write function to remove a person
        // get details by ID?
        // delete row
        public async Task DeleteEmployeeService(deletepersonDTO deleteperson)
        {

            // find employee by email
            employee? employeeobject = await _database_context.employees.SingleOrDefaultAsync(delemp => delemp.email == deleteperson.DeleteByEmail);

            // check if employee is assigned to a department
            assignment? existingassignment = await _database_context.assignments.SingleOrDefaultAsync(assign => assign.personID == employeeobject.personID);

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
            else if (existingassignment != null)
            {
                throw new Exception("Employee is assigned to a department. Please remove the assignment before deleting employee.");
            }
            
            // delete account
            _database_context.employees.Remove(employeeobject);


            await _database_context.SaveChangesAsync();

        }
    }
}
