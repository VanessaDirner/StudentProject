using Microsoft.AspNetCore.Mvc;
using studentprojectapi.Models;
using studentprojectapi.GeneratedModels;
using Microsoft.Identity.Client;
using studentprojectapi.Services;

namespace studentprojectapi.Controllers
{
    #region setup
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

        #endregion setup

        #region api
        /// <summary>
        /// This is a summary comment thingy
        /// </summary>
        /// <param>
        /// THis is a parameter comment thingy
        /// </param>
        /// <example>
        /// This is an example comment?!?!?!
        /// </example>
        /// <returns>
        /// Returns result of deletion or an error
        /// </returns>
        // this is an api endpoint
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PersonDTO>> GetEmployees()
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PersonDTO>> AddEmployee([FromBody] PersonDTO personDTO ) 
       {
            // get add details from body of get request
            // personDTO is the format in which the body of the request arrives
            // it's specified on the swagger page 
            // we'll send this to the service that will translate this to the model of the database
            
            try
            {
                employee returnemployee = await _personService.AddEmployeeAsync(personDTO);

                return Ok(returnemployee);
            }
            catch
            {
                // either there's a person in the list or not, no way to mess up the api get request here so no need for 4XX error
                // 5XX will be returned anyways
                return BadRequest();
            }




        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="updatepersonDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        // I don't want to accept a new GUID
        // I don't want createddate and createdby to be updated either
        // I need to match details with a GUID in table
        public async Task<ActionResult<PersonDTO>> ModifyEmployee([FromBody] PersonDTO updatepersonDTO)
        {
            try
            {
                employee returnemployee = await _personService.ModifyEmployeeService(updatepersonDTO);

                return Ok(returnemployee);
            }
            catch (Exception ex)
            {
               return StatusCode(404, "this is the not found error");
                
            }

        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="deletepersonDTO"></param>
        /// <returns></returns>
        [HttpDelete]
        // this is documenting what kind of return types are possible (shows in swagger)
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(418)]
        [ProducesResponseType(500)]
        public async Task<ActionResult> DeleteEmployee([FromBody] deletepersonDTO deletepersonDTO)
        {
            try
            {
                await _personService.DeleteEmployeeService(deletepersonDTO);
                return Ok();
            }
            catch (Exception e)
            {
                if(e.Message == "No account with that email address was found. Please double check and resubmit request.")
                {
                    return StatusCode(404, "this is the not found error");
                }
                else if(e.Message == "Employee is assigned to a department. Please remove the assignment before deleting employee.")
                {
                    return StatusCode(418, "not sure what the actual error code is supposed to be but would you like some tea?");
                }
                else
                {
                    return StatusCode(500, "uknown server error");
                }
            }
          

           
            // later, do I want to return something?
        }

        #endregion api
    }
}
