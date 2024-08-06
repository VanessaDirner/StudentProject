using Microsoft.AspNetCore.Mvc;
using studentprojectapi.Models;
using studentprojectapi.GeneratedModels;
using Microsoft.Identity.Client;
using studentprojectapi.Services;

namespace studentprojectapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        // object of person service class
        private readonly PersonService _personService;


        // this is a constructor
        // we're using this to be able to use the person service methods below
        public PersonController(PersonService service) { 
            _personService = service;
         }


        // this is an api endpoint
        [HttpGet]
        public async Task<ActionResult<List<PersonDTO>>> GetEmployees()
        {
            // list of employee objects
            // calling the get employees async method that is part of the object _personService created above
            List<employee> returnemployees = await _personService.GetEmployeesAsync();
            // this is the result of my actionresult
            // this is returning 200/OK
            return Ok(returnemployees);

            // can add a try catch later to have a 400/500 etc error
            // then add httpget 400, 200 etc specified for right above api endpoint 
        }




        [HttpPost("Add")]
        public async Task<ActionResult> AddEmployee([FromBody] PersonDTO personDTO ) 
       {
            // get add details from body of get request
            // personDTO is the format in which the body of the request arrives
            // it's specified on the swagger page 
            // we'll send this to the service that will translate this to the model of the database

            await _personService.AddEmployeeAsync(personDTO);
            
            
            return Ok();
        }

        [HttpPut("Modify")]
        // I don't want to accept a new GUID
        // I don't want createddate and createdby to be updated either
        // I need to match details with a GUID in table
        public async Task<ActionResult> ModifyEmployee([FromBody] updatePersonDTO updatepersonDTO)
        {
            await _personService.ModifyEmployeeService(updatepersonDTO);

            return Ok();
        }


        [HttpDelete("Delete")]
       public async Task<ActionResult> DeleteEmployee([FromBody] deletepersonDTO deletepersonDTO)
        {
            await _personService.DeleteEmployeeService(deletepersonDTO);

            return Ok();
        }


    }
}
