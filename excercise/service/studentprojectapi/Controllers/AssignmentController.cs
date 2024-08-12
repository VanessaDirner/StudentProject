using Microsoft.AspNetCore.Mvc;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using studentprojectapi.Services;
using System.Reflection.Metadata.Ecma335;

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
        public async Task<ActionResult> AddAssignment([FromBody] CreateAssignmentDTO assignmentDTO)
        {
            await _assignmentServices.AddAssignmentsAsync(assignmentDTO);

            return Ok();
        }
        /*
        [HttpPut("Modify")]
        public async Task<ActionResult> ModifyAssignment([FromBody] ModifyAssignmentDTO assignmentDTO)
            {
                await _assignmentServices.ModifyAssignmentAsync(assignmentDTO);

                return Ok();
            }

        */
        [HttpDelete("Delete")]
           public async Task<ActionResult> DeleteAssignment([FromBody] DeleteAssignmentDTO deleteassignmentDTO)
               {
                    await _assignmentServices.DeleteAssignmentAsync(deleteassignmentDTO);

                    return Ok();
               }
        

    }
}
