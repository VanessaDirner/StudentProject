using Microsoft.AspNetCore.Mvc;
using studentprojectapi.Models;
using studentprojectapi.GeneratedModels;
using Microsoft.Identity.Client;
using studentprojectapi.Services;

namespace studentprojectapi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DepartmentController : ControllerBase
    {
        // 
        private readonly DepartmentService _objectdepartmentService;

        // constructor
        public DepartmentController(DepartmentService deptservice)
        {
            _objectdepartmentService = deptservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<DepartmentDTO>>> GetDepartments()
        {
            List<department> returndepartments = await _objectdepartmentService.GetDepartmentsAsync();

            return Ok(returndepartments);
        }

        [HttpPost("Add")]
        public async Task<ActionResult<DepartmentDTO>> AddDepartmentAsync(DepartmentDTO createDepartmentDTO)
        {
            await _objectdepartmentService.AddDepartmentAsync(createDepartmentDTO);

            return Ok();
        }
            

        [HttpPut("Modify")]
        public async Task<ActionResult> ModifyDepartments(DepartmentDTO modifydepartmentDTO)
        {
            await _objectdepartmentService.ModifyDepartmentsService(modifydepartmentDTO);

            return Ok();
        }


        [HttpDelete("Delete")]
        public async Task<ActionResult> DeleteDepartmentService(DeleteDepartmentDTO deletedepartmentdto)
        {
            await _objectdepartmentService.DeleteDepartmentService(deletedepartmentdto);

            return Ok();    
        }

    }

}
