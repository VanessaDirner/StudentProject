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
    }
}
