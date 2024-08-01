using Microsoft.AspNetCore.Mvc;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using studentprojectapi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentprojectapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {

        // object of assignment controller class
        private readonly AssignmentServices _assignmentServices;

        public AssignmentController(AssignmentServices assignmentServices)
        {
            _assignmentServices = assignmentServices;
        }

        // handle a get assignments request
        [HttpGet]
        public async Task<ActionResult<List<AssignmentDTO>>> GetAsssignments()
        {
            List<assignment> returnassignments = await _assignmentServices.GetAssignmentsAsync();

            return Ok(returnassignments);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AddAssignment([FromBody] AssignmentDTO assignmentDTO)
        {
            await _assignmentServices.AddAssignmentsAsync(assignmentDTO);

            return Ok();
        }

/*

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        */
    }
}
